using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // Configuration flags stored in io.ConfigFlags. Set by user/application.
    public enum ImGuiConfigFlags : int
    {
        None = 0,
        NavEnableKeyboard = 1 << 0,   // Master keyboard navigation enable flag. NewFrame() will automatically fill io.NavInputs[] based on io.KeysDown[].
        NavEnableGamepad = 1 << 1,   // Master gamepad navigation enable flag. This is mostly to instruct your imgui back-end to fill io.NavInputs[]. Back-end also needs to set ImGuiBackendFlags_HasGamepad.
        NavEnableSetMousePos = 1 << 2,   // Instruct navigation to move the mouse cursor. May be useful on TV/console systems where moving a virtual mouse is awkward. Will update io.MousePos and set io.WantSetMousePos=true. If enabled you MUST honor io.WantSetMousePos requests in your binding, otherwise ImGui will react as if the mouse is jumping around back and forth.
        NavNoCaptureKeyboard = 1 << 3,   // Instruct navigation to not set the io.WantCaptureKeyboard flag when io.NavActive is set.
        NoMouse = 1 << 4,   // Instruct imgui to clear mouse position/buttons in NewFrame(). This allows ignoring the mouse information set by the back-end.
        NoMouseCursorChange = 1 << 5,   // Instruct back-end to not alter mouse cursor shape and visibility. Use if the back-end cursor changes are interfering with yours and you don't want to use SetMouseCursor() to change mouse cursor. You may want to honor requests from imgui by reading GetMouseCursor() yourself instead.

        // [BETA] Docking
        DockingEnable = 1 << 6,   // Docking enable flags.

        // [BETA] Viewports
        // When using viewports it is recommended that your default value for ImGuiCol_WindowBg is opaque (Alpha=1.0) so transition to a viewport won't be noticeable.
        ViewportsEnable = 1 << 10,  // Viewport enable flags (require both ImGuiConfigFlags_PlatformHasViewports + ImGuiConfigFlags_RendererHasViewports set by the respective back-ends)
        DpiEnableScaleViewports = 1 << 14,  // [BETA: Don't use] FIXME-DPI: Reposition and resize imgui windows when the DpiScale of a viewport changed (mostly useful for the main viewport hosting other window). Note that resizing the main window itself is up to your application.
        DpiEnableScaleFonts = 1 << 15,  // [BETA: Don't use] FIXME-DPI: Request bitmap-scaled fonts to match DpiScale. This is a very low-quality workaround. The correct way to handle DPI is _currently_ to replace the atlas and/or fonts in the Platform_OnChangedViewport callback, but this is all early work in progress.

        // User storage (to allow your back-end/engine to communicate to code that may be shared between multiple projects. Those flags are not used by core Dear ImGui)
        IsSRGB = 1 << 20,  // Application is SRGB-aware.
        IsTouchScreen = 1 << 21   // Application is using a touch screen instead of a mouse.
    }


    public class ImGuiIO
    {
        public static implicit operator ImGuiIO(IntPtr p)
        {
            return new ImGuiIO(p);
        }

        readonly IntPtr m_p;

        public ImGuiIO(IntPtr ptr)
        {
            m_p = ptr;
        }

        public ImGuiConfigFlags ConfigFlags
        {
            get => (ImGuiConfigFlags)Marshal.ReadInt32(IntPtr.Add(m_p, 0));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 0), (int)value);
        }
    }

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

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetIO();

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