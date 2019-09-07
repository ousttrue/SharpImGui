using System;
using System.Runtime.InteropServices;
using Win32API;

namespace sample
{
    class Program
    {
        static LRESULT WndProc(HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam)
        {
            return User32.DefWindowProcW(hwnd, uMsg, wParam, lParam);
        }

        const string WINDOW_CLASS = "SharpImGuiClass";

        static void Main(string[] args)
        {
            var windowProc = new WNDPROC(WndProc);
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

            User32.ShowWindow(hwnd, SW.SHOW);

            MSG msg = default;
            while (User32.GetMessageW(ref msg, default, 0, 0))
            {
                User32.TranslateMessage(ref msg);
                User32.DispatchMessage(ref msg);
            }
        }
    }
}
