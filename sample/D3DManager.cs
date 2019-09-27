using System;
using System.Numerics;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpImGui;
using Win32API;

namespace sample
{
    class Im3dContext : IDisposable
    {
        IntPtr m_context;
        public Im3dContext()
        {
            m_context = Im3d.NewContext();
        }

        public void Dispose()
        {
            if (m_context != IntPtr.Zero)
            {
                Im3d.DestoryContext(m_context);
                m_context = IntPtr.Zero;
            }
        }

        public void Set()
        {
            Im3d.SetContext(m_context);
        }
    }

    class D3DManager : IDisposable
    {
        SharpDX.Direct3D11.Device m_device;
        public SharpDX.Direct3D11.Device Device => m_device;

        SwapChain m_swapChain;

        SharpDX.Direct3D11.RenderTargetView m_rtv;
        SharpDX.Direct3D11.DepthStencilView m_dsv;
        // SharpDX.Direct3D11.DepthStencilState m_ds;

        IntPtr m_imgui;

        Im3dContext m_im3d = new Im3dContext();

        public D3DManager()
        {
            SharpDX.Configuration.EnableObjectTracking = true;
        }

        public void Dispose()
        {
            Im3d.Im3d_DX11_Finalize();
            m_im3d.Dispose();
            m_im3d=null;

            ImGui.ImGui_ImplDX11_Shutdown();
            ImGui.ImGui_ImplWin32_Shutdown();
            if (m_imgui != IntPtr.Zero)
            {
                ImGui.DestroyContext(m_imgui);
                m_imgui = IntPtr.Zero;
            }

            ClearRTV();
            if (m_swapChain != null)
            {
                m_swapChain.Dispose();
                m_swapChain = null;
            }
            if (m_device != null)
            {
                m_device.Dispose();
                m_device = null;
            }
            Console.WriteLine(SharpDX.Diagnostics.ObjectTracker.ReportActiveObjects());
        }

        void ClearRTV()
        {
            Device.ImmediateContext.OutputMerger.SetRenderTargets(
                (DepthStencilView)null, (RenderTargetView)null);
            if (m_rtv != null)
            {
                // clear swapchain user
                m_rtv.Dispose();
                m_rtv = null;
            }
            if (m_dsv != null)
            {
                m_dsv.Dispose();
                m_dsv = null;
            }
            // if (m_ds != null)
            // {
            //     m_ds.Dispose();
            //     m_ds = null;
            // }
        }

        public void SetHWnd(IntPtr hwnd)
        {
            RECT rect = default;
            User32.GetClientRect(new Win32API.HWND { Value = hwnd }, out rect);
            int width = rect.right.Value - rect.left.Value;
            int height = rect.bottom.Value - rect.top.Value;

            var desc = new SwapChainDescription()
            {
                BufferCount = 1,
                ModeDescription = new ModeDescription(width, height,
                    new Rational(60, 1),
                    Format.R8G8B8A8_UNorm),
                IsWindowed = true,
                OutputHandle = hwnd,
                SampleDescription = new SampleDescription(1, 0),
                SwapEffect = SwapEffect.Discard,
                Usage = Usage.RenderTargetOutput
            };

            // Create Device and SwapChain
            SharpDX.Direct3D11.Device.CreateWithSwapChain(
                SharpDX.Direct3D.DriverType.Hardware,
                SharpDX.Direct3D11.DeviceCreationFlags.Debug | SharpDX.Direct3D11.DeviceCreationFlags.BgraSupport,
                desc,
                out m_device, out m_swapChain);

            m_imgui = ImGui.CreateContext(IntPtr.Zero);
            var io = (ImGuiIO)ImGui.GetIO();
            io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard;
            // Enable Keyboard Controls
            // io.ConfigFlags |= ImGuiConfigFlags.NavEnableGamepad;      // Enable Gamepad Controls
            io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;           // Enable Docking
            // io.ConfigFlags |= ImGuiConfigFlags.ViewportsEnable;         // Enable Multi-Viewport / Platform Windows
            //io.ConfigViewportsNoAutoMerge = true;
            //io.ConfigViewportsNoTaskBarIcon = true;
            //io.ConfigViewportsNoDefaultParent = true;
            //io.ConfigDockingAlwaysTabBar = true;
            //io.ConfigDockingTransparentPayload = true;
            // #if 1
            //     io.ConfigFlags |= ImGuiConfigFlags_DpiEnableScaleFonts;     // FIXME-DPI: THIS CURRENTLY DOESN'T WORK AS EXPECTED. DON'T USE IN USER APP!
            //     io.ConfigFlags |= ImGuiConfigFlags_DpiEnableScaleViewports; // FIXME-DPI
            // #endif

            AddJapaneseFontFromFileTTF("c:\\Windows\\Fonts\\meiryo.ttc", 18.0f);

            ImGui.ImGui_ImplWin32_Init(hwnd);
            ImGui.ImGui_ImplDX11_Init(
                Device.NativePointer,
                Device.ImmediateContext.NativePointer);

            ImGui.DX11_Initialize();
            Im3d.Im3d_DX11_Initialize();
        }

        static void AddJapaneseFontFromFileTTF(string filename, float size_pixels)
        {
            var io = (ImGuiIO)ImGui.GetIO();
            var glyph = ImGui.exImFontAtlas_GetGlyphRangesJapanese(io.Fonts);
            ImGui.exImFontAtlas_AddFontFromFileTTF(io.Fonts, filename, size_pixels, IntPtr.Zero, glyph);
        }

        bool m_show_demo_window = true;
        bool m_show_another_window = true;

        float m_f = 0.0f;
        int m_counter = 0;

        Vector3 m_clear_color = new Vector3(0.4f, 0.3f, 0.6f);

        Matrix4x4 m_model = Matrix4x4.Identity;

        void UpdateGui()
        {
            // Start the Dear ImGui frame
            ImGui.ImGui_ImplDX11_NewFrame();
            ImGui.ImGui_ImplWin32_NewFrame();
            ImGui.NewFrame();

            // 1. Show the big demo window (Most of the sample code is in ImGui.ShowDemoWindow()! You can browse its code to learn more about Dear ImGui!).
            if (m_show_demo_window)
            {
                ImGui.ShowDemoWindow(ref m_show_demo_window);
            }

            // 2. Show a simple window that we create ourselves. We use a Begin/End pair to created a named window.
            {
                ImGui.Begin("Hello, world!");                          // Create a window called "Hello, world!" and append into it.

                ImGui.Text("This is some useful text.");               // Display some text (you can use a format strings too)
                ImGui.Checkbox("Demo Window", ref m_show_demo_window);      // Edit bools storing our window open/close state
                ImGui.Checkbox("Another Window", ref m_show_another_window);

                ImGui.SliderFloat("float", ref m_f, 0.0f, 1.0f);            // Edit 1 float using a slider from 0.0f to 1.0f
                ImGui.ColorEdit3("clear color", ref m_clear_color.X); // Edit 3 floats representing a color

                var size = Vector2.Zero;
                if (ImGui.Button("Button", ref size))
                {                            // Buttons return true when clicked (most widgets return true when edited/activated)
                    m_counter++;
                }
                ImGui.SameLine();
                ImGui.Text($"counter = {m_counter}");

                var frameRate = ((ImGuiIO)ImGui.GetIO()).Framerate;
                ImGui.Text($"Application average {1000.0f / frameRate:000.} ms/frame ({frameRate:.0} FPS)");
                ImGui.End();
            }

            // 3. Show another simple window.
            if (m_show_another_window)
            {
                ImGui.Begin("Another Window", ref m_show_another_window);   // Pass a pointer to our bool variable (the window will have a closing button that will clear the bool when clicked)

                var x = ImGui.GetContentRegionAvail();

                ImGui.Text("Hello from another window!");
                Vector2 size = default;
                if (ImGui.Button("Close Me", ref size))
                    m_show_another_window = false;
                ImGui.End();
            }

            ImGui.Render();
        }

        public void Update(TimeSpan deltaTime, int w, int h, ref CameraState camera, ref MouseState mouse)
        {
            Resize(w, h);
            if (m_rtv == null)
            {
                // New RenderTargetView from the backbuffer
                using (var backBuffer = Texture2D.FromSwapChain<Texture2D>(m_swapChain, 0))
                {
                    backBuffer.DebugName = "backBuffer";
                    m_rtv = new RenderTargetView(Device, backBuffer);

                    var depthDesc = backBuffer.Description;
                    depthDesc.MipLevels = 1;
                    depthDesc.ArraySize = 1;
                    depthDesc.Format = SharpDX.DXGI.Format.D24_UNorm_S8_UInt;
                    depthDesc.BindFlags = BindFlags.DepthStencil;
                    using (var depthTexture = new SharpDX.Direct3D11.Texture2D(backBuffer.Device, depthDesc))
                    {
                        m_dsv = new SharpDX.Direct3D11.DepthStencilView(backBuffer.Device, depthTexture);
                    }
                }
            }

            // if (m_ds == null)
            // {
            //     m_ds = new DepthStencilState(Device,
            //     new DepthStencilStateDescription
            //     {
            //         IsDepthEnabled = true,
            //         DepthWriteMask = DepthWriteMask.All,
            //         DepthComparison = Comparison.Less,
            //     });
            // }

            UpdateGui();

            //
            // D3D
            //
            Device.ImmediateContext.ClearRenderTargetView(m_rtv,
            new SharpDX.Mathematics.Interop.RawColor4(m_clear_color.X, m_clear_color.Y, m_clear_color.Z, 1.0f));
            Device.ImmediateContext.ClearDepthStencilView(m_dsv, DepthStencilClearFlags.Depth | DepthStencilClearFlags.Stencil, 1.0f, 0);

            m_im3d.Set();
            Im3d.Im3dGui_NewFrame(ref camera, ref mouse, (float)deltaTime.TotalSeconds, -1);
            Im3d.Gizmo("gizmo", ref m_model.M11);
            Im3d.EndFrame();
        }

        public void Draw(ref Matrix4x4 viewProjection)
        {
            Device.ImmediateContext.OutputMerger.SetRenderTargets(m_dsv, m_rtv);
            Device.ImmediateContext.Rasterizer.SetViewport(0, 0, m_width, m_height, 0, 1.0f);

            // Device.ImmediateContext.OutputMerger.SetDepthStencilState(m_ds);
            ImGui.DX11_DrawTeapot(Device.ImmediateContext.NativePointer, ref viewProjection.M11, ref m_model.M11);
            Im3d.Im3d_DX11_Draw(Device.ImmediateContext.NativePointer, ref viewProjection.M11, m_width, m_height, Im3d.GetDrawLists(), (int)Im3d.GetDrawListCount().Value);
            ImGui.ImGui_ImplDX11_RenderDrawData(ImGui.GetDrawData());

            m_swapChain.Present(0, PresentFlags.None);
        }

        int m_width;
        int m_height;
        void Resize(int width, int height)
        {
            if (m_width == width && m_height == height)
            {
                return;
            }
            m_width = width;
            m_height = height;
            ClearRTV();
            var desc = m_swapChain.Description;
            m_swapChain.ResizeBuffers(desc.BufferCount, width, height,
                desc.ModeDescription.Format, desc.Flags);
        }
    }
}