using System;
using System.Runtime.InteropServices;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Win32API;

namespace sample
{
    class DeviceManager : IDisposable
    {
        SharpDX.Direct3D11.Device m_device;
        // SharpDX.Direct3D11.DeviceContext m_context;
        SwapChain m_swapChain;

        SharpDX.Direct3D11.RenderTargetView m_rtv;

        public DeviceManager()
        {
            SharpDX.Configuration.EnableObjectTracking = true;
        }

        public void Dispose()
        {
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
            if (m_rtv != null)
            {
                // clear swapchain user
                m_rtv.Dispose();
                m_rtv = null;
            }
        }

        public void SetHWnd(HWND hwnd)
        {
            RECT rect = default;
            User32.GetClientRect(hwnd, out rect);
            int width = rect.right.Value - rect.left.Value;
            int height = rect.bottom.Value - rect.top.Value;

            var desc = new SwapChainDescription()
            {
                BufferCount = 1,
                ModeDescription = new ModeDescription(width, height,
                    new Rational(60, 1),
                    Format.R8G8B8A8_UNorm),
                IsWindowed = true,
                OutputHandle = hwnd.Value,
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
        }

        public void Draw()
        {
            if (m_rtv == null)
            {
                // New RenderTargetView from the backbuffer
                using (var backBuffer = Texture2D.FromSwapChain<Texture2D>(m_swapChain, 0))
                {
                    backBuffer.DebugName = "backBuffer";
                    m_rtv = new RenderTargetView(m_device, backBuffer);
                }
            }

            m_device.ImmediateContext.ClearRenderTargetView(m_rtv,
            new SharpDX.Mathematics.Interop.RawColor4(0.2f, 0.2f, 0.4f, 1.0f));

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
            var device = new DeviceManager();

            var windowProc = new WNDPROC((HWND _hwnd, WM uMsg, WPARAM wParam, LPARAM lParam) =>
            {
                switch (uMsg)
                {
                    case WM.DESTROY:
                        device.Dispose();
                        User32.PostQuitMessage(0);
                        return 0;

                    case WM.RESIZE:
                        device.Resize(lParam.LowWord, lParam.HiWord);
                        return 0;

                    case WM.PAINT:
                        {
                            PAINTSTRUCT ps = default;
                            var hdc = User32.BeginPaint(_hwnd, ref ps);
                            device.Draw();
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
            device.SetHWnd(hwnd);

            User32.ShowWindow(hwnd, SW.SHOW);

            using (var gui = new SharpImGui.Wrapper())
            {

                MSG msg = default;
                while (User32.GetMessageW(ref msg, default, 0, 0))
                {
                    User32.TranslateMessage(ref msg);
                    User32.DispatchMessage(ref msg);
                }

            }
        }
    }
}
