using System;
using System.Runtime.InteropServices;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpImGui;
using Win32API;

namespace sample
{
    class DeviceManager : IDisposable
    {
        SharpDX.Direct3D11.Device m_device;
        public SharpDX.Direct3D11.Device Device => m_device;

        // SharpDX.Direct3D11.DeviceContext m_context;
        SwapChain m_swapChain;

        SharpDX.Direct3D11.RenderTargetView m_rtv;

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

            ImGui.ImGui_ImplWin32_Init(hwnd);
            ImGui.ImGui_ImplDX11_Init(
                Device.NativePointer,
                Device.ImmediateContext.NativePointer);
        }

        bool m_show_demo_window = true;

        public void Draw()
        {
            if (m_rtv == null)
            {
                // New RenderTargetView from the backbuffer
                using (var backBuffer = Texture2D.FromSwapChain<Texture2D>(m_swapChain, 0))
                {
                    backBuffer.DebugName = "backBuffer";
                    m_rtv = new RenderTargetView(Device, backBuffer);
                }
            }

            // Start the Dear ImGui frame
            ImGui.ImGui_ImplDX11_NewFrame();
            ImGui.ImGui_ImplWin32_NewFrame();
            ImGui.NewFrame();

            // 1. Show the big demo window (Most of the sample code is in ImGui::ShowDemoWindow()! You can browse its code to learn more about Dear ImGui!).
            if (m_show_demo_window)
            {
                ImGui.ShowDemoWindow(ref m_show_demo_window);
            }

            ImGui.Render();

            Device.ImmediateContext.ClearRenderTargetView(m_rtv,
            new SharpDX.Mathematics.Interop.RawColor4(0.2f, 0.2f, 0.4f, 1.0f));

            Device.ImmediateContext.OutputMerger.SetRenderTargets(m_rtv);

            ImGui.ImGui_ImplDX11_RenderDrawData(ImGui.GetDrawData());

            m_swapChain.Present(0, PresentFlags.None);
        }

        public void Resize(int width, int height)
        {
            if (m_swapChain == null)
            {
                return;
            }
            ClearRTV();
            var desc = m_swapChain.Description;
            m_swapChain.ResizeBuffers(desc.BufferCount, width, height,
                desc.ModeDescription.Format, desc.Flags);
        }
    }

    class Program
    {
        const string WINDOW_CLASS = "SharpImGuiClass";

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
                        manager.Resize(lParam.LowWord, lParam.HiWord);
                        return 0;

                    case WM.PAINT:
                        {
                            PAINTSTRUCT ps = default;
                            var hdc = User32.BeginPaint(_hwnd, ref ps);
                            User32.EndPaint(_hwnd, ref ps);
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

            MSG msg = default;
            while (msg.message != WM.QUIT)
            {
                // Poll and handle messages (inputs, window resize, etc.)
                // You can read the io.WantCaptureMouse, io.WantCaptureKeyboard flags to tell if dear imgui wants to use your inputs.
                // - When io.WantCaptureMouse is true, do not dispatch mouse input data to your main application.
                // - When io.WantCaptureKeyboard is true, do not dispatch keyboard input data to your main application.
                // Generally you may always pass all inputs to dear imgui, and hide them from your application based on those two flags.
                if (User32.PeekMessageW(ref msg, IntPtr.Zero, 0, 0, PM.REMOVE))
                {
                    User32.TranslateMessage(ref msg);
                    User32.DispatchMessage(ref msg);
                    continue;
                }

                manager.Draw();
            }
        }
    }
}
