using System;
using System.Runtime.InteropServices;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpImGui;
using System.Numerics;
using Win32API;
using System.Diagnostics;
using System.Threading;

namespace sample
{
    class DeviceManager : IDisposable
    {
        SharpDX.Direct3D11.Device m_device;
        public SharpDX.Direct3D11.Device Device => m_device;

        // SharpDX.Direct3D11.DeviceContext m_context;
        SwapChain m_swapChain;

        SharpDX.Direct3D11.RenderTargetView m_rtv;
        // SharpDX.Direct3D11.DepthStencilView m_dsv;

        IntPtr m_imgui;

        public DeviceManager()
        {
            SharpDX.Configuration.EnableObjectTracking = true;
        }

        public void Dispose()
        {
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
            // if (m_dsv != null)
            // {
            //     m_dsv.Dispose();
            //     m_dsv = null;
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

        public void Update(ref Matrix4x4 viewProjection, int w, int h)
        {
            Resize(w, h);
            if (m_rtv == null)
            {
                // New RenderTargetView from the backbuffer
                using (var backBuffer = Texture2D.FromSwapChain<Texture2D>(m_swapChain, 0))
                {
                    backBuffer.DebugName = "backBuffer";
                    m_rtv = new RenderTargetView(Device, backBuffer);

                    // var depthDesc = backBuffer.Description;
                    // depthDesc.MipLevels = 1;
                    // depthDesc.ArraySize = 1;
                    // depthDesc.Format = SharpDX.DXGI.Format.D24_UNorm_S8_UInt;
                    // depthDesc.BindFlags = BindFlags.DepthStencil;
                    // using (var depthTexture = new SharpDX.Direct3D11.Texture2D(backBuffer.Device, depthDesc))
                    // {
                    //     m_dsv = new SharpDX.Direct3D11.DepthStencilView(backBuffer.Device, depthTexture);
                    // }
                }
            }

            UpdateGui();

            //
            // D3D
            //
            Device.ImmediateContext.ClearRenderTargetView(m_rtv,
            new SharpDX.Mathematics.Interop.RawColor4(m_clear_color.X, m_clear_color.Y, m_clear_color.Z, 1.0f));
            // Device.ImmediateContext.ClearDepthStencilView(m_dsv,
            //     DepthStencilClearFlags.Depth | DepthStencilClearFlags.Stencil,
            // 1.0f, 0);
        }

        public void Draw(ref Matrix4x4 viewProjection)
        {
            Device.ImmediateContext.OutputMerger.SetRenderTargets(m_rtv);
            Device.ImmediateContext.Rasterizer.SetViewport(0, 0, m_width, m_height, 0, 1.0f);

            ImGui.DX11_DrawTeapot(Device.ImmediateContext.NativePointer, ref viewProjection.M11, ref m_model.M11);
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

    class FpsTimer
    {
        TimeSpan m_frameTime;
        Stopwatch m_sw;

        int m_sleep;

        public FpsTimer(int fps)
        {
            m_frameTime = TimeSpan.FromMilliseconds(1000.0 / fps);
            m_sw = Stopwatch.StartNew();
            m_sleep = (int)m_frameTime.TotalMilliseconds;
        }


        TimeSpan m_begin;
        // public void BeginFrame()
        // {
        //     m_begin = m_sw.Elapsed;
        // }

        public void Wait()
        {
            var now = m_sw.Elapsed;
            var delta = now - m_begin;
            m_begin = now;

            if (delta > m_frameTime)
            {
                m_sleep--;
                if (m_sleep < 1)
                {
                    m_sleep = 1;
                }
            }
            else
            {
                m_sleep++;
                if (m_sleep > m_frameTime.TotalMilliseconds)
                {
                    m_sleep = (int)m_frameTime.TotalMilliseconds;
                }
            }

            Thread.Sleep(m_sleep);
            // Console.WriteLine(sleep);
        }
    }

    class OrbitCamera
    {
        public CameraState state = new CameraState
        {
            fovYRadians = 30.0f / 180.0f * MathF.PI
        };

        float zNear = 0.1f;
        float zFar = 100.0f;
        float aspectRatio = 1.0f;

        int prevMouseX = -1;
        int prevMouseY = -1;

        float shiftX = 0;
        float shiftY = 0;
        float shiftZ = 2.0f;
        float yawRadians = 0;
        float pitchRadians = 0;

        public OrbitCamera()
        {
            CalcView();
            CalcPerspective();
            CalcViewProjection();
        }

        void CalcView()
        {
            var yaw = Matrix4x4.CreateRotationY(yawRadians);
            var pitch = Matrix4x4.CreateRotationX(pitchRadians);
            var yawPitch = yaw * pitch;
            var t = Matrix4x4.CreateTranslation(-shiftX, -shiftY, -shiftZ);
            state.view = yawPitch * t;

            t.M12 *= -1;
            t.M13 *= -1;
            t.M14 *= -1;
            state.viewInverse = t * Matrix4x4.Transpose(yawPitch);
        }

        void CalcPerspective()
        {
            state.projection = Matrix4x4.CreatePerspectiveFieldOfView(state.fovYRadians, aspectRatio, zNear, zFar);
        }

        void CalcViewProjection()
        {
            state.viewProjection = state.view * state.projection;
        }

        void SetViewport(int x, int y, int w, int h)
        {
            if (w == state.viewportWidth && h == state.viewportHeight)
            {
                return;
            }
            if (h == 0 || w == 0)
            {
                aspectRatio = 1.0f;
            }
            else
            {
                aspectRatio = w / (float)h;
            }
            // state.viewportX = x;
            // state.viewportY = y;
            state.viewportWidth = w;
            state.viewportHeight = h;
            CalcPerspective();
        }

        public void MouseInput(MouseState mouse, int width, int height)
        {
            SetViewport(0, 0, width, height);

            if (prevMouseX != -1 && prevMouseY != -1)
            {
                var deltaX = mouse.X - prevMouseX;
                var deltaY = mouse.Y - prevMouseY;

                if (mouse.Buttons.HasFlag(ButtonFlags.Right))
                {
                    const float FACTOR = 1.0f / 180.0f * 1.7f;
                    yawRadians -= deltaX * FACTOR;
                    pitchRadians += deltaY * FACTOR;
                }
                if (mouse.Buttons.HasFlag(ButtonFlags.Middle))
                {
                    shiftX -= deltaX / (float)state.viewportHeight * shiftZ;
                    shiftY += deltaY / (float)state.viewportHeight * shiftZ;
                }
                if (mouse.Wheel > 0)
                {
                    shiftZ *= 0.9f;
                }
                else if (mouse.Wheel < 0)
                {
                    shiftZ *= 1.1f;
                }
            }
            prevMouseX = mouse.X;
            prevMouseY = mouse.Y;
            CalcView();
            CalcViewProjection();
        }
    }

    class Program
    {
        const string WINDOW_CLASS = "SharpImGuiClass";

        static int s_width;
        static int s_height;

        static MouseState s_mouse;
        static bool s_clearWheel;

        static void Main(string[] args)
        {
            var manager = new DeviceManager();

            var windowProc = new WNDPROC((Win32API.HWND _hwnd, WM uMsg, Win32API.WPARAM wParam, Win32API.LPARAM lParam) =>
            {
                if (ImGui.ImGui_ImplWin32_WndProcHandler(_hwnd.Value, (uint)uMsg, wParam.Value, lParam.Value) != IntPtr.Zero)
                {
                    return 1;
                }

                switch (uMsg)
                {
                    case WM.DESTROY:
                        manager.Dispose();
                        User32.PostQuitMessage(0);
                        return 0;

                    case WM.RESIZE:
                        // manager.Resize(lParam.LowWord, lParam.HiWord);
                        s_width = lParam.LowWord;
                        s_height = lParam.HiWord;
                        return 0;

                    case WM.PAINT:
                        {
                            PAINTSTRUCT ps = default;
                            var hdc = User32.BeginPaint(_hwnd, ref ps);
                            User32.EndPaint(_hwnd, ref ps);
                            return 0;
                        }

                    case WM.MOUSEMOVE:
                        {
                            s_mouse.X = lParam.LowWord;
                            s_mouse.Y = lParam.HiWord;
                            return 0;
                        }

                    case WM.LBUTTONDOWN:
                        {
                            // User32.SetCapture(_hwnd);
                            s_mouse.Buttons |= ButtonFlags.Left;
                            return 0;
                        }

                    case WM.LBUTTONUP:
                        {
                            s_mouse.Buttons &= ~ButtonFlags.Left;
                            if (s_mouse.Buttons == 0)
                            {
                                // User32.ReleaseCapture();
                            }
                            return 0;
                        }

                    case WM.MBUTTONDOWN:
                        {
                            // SetCapture(hWnd);
                            s_mouse.Buttons |= ButtonFlags.Middle;
                            return 0;
                        }

                    case WM.MBUTTONUP:
                        {
                            s_mouse.Buttons &= ~ButtonFlags.Middle;
                            if (s_mouse.Buttons == 0)
                            {
                                // ReleaseCapture();
                            }
                            return 0;
                        }

                    case WM.RBUTTONDOWN:
                        {
                            // SetCapture(hWnd);
                            s_mouse.Buttons |= ButtonFlags.Right;
                            return 0;
                        }

                    case WM.RBUTTONUP:
                        {
                            s_mouse.Buttons &= ~ButtonFlags.Right;
                            if (s_mouse.Buttons == 0)
                            {
                                // ReleaseCapture();
                            }
                            return 0;
                        }

                    case WM.MOUSEWHEEL:
                        {
                            s_clearWheel = false;
                            var d = wParam.HiWord;
                            if (d > 0)
                            {
                                s_mouse.Wheel = 1;
                            }
                            else if (d < 0)
                            {
                                s_mouse.Wheel = -1;
                            }
                            else
                            {
                                s_mouse.Wheel = 0;
                            }
                            return 0;
                        }
                }

                return User32.DefWindowProcW(_hwnd, uMsg, wParam, lParam);
            });
            var ptr = Marshal.GetFunctionPointerForDelegate(windowProc);

            var windowClass = new WNDCLASSEXW();
            windowClass.cbSize = Marshal.SizeOf(typeof(WNDCLASSEXW));
            windowClass.style = CS.HREDRAW | CS.VREDRAW;
            windowClass.lpfnWndProc = ptr;
            windowClass.cbClsExtra = 0;
            windowClass.cbWndExtra = 0;
            windowClass.lpszClassName = WINDOW_CLASS;
            var register = User32.RegisterClassExW(ref windowClass);
            if (register == 0)
            {
                Console.WriteLine("fail to RegisterClassExW");
                return;
            }

            var hwnd = User32.CreateWindowExW(
                0,
                WINDOW_CLASS,
                "SharpImGui",
                WS.OVERLAPPEDWINDOW,
                32, 32,
                256, 256,
                default,
                default,
                IntPtr.Zero,
                default);
            if (hwnd == default)
            {
                Console.WriteLine("fail to CreateWindowExW");
                return;
            }
            manager.SetHWnd(hwnd);

            User32.ShowWindow(hwnd, SW.SHOW);
            OrbitCamera camera = new OrbitCamera();

            var fps = new FpsTimer(30);
            MSG msg = default;
            while (true)
            {
                // Poll and handle messages (inputs, window resize, etc.)
                // You can read the io.WantCaptureMouse, io.WantCaptureKeyboard flags to tell if dear imgui wants to use your inputs.
                // - When io.WantCaptureMouse is true, do not dispatch mouse input data to your main application.
                // - When io.WantCaptureKeyboard is true, do not dispatch keyboard input data to your main application.
                // Generally you may always pass all inputs to dear imgui, and hide them from your application based on those two flags.
                while (User32.PeekMessageW(ref msg, IntPtr.Zero, 0, 0, PM.REMOVE))
                {
                    if (msg.message == WM.QUIT)
                    {
                        return;
                    }
                    User32.TranslateMessage(ref msg);
                    User32.DispatchMessage(ref msg);
                }

                camera.MouseInput(s_mouse, s_width, s_height);
                s_clearWheel = true;
                s_mouse.Wheel = 0;

                manager.Update(ref camera.state.viewProjection, s_width, s_height);

                fps.Wait();

                manager.Draw(ref camera.state.viewProjection);
            }
        }
    }
}
