using System;
using System.Runtime.InteropServices;
using SharpImGui;
using Win32API;

namespace sample
{
    class Program
    {
        const string WINDOW_CLASS = "SharpImGuiClass";

        static int s_width;
        static int s_height;

        static MouseState s_mouse;
        static bool s_clearWheel;

        static void Main(string[] args)
        {
            var manager = new D3DManager();

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