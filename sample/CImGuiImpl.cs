using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    public static class CImGuiImpl
    {
        const string DllName = "cimgui.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(IntPtr shared_font_atlas);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetDrawData();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(ref bool p_open);

        #region dx11 extras
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ImGui_ImplDX11_Init(IntPtr device, IntPtr device_context);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_Shutdown();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_NewFrame();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_RenderDrawData(IntPtr draw_data);
        #endregion

        #region win32 extras
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ImGui_ImplWin32_Init(IntPtr hwnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_Shutdown();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_NewFrame();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_ImplWin32_WndProcHandler(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        #endregion
    }
}