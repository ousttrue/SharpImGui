// generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    public static class ImGui
    {
        const string DLLNAME = "imgui.dll";

        // imgui_impl_win32.h:13
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_Init@@YA_NPEAX@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ImGui_ImplWin32_Init(IntPtr hwnd = default);

        // imgui_impl_win32.h:14
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_Shutdown@@YAXXZ")]
        public static extern void ImGui_ImplWin32_Shutdown();

        // imgui_impl_win32.h:15
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_NewFrame@@YAXXZ")]
        public static extern void ImGui_ImplWin32_NewFrame();

        // imgui_impl_win32.h:18
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_EnableDpiAwareness@@YAXXZ")]
        public static extern void ImGui_ImplWin32_EnableDpiAwareness();

        // imgui_impl_win32.h:19
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_GetDpiScaleForHwnd@@YAMPEAX@Z")]
        public static extern float ImGui_ImplWin32_GetDpiScaleForHwnd(IntPtr hwnd = default);

        // imgui_impl_win32.h:20
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_GetDpiScaleForMonitor@@YAMPEAX@Z")]
        public static extern float ImGui_ImplWin32_GetDpiScaleForMonitor(IntPtr monitor = default);

        // imgui_impl_dx11.h:18
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_Init@@YA_NPEAUID3D11Device@@PEAUID3D11DeviceContext@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ImGui_ImplDX11_Init(IntPtr device = default, IntPtr device_context = default);

        // imgui_impl_dx11.h:19
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_Shutdown@@YAXXZ")]
        public static extern void ImGui_ImplDX11_Shutdown();

        // imgui_impl_dx11.h:20
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_NewFrame@@YAXXZ")]
        public static extern void ImGui_ImplDX11_NewFrame();

        // imgui_impl_dx11.h:21
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_RenderDrawData@@YAXPEAUImDrawData@@@Z")]
        public static extern void ImGui_ImplDX11_RenderDrawData(IntPtr draw_data = default);

        // imgui_impl_dx11.h:24
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_InvalidateDeviceObjects@@YAXXZ")]
        public static extern void ImGui_ImplDX11_InvalidateDeviceObjects();

        // imgui_impl_dx11.h:25
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplDX11_CreateDeviceObjects@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ImGui_ImplDX11_CreateDeviceObjects();

        // extras.h:9
        [DllImport(DLLNAME, EntryPoint="?ImGui_ImplWin32_WndProcHandler@@YAHHHHH@Z")]
        public static extern int ImGui_ImplWin32_WndProcHandler();

        // extras.h:11
        [DllImport(DLLNAME, EntryPoint="?exDockSpace@@YAXIUImVec2@@HPEBUImGuiWindowClass@@@Z")]
        public static extern void exDockSpace(ImGuiID id = default, ImVec2 size = default, ImGuiDockNodeFlags flags = default, IntPtr window_class = default);

        // extras.h:12
        [DllImport(DLLNAME, EntryPoint="?exDockSpaceOverViewport@@YAIPEAUImGuiViewport@@HPEBUImGuiWindowClass@@@Z")]
        public static extern ImGuiID exDockSpaceOverViewport(IntPtr viewport = default, ImGuiDockNodeFlags flags = default, IntPtr window_class = default);

        // extras.h:13
        [DllImport(DLLNAME, EntryPoint="?exSetNextWindowDockID@@YAXIH@Z")]
        public static extern void exSetNextWindowDockID(ImGuiID dock_id = default, ImGuiCond cond = default);

        // extras.h:14
        [DllImport(DLLNAME, EntryPoint="?exSetNextWindowClass@@YAXPEBUImGuiWindowClass@@@Z")]
        public static extern void exSetNextWindowClass(IntPtr window_class = default);

        // extras.h:15
        [DllImport(DLLNAME, EntryPoint="?exGetWindowDockID@@YAIXZ")]
        public static extern ImGuiID exGetWindowDockID();

        // extras.h:16
        [DllImport(DLLNAME, EntryPoint="?exIsWindowDocked@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool exIsWindowDocked();

        // imgui.h:221
        [DllImport(DLLNAME, EntryPoint="?CreateContext@ImGui@@YAPEAUImGuiContext@@PEAUImFontAtlas@@@Z")]
        public static extern IntPtr CreateContext(IntPtr shared_font_atlas = default);

        // imgui.h:222
        [DllImport(DLLNAME, EntryPoint="?DestroyContext@ImGui@@YAXPEAUImGuiContext@@@Z")]
        public static extern void DestroyContext(IntPtr ctx = default);

        // imgui.h:223
        [DllImport(DLLNAME, EntryPoint="?GetCurrentContext@ImGui@@YAPEAUImGuiContext@@XZ")]
        public static extern IntPtr GetCurrentContext();

        // imgui.h:224
        [DllImport(DLLNAME, EntryPoint="?SetCurrentContext@ImGui@@YAXPEAUImGuiContext@@@Z")]
        public static extern void SetCurrentContext(IntPtr ctx = default);

        // imgui.h:225
        [DllImport(DLLNAME, EntryPoint="?DebugCheckVersionAndDataLayout@ImGui@@YA_NPEBD_K11111@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DebugCheckVersionAndDataLayout([MarshalAs(UnmanagedType.LPUTF8Str)]string version_str = default, ulong sz_io = default, ulong sz_style = default, ulong sz_vec2 = default, ulong sz_vec4 = default, ulong sz_drawvert = default, ulong sz_drawidx = default);

        // imgui.h:228
        [DllImport(DLLNAME, EntryPoint="?GetIO@ImGui@@YAAEAUImGuiIO@@XZ")]
        public static extern IntPtr GetIO();

        // imgui.h:229
        [DllImport(DLLNAME, EntryPoint="?GetStyle@ImGui@@YAAEAUImGuiStyle@@XZ")]
        public static extern IntPtr GetStyle();

        // imgui.h:230
        [DllImport(DLLNAME, EntryPoint="?NewFrame@ImGui@@YAXXZ")]
        public static extern void NewFrame();

        // imgui.h:231
        [DllImport(DLLNAME, EntryPoint="?EndFrame@ImGui@@YAXXZ")]
        public static extern void EndFrame();

        // imgui.h:232
        [DllImport(DLLNAME, EntryPoint="?Render@ImGui@@YAXXZ")]
        public static extern void Render();

        // imgui.h:233
        [DllImport(DLLNAME, EntryPoint="?GetDrawData@ImGui@@YAPEAUImDrawData@@XZ")]
        public static extern IntPtr GetDrawData();

        // imgui.h:236
        [DllImport(DLLNAME, EntryPoint="?ShowDemoWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowDemoWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // imgui.h:236
        [DllImport(DLLNAME, EntryPoint="?ShowDemoWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowDemoWindow([MarshalAs(UnmanagedType.U1)]IntPtr p_open = default);

        // imgui.h:237
        [DllImport(DLLNAME, EntryPoint="?ShowAboutWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowAboutWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // imgui.h:237
        [DllImport(DLLNAME, EntryPoint="?ShowAboutWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowAboutWindow([MarshalAs(UnmanagedType.U1)]IntPtr p_open = default);

        // imgui.h:238
        [DllImport(DLLNAME, EntryPoint="?ShowMetricsWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowMetricsWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // imgui.h:238
        [DllImport(DLLNAME, EntryPoint="?ShowMetricsWindow@ImGui@@YAXPEA_N@Z")]
        public static extern void ShowMetricsWindow([MarshalAs(UnmanagedType.U1)]IntPtr p_open = default);

        // imgui.h:239
        [DllImport(DLLNAME, EntryPoint="?ShowStyleEditor@ImGui@@YAXPEAUImGuiStyle@@@Z")]
        public static extern void ShowStyleEditor(IntPtr _ref = default);

        // imgui.h:240
        [DllImport(DLLNAME, EntryPoint="?ShowStyleSelector@ImGui@@YA_NPEBD@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ShowStyleSelector([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default);

        // imgui.h:241
        [DllImport(DLLNAME, EntryPoint="?ShowFontSelector@ImGui@@YAXPEBD@Z")]
        public static extern void ShowFontSelector([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default);

        // imgui.h:242
        [DllImport(DLLNAME, EntryPoint="?ShowUserGuide@ImGui@@YAXXZ")]
        public static extern void ShowUserGuide();

        // imgui.h:243
        [DllImport(DLLNAME, EntryPoint="?GetVersion@ImGui@@YAPEBDXZ")]
        public static extern IntPtr GetVersion();

        // imgui.h:246
        [DllImport(DLLNAME, EntryPoint="?StyleColorsDark@ImGui@@YAXPEAUImGuiStyle@@@Z")]
        public static extern void StyleColorsDark(IntPtr dst = default);

        // imgui.h:247
        [DllImport(DLLNAME, EntryPoint="?StyleColorsClassic@ImGui@@YAXPEAUImGuiStyle@@@Z")]
        public static extern void StyleColorsClassic(IntPtr dst = default);

        // imgui.h:248
        [DllImport(DLLNAME, EntryPoint="?StyleColorsLight@ImGui@@YAXPEAUImGuiStyle@@@Z")]
        public static extern void StyleColorsLight(IntPtr dst = default);

        // imgui.h:260
        [DllImport(DLLNAME, EntryPoint="?Begin@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Begin([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiWindowFlags flags = default);

        // imgui.h:260
        [DllImport(DLLNAME, EntryPoint="?Begin@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Begin([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]IntPtr p_open = default, ImGuiWindowFlags flags = default);

        // imgui.h:261
        [DllImport(DLLNAME, EntryPoint="?End@ImGui@@YAXXZ")]
        public static extern void End();

        // imgui.h:268
        [DllImport(DLLNAME, EntryPoint="?BeginChild@ImGui@@YA_NPEBDAEBUImVec2@@_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginChild([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, IntPtr size = default, [MarshalAs(UnmanagedType.U1)]bool border = default, ImGuiWindowFlags flags = default);

        // imgui.h:269
        [DllImport(DLLNAME, EntryPoint="?BeginChild@ImGui@@YA_NIAEBUImVec2@@_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginChild(ImGuiID id = default, IntPtr size = default, [MarshalAs(UnmanagedType.U1)]bool border = default, ImGuiWindowFlags flags = default);

        // imgui.h:270
        [DllImport(DLLNAME, EntryPoint="?EndChild@ImGui@@YAXXZ")]
        public static extern void EndChild();

        // imgui.h:274
        [DllImport(DLLNAME, EntryPoint="?IsWindowAppearing@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsWindowAppearing();

        // imgui.h:275
        [DllImport(DLLNAME, EntryPoint="?IsWindowCollapsed@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsWindowCollapsed();

        // imgui.h:276
        [DllImport(DLLNAME, EntryPoint="?IsWindowFocused@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsWindowFocused(ImGuiFocusedFlags flags = default);

        // imgui.h:277
        [DllImport(DLLNAME, EntryPoint="?IsWindowHovered@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsWindowHovered(ImGuiHoveredFlags flags = default);

        // imgui.h:278
        [DllImport(DLLNAME, EntryPoint="?GetWindowDrawList@ImGui@@YAPEAUImDrawList@@XZ")]
        public static extern IntPtr GetWindowDrawList();

        // imgui.h:279
        [DllImport(DLLNAME, EntryPoint="?GetWindowDpiScale@ImGui@@YAMXZ")]
        public static extern float GetWindowDpiScale();

        // imgui.h:280
        [DllImport(DLLNAME, EntryPoint="?GetWindowViewport@ImGui@@YAPEAUImGuiViewport@@XZ")]
        public static extern IntPtr GetWindowViewport();

        // imgui.h:281
        [DllImport(DLLNAME, EntryPoint="?GetWindowPos@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetWindowPos();

        // imgui.h:282
        [DllImport(DLLNAME, EntryPoint="?GetWindowSize@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetWindowSize();

        // imgui.h:283
        [DllImport(DLLNAME, EntryPoint="?GetWindowWidth@ImGui@@YAMXZ")]
        public static extern float GetWindowWidth();

        // imgui.h:284
        [DllImport(DLLNAME, EntryPoint="?GetWindowHeight@ImGui@@YAMXZ")]
        public static extern float GetWindowHeight();

        // imgui.h:287
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowPos@ImGui@@YAXAEBUImVec2@@H0@Z")]
        public static extern void SetNextWindowPos(IntPtr pos = default, ImGuiCond cond = default, IntPtr pivot = default);

        // imgui.h:288
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowSize@ImGui@@YAXAEBUImVec2@@H@Z")]
        public static extern void SetNextWindowSize(IntPtr size = default, ImGuiCond cond = default);

        // imgui.h:289
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowSizeConstraints@ImGui@@YAXAEBUImVec2@@0P6AXPEAUImGuiSizeCallbackData@@@ZPEAX@Z")]
        public static extern void SetNextWindowSizeConstraints(IntPtr size_min = default, IntPtr size_max = default, IntPtr custom_callback = default, IntPtr custom_callback_data = default);

        // imgui.h:290
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowContentSize@ImGui@@YAXAEBUImVec2@@@Z")]
        public static extern void SetNextWindowContentSize(IntPtr size = default);

        // imgui.h:291
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowCollapsed@ImGui@@YAX_NH@Z")]
        public static extern void SetNextWindowCollapsed([MarshalAs(UnmanagedType.U1)]bool collapsed = default, ImGuiCond cond = default);

        // imgui.h:292
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowFocus@ImGui@@YAXXZ")]
        public static extern void SetNextWindowFocus();

        // imgui.h:293
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowBgAlpha@ImGui@@YAXM@Z")]
        public static extern void SetNextWindowBgAlpha(float alpha = default);

        // imgui.h:294
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowViewport@ImGui@@YAXI@Z")]
        public static extern void SetNextWindowViewport(ImGuiID viewport_id = default);

        // imgui.h:295
        [DllImport(DLLNAME, EntryPoint="?SetWindowPos@ImGui@@YAXAEBUImVec2@@H@Z")]
        public static extern void SetWindowPos(IntPtr pos = default, ImGuiCond cond = default);

        // imgui.h:296
        [DllImport(DLLNAME, EntryPoint="?SetWindowSize@ImGui@@YAXAEBUImVec2@@H@Z")]
        public static extern void SetWindowSize(IntPtr size = default, ImGuiCond cond = default);

        // imgui.h:297
        [DllImport(DLLNAME, EntryPoint="?SetWindowCollapsed@ImGui@@YAX_NH@Z")]
        public static extern void SetWindowCollapsed([MarshalAs(UnmanagedType.U1)]bool collapsed = default, ImGuiCond cond = default);

        // imgui.h:298
        [DllImport(DLLNAME, EntryPoint="?SetWindowFocus@ImGui@@YAXXZ")]
        public static extern void SetWindowFocus();

        // imgui.h:299
        [DllImport(DLLNAME, EntryPoint="?SetWindowFontScale@ImGui@@YAXM@Z")]
        public static extern void SetWindowFontScale(float scale = default);

        // imgui.h:300
        [DllImport(DLLNAME, EntryPoint="?SetWindowPos@ImGui@@YAXPEBDAEBUImVec2@@H@Z")]
        public static extern void SetWindowPos([MarshalAs(UnmanagedType.LPUTF8Str)]string name = default, IntPtr pos = default, ImGuiCond cond = default);

        // imgui.h:301
        [DllImport(DLLNAME, EntryPoint="?SetWindowSize@ImGui@@YAXPEBDAEBUImVec2@@H@Z")]
        public static extern void SetWindowSize([MarshalAs(UnmanagedType.LPUTF8Str)]string name = default, IntPtr size = default, ImGuiCond cond = default);

        // imgui.h:302
        [DllImport(DLLNAME, EntryPoint="?SetWindowCollapsed@ImGui@@YAXPEBD_NH@Z")]
        public static extern void SetWindowCollapsed([MarshalAs(UnmanagedType.LPUTF8Str)]string name = default, [MarshalAs(UnmanagedType.U1)]bool collapsed = default, ImGuiCond cond = default);

        // imgui.h:303
        [DllImport(DLLNAME, EntryPoint="?SetWindowFocus@ImGui@@YAXPEBD@Z")]
        public static extern void SetWindowFocus([MarshalAs(UnmanagedType.LPUTF8Str)]string name = default);

        // imgui.h:307
        [DllImport(DLLNAME, EntryPoint="?GetContentRegionMax@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetContentRegionMax();

        // imgui.h:308
        [DllImport(DLLNAME, EntryPoint="?GetContentRegionAvail@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetContentRegionAvail();

        // imgui.h:309
        [DllImport(DLLNAME, EntryPoint="?GetWindowContentRegionMin@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetWindowContentRegionMin();

        // imgui.h:310
        [DllImport(DLLNAME, EntryPoint="?GetWindowContentRegionMax@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetWindowContentRegionMax();

        // imgui.h:311
        [DllImport(DLLNAME, EntryPoint="?GetWindowContentRegionWidth@ImGui@@YAMXZ")]
        public static extern float GetWindowContentRegionWidth();

        // imgui.h:314
        [DllImport(DLLNAME, EntryPoint="?GetScrollX@ImGui@@YAMXZ")]
        public static extern float GetScrollX();

        // imgui.h:315
        [DllImport(DLLNAME, EntryPoint="?GetScrollY@ImGui@@YAMXZ")]
        public static extern float GetScrollY();

        // imgui.h:316
        [DllImport(DLLNAME, EntryPoint="?GetScrollMaxX@ImGui@@YAMXZ")]
        public static extern float GetScrollMaxX();

        // imgui.h:317
        [DllImport(DLLNAME, EntryPoint="?GetScrollMaxY@ImGui@@YAMXZ")]
        public static extern float GetScrollMaxY();

        // imgui.h:318
        [DllImport(DLLNAME, EntryPoint="?SetScrollX@ImGui@@YAXM@Z")]
        public static extern void SetScrollX(float scroll_x = default);

        // imgui.h:319
        [DllImport(DLLNAME, EntryPoint="?SetScrollY@ImGui@@YAXM@Z")]
        public static extern void SetScrollY(float scroll_y = default);

        // imgui.h:320
        [DllImport(DLLNAME, EntryPoint="?SetScrollHereX@ImGui@@YAXM@Z")]
        public static extern void SetScrollHereX(float center_x_ratio = default);

        // imgui.h:321
        [DllImport(DLLNAME, EntryPoint="?SetScrollHereY@ImGui@@YAXM@Z")]
        public static extern void SetScrollHereY(float center_y_ratio = default);

        // imgui.h:322
        [DllImport(DLLNAME, EntryPoint="?SetScrollFromPosX@ImGui@@YAXMM@Z")]
        public static extern void SetScrollFromPosX(float local_x = default, float center_x_ratio = default);

        // imgui.h:323
        [DllImport(DLLNAME, EntryPoint="?SetScrollFromPosY@ImGui@@YAXMM@Z")]
        public static extern void SetScrollFromPosY(float local_y = default, float center_y_ratio = default);

        // imgui.h:326
        [DllImport(DLLNAME, EntryPoint="?PushFont@ImGui@@YAXPEAUImFont@@@Z")]
        public static extern void PushFont(IntPtr font = default);

        // imgui.h:327
        [DllImport(DLLNAME, EntryPoint="?PopFont@ImGui@@YAXXZ")]
        public static extern void PopFont();

        // imgui.h:328
        [DllImport(DLLNAME, EntryPoint="?PushStyleColor@ImGui@@YAXHI@Z")]
        public static extern void PushStyleColor(ImGuiCol idx = default, uint col = default);

        // imgui.h:329
        [DllImport(DLLNAME, EntryPoint="?PushStyleColor@ImGui@@YAXHAEBUImVec4@@@Z")]
        public static extern void PushStyleColor(ImGuiCol idx = default, IntPtr col = default);

        // imgui.h:330
        [DllImport(DLLNAME, EntryPoint="?PopStyleColor@ImGui@@YAXH@Z")]
        public static extern void PopStyleColor(int count = default);

        // imgui.h:331
        [DllImport(DLLNAME, EntryPoint="?PushStyleVar@ImGui@@YAXHM@Z")]
        public static extern void PushStyleVar(ImGuiStyleVar idx = default, float val = default);

        // imgui.h:332
        [DllImport(DLLNAME, EntryPoint="?PushStyleVar@ImGui@@YAXHAEBUImVec2@@@Z")]
        public static extern void PushStyleVar(ImGuiStyleVar idx = default, IntPtr val = default);

        // imgui.h:333
        [DllImport(DLLNAME, EntryPoint="?PopStyleVar@ImGui@@YAXH@Z")]
        public static extern void PopStyleVar(int count = default);

        // imgui.h:334
        [DllImport(DLLNAME, EntryPoint="?GetStyleColorVec4@ImGui@@YAAEBUImVec4@@H@Z")]
        public static extern IntPtr GetStyleColorVec4(ImGuiCol idx = default);

        // imgui.h:335
        [DllImport(DLLNAME, EntryPoint="?GetFont@ImGui@@YAPEAUImFont@@XZ")]
        public static extern IntPtr GetFont();

        // imgui.h:336
        [DllImport(DLLNAME, EntryPoint="?GetFontSize@ImGui@@YAMXZ")]
        public static extern float GetFontSize();

        // imgui.h:337
        [DllImport(DLLNAME, EntryPoint="?GetFontTexUvWhitePixel@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetFontTexUvWhitePixel();

        // imgui.h:338
        [DllImport(DLLNAME, EntryPoint="?GetColorU32@ImGui@@YAIHM@Z")]
        public static extern uint GetColorU32(ImGuiCol idx = default, float alpha_mul = default);

        // imgui.h:339
        [DllImport(DLLNAME, EntryPoint="?GetColorU32@ImGui@@YAIAEBUImVec4@@@Z")]
        public static extern uint GetColorU32(IntPtr col = default);

        // imgui.h:340
        [DllImport(DLLNAME, EntryPoint="?GetColorU32@ImGui@@YAII@Z")]
        public static extern uint GetColorU32(uint col = default);

        // imgui.h:343
        [DllImport(DLLNAME, EntryPoint="?PushItemWidth@ImGui@@YAXM@Z")]
        public static extern void PushItemWidth(float item_width = default);

        // imgui.h:344
        [DllImport(DLLNAME, EntryPoint="?PopItemWidth@ImGui@@YAXXZ")]
        public static extern void PopItemWidth();

        // imgui.h:345
        [DllImport(DLLNAME, EntryPoint="?SetNextItemWidth@ImGui@@YAXM@Z")]
        public static extern void SetNextItemWidth(float item_width = default);

        // imgui.h:346
        [DllImport(DLLNAME, EntryPoint="?CalcItemWidth@ImGui@@YAMXZ")]
        public static extern float CalcItemWidth();

        // imgui.h:347
        [DllImport(DLLNAME, EntryPoint="?PushTextWrapPos@ImGui@@YAXM@Z")]
        public static extern void PushTextWrapPos(float wrap_local_pos_x = default);

        // imgui.h:348
        [DllImport(DLLNAME, EntryPoint="?PopTextWrapPos@ImGui@@YAXXZ")]
        public static extern void PopTextWrapPos();

        // imgui.h:349
        [DllImport(DLLNAME, EntryPoint="?PushAllowKeyboardFocus@ImGui@@YAX_N@Z")]
        public static extern void PushAllowKeyboardFocus([MarshalAs(UnmanagedType.U1)]bool allow_keyboard_focus = default);

        // imgui.h:350
        [DllImport(DLLNAME, EntryPoint="?PopAllowKeyboardFocus@ImGui@@YAXXZ")]
        public static extern void PopAllowKeyboardFocus();

        // imgui.h:351
        [DllImport(DLLNAME, EntryPoint="?PushButtonRepeat@ImGui@@YAX_N@Z")]
        public static extern void PushButtonRepeat([MarshalAs(UnmanagedType.U1)]bool repeat = default);

        // imgui.h:352
        [DllImport(DLLNAME, EntryPoint="?PopButtonRepeat@ImGui@@YAXXZ")]
        public static extern void PopButtonRepeat();

        // imgui.h:357
        [DllImport(DLLNAME, EntryPoint="?Separator@ImGui@@YAXXZ")]
        public static extern void Separator();

        // imgui.h:358
        [DllImport(DLLNAME, EntryPoint="?SameLine@ImGui@@YAXMM@Z")]
        public static extern void SameLine(float offset_from_start_x = default, float spacing = default);

        // imgui.h:359
        [DllImport(DLLNAME, EntryPoint="?NewLine@ImGui@@YAXXZ")]
        public static extern void NewLine();

        // imgui.h:360
        [DllImport(DLLNAME, EntryPoint="?Spacing@ImGui@@YAXXZ")]
        public static extern void Spacing();

        // imgui.h:361
        [DllImport(DLLNAME, EntryPoint="?Dummy@ImGui@@YAXAEBUImVec2@@@Z")]
        public static extern void Dummy(IntPtr size = default);

        // imgui.h:362
        [DllImport(DLLNAME, EntryPoint="?Indent@ImGui@@YAXM@Z")]
        public static extern void Indent(float indent_w = default);

        // imgui.h:363
        [DllImport(DLLNAME, EntryPoint="?Unindent@ImGui@@YAXM@Z")]
        public static extern void Unindent(float indent_w = default);

        // imgui.h:364
        [DllImport(DLLNAME, EntryPoint="?BeginGroup@ImGui@@YAXXZ")]
        public static extern void BeginGroup();

        // imgui.h:365
        [DllImport(DLLNAME, EntryPoint="?EndGroup@ImGui@@YAXXZ")]
        public static extern void EndGroup();

        // imgui.h:366
        [DllImport(DLLNAME, EntryPoint="?GetCursorPos@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetCursorPos();

        // imgui.h:367
        [DllImport(DLLNAME, EntryPoint="?GetCursorPosX@ImGui@@YAMXZ")]
        public static extern float GetCursorPosX();

        // imgui.h:368
        [DllImport(DLLNAME, EntryPoint="?GetCursorPosY@ImGui@@YAMXZ")]
        public static extern float GetCursorPosY();

        // imgui.h:369
        [DllImport(DLLNAME, EntryPoint="?SetCursorPos@ImGui@@YAXAEBUImVec2@@@Z")]
        public static extern void SetCursorPos(IntPtr local_pos = default);

        // imgui.h:370
        [DllImport(DLLNAME, EntryPoint="?SetCursorPosX@ImGui@@YAXM@Z")]
        public static extern void SetCursorPosX(float local_x = default);

        // imgui.h:371
        [DllImport(DLLNAME, EntryPoint="?SetCursorPosY@ImGui@@YAXM@Z")]
        public static extern void SetCursorPosY(float local_y = default);

        // imgui.h:372
        [DllImport(DLLNAME, EntryPoint="?GetCursorStartPos@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetCursorStartPos();

        // imgui.h:373
        [DllImport(DLLNAME, EntryPoint="?GetCursorScreenPos@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetCursorScreenPos();

        // imgui.h:374
        [DllImport(DLLNAME, EntryPoint="?SetCursorScreenPos@ImGui@@YAXAEBUImVec2@@@Z")]
        public static extern void SetCursorScreenPos(IntPtr pos = default);

        // imgui.h:375
        [DllImport(DLLNAME, EntryPoint="?AlignTextToFramePadding@ImGui@@YAXXZ")]
        public static extern void AlignTextToFramePadding();

        // imgui.h:376
        [DllImport(DLLNAME, EntryPoint="?GetTextLineHeight@ImGui@@YAMXZ")]
        public static extern float GetTextLineHeight();

        // imgui.h:377
        [DllImport(DLLNAME, EntryPoint="?GetTextLineHeightWithSpacing@ImGui@@YAMXZ")]
        public static extern float GetTextLineHeightWithSpacing();

        // imgui.h:378
        [DllImport(DLLNAME, EntryPoint="?GetFrameHeight@ImGui@@YAMXZ")]
        public static extern float GetFrameHeight();

        // imgui.h:379
        [DllImport(DLLNAME, EntryPoint="?GetFrameHeightWithSpacing@ImGui@@YAMXZ")]
        public static extern float GetFrameHeightWithSpacing();

        // imgui.h:388
        [DllImport(DLLNAME, EntryPoint="?PushID@ImGui@@YAXPEBD@Z")]
        public static extern void PushID([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default);

        // imgui.h:389
        [DllImport(DLLNAME, EntryPoint="?PushID@ImGui@@YAXPEBD0@Z")]
        public static extern void PushID([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id_begin = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string str_id_end = default);

        // imgui.h:390
        [DllImport(DLLNAME, EntryPoint="?PushID@ImGui@@YAXPEBX@Z")]
        public static extern void PushID(IntPtr ptr_id = default);

        // imgui.h:391
        [DllImport(DLLNAME, EntryPoint="?PushID@ImGui@@YAXH@Z")]
        public static extern void PushID(int int_id = default);

        // imgui.h:392
        [DllImport(DLLNAME, EntryPoint="?PopID@ImGui@@YAXXZ")]
        public static extern void PopID();

        // imgui.h:393
        [DllImport(DLLNAME, EntryPoint="?GetID@ImGui@@YAIPEBD@Z")]
        public static extern ImGuiID GetID([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default);

        // imgui.h:394
        [DllImport(DLLNAME, EntryPoint="?GetID@ImGui@@YAIPEBD0@Z")]
        public static extern ImGuiID GetID([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id_begin = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string str_id_end = default);

        // imgui.h:395
        [DllImport(DLLNAME, EntryPoint="?GetID@ImGui@@YAIPEBX@Z")]
        public static extern ImGuiID GetID(IntPtr ptr_id = default);

        // imgui.h:398
        [DllImport(DLLNAME, EntryPoint="?TextUnformatted@ImGui@@YAXPEBD0@Z")]
        public static extern void TextUnformatted([MarshalAs(UnmanagedType.LPUTF8Str)]string text = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string text_end = default);

        // imgui.h:399
        [DllImport(DLLNAME, EntryPoint="?Text@ImGui@@YAXPEBDZZ")]
        public static extern void Text([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:400
        [DllImport(DLLNAME, EntryPoint="?TextV@ImGui@@YAXPEBDH@Z")]
        public static extern void TextV([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:401
        [DllImport(DLLNAME, EntryPoint="?TextColored@ImGui@@YAXAEBUImVec4@@PEBDZZ")]
        public static extern void TextColored(IntPtr col = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:402
        [DllImport(DLLNAME, EntryPoint="?TextColoredV@ImGui@@YAXAEBUImVec4@@PEBDH@Z")]
        public static extern void TextColoredV(IntPtr col = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:403
        [DllImport(DLLNAME, EntryPoint="?TextDisabled@ImGui@@YAXPEBDZZ")]
        public static extern void TextDisabled([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:404
        [DllImport(DLLNAME, EntryPoint="?TextDisabledV@ImGui@@YAXPEBDH@Z")]
        public static extern void TextDisabledV([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:405
        [DllImport(DLLNAME, EntryPoint="?TextWrapped@ImGui@@YAXPEBDZZ")]
        public static extern void TextWrapped([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:406
        [DllImport(DLLNAME, EntryPoint="?TextWrappedV@ImGui@@YAXPEBDH@Z")]
        public static extern void TextWrappedV([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:407
        [DllImport(DLLNAME, EntryPoint="?LabelText@ImGui@@YAXPEBD0ZZ")]
        public static extern void LabelText([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:408
        [DllImport(DLLNAME, EntryPoint="?LabelTextV@ImGui@@YAXPEBD0H@Z")]
        public static extern void LabelTextV([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:409
        [DllImport(DLLNAME, EntryPoint="?BulletText@ImGui@@YAXPEBDZZ")]
        public static extern void BulletText([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:410
        [DllImport(DLLNAME, EntryPoint="?BulletTextV@ImGui@@YAXPEBDH@Z")]
        public static extern void BulletTextV([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:414
        [DllImport(DLLNAME, EntryPoint="?Button@ImGui@@YA_NPEBDAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Button([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr size = default);

        // imgui.h:415
        [DllImport(DLLNAME, EntryPoint="?SmallButton@ImGui@@YA_NPEBD@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SmallButton([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default);

        // imgui.h:416
        [DllImport(DLLNAME, EntryPoint="?InvisibleButton@ImGui@@YA_NPEBDAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InvisibleButton([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, IntPtr size = default);

        // imgui.h:417
        [DllImport(DLLNAME, EntryPoint="?ArrowButton@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ArrowButton([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, ImGuiDir dir = default);

        // imgui.h:418
        [DllImport(DLLNAME, EntryPoint="?Image@ImGui@@YAXPEAXAEBUImVec2@@11AEBUImVec4@@2@Z")]
        public static extern void Image(ImTextureID user_texture_id = default, IntPtr size = default, IntPtr uv0 = default, IntPtr uv1 = default, IntPtr tint_col = default, IntPtr border_col = default);

        // imgui.h:419
        [DllImport(DLLNAME, EntryPoint="?ImageButton@ImGui@@YA_NPEAXAEBUImVec2@@11HAEBUImVec4@@2@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ImageButton(ImTextureID user_texture_id = default, IntPtr size = default, IntPtr uv0 = default, IntPtr uv1 = default, int frame_padding = default, IntPtr bg_col = default, IntPtr tint_col = default);

        // imgui.h:420
        [DllImport(DLLNAME, EntryPoint="?Checkbox@ImGui@@YA_NPEBDPEA_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Checkbox([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]ref bool v);

        // imgui.h:420
        [DllImport(DLLNAME, EntryPoint="?Checkbox@ImGui@@YA_NPEBDPEA_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Checkbox([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]IntPtr v = default);

        // imgui.h:421
        [DllImport(DLLNAME, EntryPoint="?CheckboxFlags@ImGui@@YA_NPEBDPEAII@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool CheckboxFlags([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr flags = default, uint flags_value = default);

        // imgui.h:422
        [DllImport(DLLNAME, EntryPoint="?RadioButton@ImGui@@YA_NPEBD_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool RadioButton([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.U1)]bool active = default);

        // imgui.h:423
        [DllImport(DLLNAME, EntryPoint="?RadioButton@ImGui@@YA_NPEBDPEAHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool RadioButton([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int v_button = default);

        // imgui.h:424
        [DllImport(DLLNAME, EntryPoint="?ProgressBar@ImGui@@YAXMAEBUImVec2@@PEBD@Z")]
        public static extern void ProgressBar(float fraction = default, IntPtr size_arg = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string overlay = default);

        // imgui.h:425
        [DllImport(DLLNAME, EntryPoint="?Bullet@ImGui@@YAXXZ")]
        public static extern void Bullet();

        // imgui.h:430
        [DllImport(DLLNAME, EntryPoint="?BeginCombo@ImGui@@YA_NPEBD0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginCombo([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string preview_value = default, ImGuiComboFlags flags = default);

        // imgui.h:431
        [DllImport(DLLNAME, EntryPoint="?EndCombo@ImGui@@YAXXZ")]
        public static extern void EndCombo();

        // imgui.h:432
        [DllImport(DLLNAME, EntryPoint="?Combo@ImGui@@YA_NPEBDPEAHQEBQEBDHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Combo([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr current_item = default, IntPtr items = default, int items_count = default, int popup_max_height_in_items = default);

        // imgui.h:433
        [DllImport(DLLNAME, EntryPoint="?Combo@ImGui@@YA_NPEBDPEAH0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Combo([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr current_item = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string items_separated_by_zeros = default, int popup_max_height_in_items = default);

        // imgui.h:434
        [DllImport(DLLNAME, EntryPoint="?Combo@ImGui@@YA_NPEBDPEAHP6A_NPEAXHPEAPEBD@Z2HH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Combo([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr current_item = default, IntPtr items_getter = default, IntPtr data = default, int items_count = default, int popup_max_height_in_items = default);

        // imgui.h:443
        [DllImport(DLLNAME, EntryPoint="?DragFloat@ImGui@@YA_NPEBDPEAMMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragFloat([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v, float v_speed = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:444
        [DllImport(DLLNAME, EntryPoint="?DragFloat2@ImGui@@YA_NPEBDQEAMMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragFloat2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:445
        [DllImport(DLLNAME, EntryPoint="?DragFloat3@ImGui@@YA_NPEBDQEAMMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragFloat3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:446
        [DllImport(DLLNAME, EntryPoint="?DragFloat4@ImGui@@YA_NPEBDQEAMMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragFloat4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:447
        [DllImport(DLLNAME, EntryPoint="?DragFloatRange2@ImGui@@YA_NPEBDPEAM1MMM00M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragFloatRange2([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v_current_min, ref float v_current_max, float v_speed = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format_max = default, float power = default);

        // imgui.h:448
        [DllImport(DLLNAME, EntryPoint="?DragInt@ImGui@@YA_NPEBDPEAHMHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragInt([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:449
        [DllImport(DLLNAME, EntryPoint="?DragInt2@ImGui@@YA_NPEBDQEAHMHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragInt2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:450
        [DllImport(DLLNAME, EntryPoint="?DragInt3@ImGui@@YA_NPEBDQEAHMHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragInt3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:451
        [DllImport(DLLNAME, EntryPoint="?DragInt4@ImGui@@YA_NPEBDQEAHMHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragInt4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_speed = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:452
        [DllImport(DLLNAME, EntryPoint="?DragIntRange2@ImGui@@YA_NPEBDPEAH1MHH00@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragIntRange2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v_current_min = default, IntPtr v_current_max = default, float v_speed = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format_max = default);

        // imgui.h:453
        [DllImport(DLLNAME, EntryPoint="?DragScalar@ImGui@@YA_NPEBDHPEAXMPEBX20M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragScalar([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, float v_speed = default, IntPtr v_min = default, IntPtr v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:454
        [DllImport(DLLNAME, EntryPoint="?DragScalarN@ImGui@@YA_NPEBDHPEAXHMPEBX20M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool DragScalarN([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, int components = default, float v_speed = default, IntPtr v_min = default, IntPtr v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:459
        [DllImport(DLLNAME, EntryPoint="?SliderFloat@ImGui@@YA_NPEBDPEAMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderFloat([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:460
        [DllImport(DLLNAME, EntryPoint="?SliderFloat2@ImGui@@YA_NPEBDQEAMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderFloat2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:461
        [DllImport(DLLNAME, EntryPoint="?SliderFloat3@ImGui@@YA_NPEBDQEAMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderFloat3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:462
        [DllImport(DLLNAME, EntryPoint="?SliderFloat4@ImGui@@YA_NPEBDQEAMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderFloat4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:463
        [DllImport(DLLNAME, EntryPoint="?SliderAngle@ImGui@@YA_NPEBDPEAMMM0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderAngle([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v_rad, float v_degrees_min = default, float v_degrees_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:464
        [DllImport(DLLNAME, EntryPoint="?SliderInt@ImGui@@YA_NPEBDPEAHHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderInt([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:465
        [DllImport(DLLNAME, EntryPoint="?SliderInt2@ImGui@@YA_NPEBDQEAHHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderInt2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:466
        [DllImport(DLLNAME, EntryPoint="?SliderInt3@ImGui@@YA_NPEBDQEAHHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderInt3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:467
        [DllImport(DLLNAME, EntryPoint="?SliderInt4@ImGui@@YA_NPEBDQEAHHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderInt4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:468
        [DllImport(DLLNAME, EntryPoint="?SliderScalar@ImGui@@YA_NPEBDHPEAXPEBX20M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderScalar([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, IntPtr v_min = default, IntPtr v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:469
        [DllImport(DLLNAME, EntryPoint="?SliderScalarN@ImGui@@YA_NPEBDHPEAXHPEBX20M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SliderScalarN([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, int components = default, IntPtr v_min = default, IntPtr v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:470
        [DllImport(DLLNAME, EntryPoint="?VSliderFloat@ImGui@@YA_NPEBDAEBUImVec2@@PEAMMM0M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool VSliderFloat([MarshalAs(UnmanagedType.LPUTF8Str)]string label, IntPtr size, ref float v, float v_min = default, float v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:471
        [DllImport(DLLNAME, EntryPoint="?VSliderInt@ImGui@@YA_NPEBDAEBUImVec2@@PEAHHH0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool VSliderInt([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr size = default, IntPtr v = default, int v_min = default, int v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default);

        // imgui.h:472
        [DllImport(DLLNAME, EntryPoint="?VSliderScalar@ImGui@@YA_NPEBDAEBUImVec2@@HPEAXPEBX30M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool VSliderScalar([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr size = default, ImGuiDataType data_type = default, IntPtr v = default, IntPtr v_min = default, IntPtr v_max = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, float power = default);

        // imgui.h:477
        [DllImport(DLLNAME, EntryPoint="?InputText@ImGui@@YA_NPEBDPEAD_KHP6AHPEAUImGuiInputTextCallbackData@@@ZPEAX@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputText([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr buf = default, ulong buf_size = default, ImGuiInputTextFlags flags = default, IntPtr callback = default, IntPtr user_data = default);

        // imgui.h:478
        [DllImport(DLLNAME, EntryPoint="?InputTextMultiline@ImGui@@YA_NPEBDPEAD_KAEBUImVec2@@HP6AHPEAUImGuiInputTextCallbackData@@@ZPEAX@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputTextMultiline([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr buf = default, ulong buf_size = default, IntPtr size = default, ImGuiInputTextFlags flags = default, IntPtr callback = default, IntPtr user_data = default);

        // imgui.h:479
        [DllImport(DLLNAME, EntryPoint="?InputTextWithHint@ImGui@@YA_NPEBD0PEAD_KHP6AHPEAUImGuiInputTextCallbackData@@@ZPEAX@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputTextWithHint([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string hint = default, IntPtr buf = default, ulong buf_size = default, ImGuiInputTextFlags flags = default, IntPtr callback = default, IntPtr user_data = default);

        // imgui.h:480
        [DllImport(DLLNAME, EntryPoint="?InputFloat@ImGui@@YA_NPEBDPEAMMM0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v, float step = default, float step_fast = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:481
        [DllImport(DLLNAME, EntryPoint="?InputFloat2@ImGui@@YA_NPEBDQEAM0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:482
        [DllImport(DLLNAME, EntryPoint="?InputFloat3@ImGui@@YA_NPEBDQEAM0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:483
        [DllImport(DLLNAME, EntryPoint="?InputFloat4@ImGui@@YA_NPEBDQEAM0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:484
        [DllImport(DLLNAME, EntryPoint="?InputInt@ImGui@@YA_NPEBDPEAHHHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputInt([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int step = default, int step_fast = default, ImGuiInputTextFlags flags = default);

        // imgui.h:485
        [DllImport(DLLNAME, EntryPoint="?InputInt2@ImGui@@YA_NPEBDQEAHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputInt2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, ImGuiInputTextFlags flags = default);

        // imgui.h:486
        [DllImport(DLLNAME, EntryPoint="?InputInt3@ImGui@@YA_NPEBDQEAHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputInt3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, ImGuiInputTextFlags flags = default);

        // imgui.h:487
        [DllImport(DLLNAME, EntryPoint="?InputInt4@ImGui@@YA_NPEBDQEAHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputInt4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, ImGuiInputTextFlags flags = default);

        // imgui.h:488
        [DllImport(DLLNAME, EntryPoint="?InputDouble@ImGui@@YA_NPEBDPEANNN0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputDouble([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, double step = default, double step_fast = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:489
        [DllImport(DLLNAME, EntryPoint="?InputScalar@ImGui@@YA_NPEBDHPEAXPEBX20H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputScalar([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, IntPtr step = default, IntPtr step_fast = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:490
        [DllImport(DLLNAME, EntryPoint="?InputScalarN@ImGui@@YA_NPEBDHPEAXHPEBX20H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputScalarN([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiDataType data_type = default, IntPtr v = default, int components = default, IntPtr step = default, IntPtr step_fast = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string format = default, ImGuiInputTextFlags flags = default);

        // imgui.h:495
        [DllImport(DLLNAME, EntryPoint="?ColorEdit3@ImGui@@YA_NPEBDQEAMH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ColorEdit3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr col = default, ImGuiColorEditFlags flags = default);

        // imgui.h:496
        [DllImport(DLLNAME, EntryPoint="?ColorEdit4@ImGui@@YA_NPEBDQEAMH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ColorEdit4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr col = default, ImGuiColorEditFlags flags = default);

        // imgui.h:497
        [DllImport(DLLNAME, EntryPoint="?ColorPicker3@ImGui@@YA_NPEBDQEAMH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ColorPicker3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr col = default, ImGuiColorEditFlags flags = default);

        // imgui.h:498
        [DllImport(DLLNAME, EntryPoint="?ColorPicker4@ImGui@@YA_NPEBDQEAMHPEBM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ColorPicker4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr col = default, ImGuiColorEditFlags flags = default, IntPtr ref_col = default);

        // imgui.h:499
        [DllImport(DLLNAME, EntryPoint="?ColorButton@ImGui@@YA_NPEBDAEBUImVec4@@HUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ColorButton([MarshalAs(UnmanagedType.LPUTF8Str)]string desc_id = default, IntPtr col = default, ImGuiColorEditFlags flags = default, ImVec2 size = default);

        // imgui.h:500
        [DllImport(DLLNAME, EntryPoint="?SetColorEditOptions@ImGui@@YAXH@Z")]
        public static extern void SetColorEditOptions(ImGuiColorEditFlags flags = default);

        // imgui.h:504
        [DllImport(DLLNAME, EntryPoint="?TreeNode@ImGui@@YA_NPEBD@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNode([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default);

        // imgui.h:505
        [DllImport(DLLNAME, EntryPoint="?TreeNode@ImGui@@YA_NPEBD0ZZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNode([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:506
        [DllImport(DLLNAME, EntryPoint="?TreeNode@ImGui@@YA_NPEBXPEBDZZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNode(IntPtr ptr_id = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:507
        [DllImport(DLLNAME, EntryPoint="?TreeNodeV@ImGui@@YA_NPEBD0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeV([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:508
        [DllImport(DLLNAME, EntryPoint="?TreeNodeV@ImGui@@YA_NPEBXPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeV(IntPtr ptr_id = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:509
        [DllImport(DLLNAME, EntryPoint="?TreeNodeEx@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeEx([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiTreeNodeFlags flags = default);

        // imgui.h:510
        [DllImport(DLLNAME, EntryPoint="?TreeNodeEx@ImGui@@YA_NPEBDH0ZZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeEx([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, ImGuiTreeNodeFlags flags = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:511
        [DllImport(DLLNAME, EntryPoint="?TreeNodeEx@ImGui@@YA_NPEBXHPEBDZZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeEx(IntPtr ptr_id = default, ImGuiTreeNodeFlags flags = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:512
        [DllImport(DLLNAME, EntryPoint="?TreeNodeExV@ImGui@@YA_NPEBDH0H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeExV([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, ImGuiTreeNodeFlags flags = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:513
        [DllImport(DLLNAME, EntryPoint="?TreeNodeExV@ImGui@@YA_NPEBXHPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool TreeNodeExV(IntPtr ptr_id = default, ImGuiTreeNodeFlags flags = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:514
        [DllImport(DLLNAME, EntryPoint="?TreePush@ImGui@@YAXPEBD@Z")]
        public static extern void TreePush([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default);

        // imgui.h:515
        [DllImport(DLLNAME, EntryPoint="?TreePush@ImGui@@YAXPEBX@Z")]
        public static extern void TreePush(IntPtr ptr_id = default);

        // imgui.h:516
        [DllImport(DLLNAME, EntryPoint="?TreePop@ImGui@@YAXXZ")]
        public static extern void TreePop();

        // imgui.h:517
        [DllImport(DLLNAME, EntryPoint="?GetTreeNodeToLabelSpacing@ImGui@@YAMXZ")]
        public static extern float GetTreeNodeToLabelSpacing();

        // imgui.h:518
        [DllImport(DLLNAME, EntryPoint="?CollapsingHeader@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool CollapsingHeader([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, ImGuiTreeNodeFlags flags = default);

        // imgui.h:519
        [DllImport(DLLNAME, EntryPoint="?CollapsingHeader@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool CollapsingHeader([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiTreeNodeFlags flags = default);

        // imgui.h:519
        [DllImport(DLLNAME, EntryPoint="?CollapsingHeader@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool CollapsingHeader([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]IntPtr p_open = default, ImGuiTreeNodeFlags flags = default);

        // imgui.h:520
        [DllImport(DLLNAME, EntryPoint="?SetNextItemOpen@ImGui@@YAX_NH@Z")]
        public static extern void SetNextItemOpen([MarshalAs(UnmanagedType.U1)]bool is_open = default, ImGuiCond cond = default);

        // imgui.h:525
        [DllImport(DLLNAME, EntryPoint="?Selectable@ImGui@@YA_NPEBD_NHAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Selectable([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.U1)]bool selected = default, ImGuiSelectableFlags flags = default, IntPtr size = default);

        // imgui.h:526
        [DllImport(DLLNAME, EntryPoint="?Selectable@ImGui@@YA_NPEBDPEA_NHAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Selectable([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]ref bool p_selected, ImGuiSelectableFlags flags = default, IntPtr size = default);

        // imgui.h:526
        [DllImport(DLLNAME, EntryPoint="?Selectable@ImGui@@YA_NPEBDPEA_NHAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Selectable([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]IntPtr p_selected = default, ImGuiSelectableFlags flags = default, IntPtr size = default);

        // imgui.h:530
        [DllImport(DLLNAME, EntryPoint="?ListBox@ImGui@@YA_NPEBDPEAHQEBQEBDHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ListBox([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr current_item = default, IntPtr items = default, int items_count = default, int height_in_items = default);

        // imgui.h:531
        [DllImport(DLLNAME, EntryPoint="?ListBox@ImGui@@YA_NPEBDPEAHP6A_NPEAXHPEAPEBD@Z2HH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ListBox([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr current_item = default, IntPtr items_getter = default, IntPtr data = default, int items_count = default, int height_in_items = default);

        // imgui.h:532
        [DllImport(DLLNAME, EntryPoint="?ListBoxHeader@ImGui@@YA_NPEBDAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ListBoxHeader([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr size = default);

        // imgui.h:533
        [DllImport(DLLNAME, EntryPoint="?ListBoxHeader@ImGui@@YA_NPEBDHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ListBoxHeader([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, int items_count = default, int height_in_items = default);

        // imgui.h:534
        [DllImport(DLLNAME, EntryPoint="?ListBoxFooter@ImGui@@YAXXZ")]
        public static extern void ListBoxFooter();

        // imgui.h:537
        [DllImport(DLLNAME, EntryPoint="?PlotLines@ImGui@@YAXPEBDPEBMHH0MMUImVec2@@H@Z")]
        public static extern void PlotLines([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr values = default, int values_count = default, int values_offset = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string overlay_text = default, float scale_min = default, float scale_max = default, ImVec2 graph_size = default, int stride = default);

        // imgui.h:538
        [DllImport(DLLNAME, EntryPoint="?PlotLines@ImGui@@YAXPEBDP6AMPEAXH@Z1HH0MMUImVec2@@@Z")]
        public static extern void PlotLines([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr values_getter = default, IntPtr data = default, int values_count = default, int values_offset = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string overlay_text = default, float scale_min = default, float scale_max = default, ImVec2 graph_size = default);

        // imgui.h:539
        [DllImport(DLLNAME, EntryPoint="?PlotHistogram@ImGui@@YAXPEBDPEBMHH0MMUImVec2@@H@Z")]
        public static extern void PlotHistogram([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr values = default, int values_count = default, int values_offset = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string overlay_text = default, float scale_min = default, float scale_max = default, ImVec2 graph_size = default, int stride = default);

        // imgui.h:540
        [DllImport(DLLNAME, EntryPoint="?PlotHistogram@ImGui@@YAXPEBDP6AMPEAXH@Z1HH0MMUImVec2@@@Z")]
        public static extern void PlotHistogram([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr values_getter = default, IntPtr data = default, int values_count = default, int values_offset = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string overlay_text = default, float scale_min = default, float scale_max = default, ImVec2 graph_size = default);

        // imgui.h:544
        [DllImport(DLLNAME, EntryPoint="?Value@ImGui@@YAXPEBD_N@Z")]
        public static extern void Value([MarshalAs(UnmanagedType.LPUTF8Str)]string prefix = default, [MarshalAs(UnmanagedType.U1)]bool b = default);

        // imgui.h:545
        [DllImport(DLLNAME, EntryPoint="?Value@ImGui@@YAXPEBDH@Z")]
        public static extern void Value([MarshalAs(UnmanagedType.LPUTF8Str)]string prefix = default, int v = default);

        // imgui.h:546
        [DllImport(DLLNAME, EntryPoint="?Value@ImGui@@YAXPEBDI@Z")]
        public static extern void Value([MarshalAs(UnmanagedType.LPUTF8Str)]string prefix = default, uint v = default);

        // imgui.h:547
        [DllImport(DLLNAME, EntryPoint="?Value@ImGui@@YAXPEBDM0@Z")]
        public static extern void Value([MarshalAs(UnmanagedType.LPUTF8Str)]string prefix = default, float v = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string float_format = default);

        // imgui.h:550
        [DllImport(DLLNAME, EntryPoint="?BeginMainMenuBar@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginMainMenuBar();

        // imgui.h:551
        [DllImport(DLLNAME, EntryPoint="?EndMainMenuBar@ImGui@@YAXXZ")]
        public static extern void EndMainMenuBar();

        // imgui.h:552
        [DllImport(DLLNAME, EntryPoint="?BeginMenuBar@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginMenuBar();

        // imgui.h:553
        [DllImport(DLLNAME, EntryPoint="?EndMenuBar@ImGui@@YAXXZ")]
        public static extern void EndMenuBar();

        // imgui.h:554
        [DllImport(DLLNAME, EntryPoint="?BeginMenu@ImGui@@YA_NPEBD_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginMenu([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.U1)]bool enabled = default);

        // imgui.h:555
        [DllImport(DLLNAME, EntryPoint="?EndMenu@ImGui@@YAXXZ")]
        public static extern void EndMenu();

        // imgui.h:556
        [DllImport(DLLNAME, EntryPoint="?MenuItem@ImGui@@YA_NPEBD0_N1@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool MenuItem([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string shortcut = default, [MarshalAs(UnmanagedType.U1)]bool selected = default, [MarshalAs(UnmanagedType.U1)]bool enabled = default);

        // imgui.h:557
        [DllImport(DLLNAME, EntryPoint="?MenuItem@ImGui@@YA_NPEBD0PEA_N_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool MenuItem([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.LPUTF8Str)]string shortcut, [MarshalAs(UnmanagedType.U1)]ref bool p_selected, [MarshalAs(UnmanagedType.U1)]bool enabled = default);

        // imgui.h:557
        [DllImport(DLLNAME, EntryPoint="?MenuItem@ImGui@@YA_NPEBD0PEA_N_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool MenuItem([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.LPUTF8Str)]string shortcut, [MarshalAs(UnmanagedType.U1)]IntPtr p_selected = default, [MarshalAs(UnmanagedType.U1)]bool enabled = default);

        // imgui.h:560
        [DllImport(DLLNAME, EntryPoint="?BeginTooltip@ImGui@@YAXXZ")]
        public static extern void BeginTooltip();

        // imgui.h:561
        [DllImport(DLLNAME, EntryPoint="?EndTooltip@ImGui@@YAXXZ")]
        public static extern void EndTooltip();

        // imgui.h:562
        [DllImport(DLLNAME, EntryPoint="?SetTooltip@ImGui@@YAXPEBDZZ")]
        public static extern void SetTooltip([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:563
        [DllImport(DLLNAME, EntryPoint="?SetTooltipV@ImGui@@YAXPEBDH@Z")]
        public static extern void SetTooltipV([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default, int args = default);

        // imgui.h:573
        [DllImport(DLLNAME, EntryPoint="?OpenPopup@ImGui@@YAXPEBD@Z")]
        public static extern void OpenPopup([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default);

        // imgui.h:574
        [DllImport(DLLNAME, EntryPoint="?BeginPopup@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopup([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, ImGuiWindowFlags flags = default);

        // imgui.h:575
        [DllImport(DLLNAME, EntryPoint="?BeginPopupContextItem@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopupContextItem([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, int mouse_button = default);

        // imgui.h:576
        [DllImport(DLLNAME, EntryPoint="?BeginPopupContextWindow@ImGui@@YA_NPEBDH_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopupContextWindow([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, int mouse_button = default, [MarshalAs(UnmanagedType.U1)]bool also_over_items = default);

        // imgui.h:577
        [DllImport(DLLNAME, EntryPoint="?BeginPopupContextVoid@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopupContextVoid([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, int mouse_button = default);

        // imgui.h:578
        [DllImport(DLLNAME, EntryPoint="?BeginPopupModal@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopupModal([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiWindowFlags flags = default);

        // imgui.h:578
        [DllImport(DLLNAME, EntryPoint="?BeginPopupModal@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginPopupModal([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]IntPtr p_open = default, ImGuiWindowFlags flags = default);

        // imgui.h:579
        [DllImport(DLLNAME, EntryPoint="?EndPopup@ImGui@@YAXXZ")]
        public static extern void EndPopup();

        // imgui.h:580
        [DllImport(DLLNAME, EntryPoint="?OpenPopupOnItemClick@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool OpenPopupOnItemClick([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, int mouse_button = default);

        // imgui.h:581
        [DllImport(DLLNAME, EntryPoint="?IsPopupOpen@ImGui@@YA_NPEBD@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsPopupOpen([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default);

        // imgui.h:582
        [DllImport(DLLNAME, EntryPoint="?CloseCurrentPopup@ImGui@@YAXXZ")]
        public static extern void CloseCurrentPopup();

        // imgui.h:587
        [DllImport(DLLNAME, EntryPoint="?Columns@ImGui@@YAXHPEBD_N@Z")]
        public static extern void Columns(int count = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string id = default, [MarshalAs(UnmanagedType.U1)]bool border = default);

        // imgui.h:588
        [DllImport(DLLNAME, EntryPoint="?NextColumn@ImGui@@YAXXZ")]
        public static extern void NextColumn();

        // imgui.h:589
        [DllImport(DLLNAME, EntryPoint="?GetColumnIndex@ImGui@@YAHXZ")]
        public static extern int GetColumnIndex();

        // imgui.h:590
        [DllImport(DLLNAME, EntryPoint="?GetColumnWidth@ImGui@@YAMH@Z")]
        public static extern float GetColumnWidth(int column_index = default);

        // imgui.h:591
        [DllImport(DLLNAME, EntryPoint="?SetColumnWidth@ImGui@@YAXHM@Z")]
        public static extern void SetColumnWidth(int column_index = default, float width = default);

        // imgui.h:592
        [DllImport(DLLNAME, EntryPoint="?GetColumnOffset@ImGui@@YAMH@Z")]
        public static extern float GetColumnOffset(int column_index = default);

        // imgui.h:593
        [DllImport(DLLNAME, EntryPoint="?SetColumnOffset@ImGui@@YAXHM@Z")]
        public static extern void SetColumnOffset(int column_index = default, float offset_x = default);

        // imgui.h:594
        [DllImport(DLLNAME, EntryPoint="?GetColumnsCount@ImGui@@YAHXZ")]
        public static extern int GetColumnsCount();

        // imgui.h:599
        [DllImport(DLLNAME, EntryPoint="?BeginTabBar@ImGui@@YA_NPEBDH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginTabBar([MarshalAs(UnmanagedType.LPUTF8Str)]string str_id = default, ImGuiTabBarFlags flags = default);

        // imgui.h:600
        [DllImport(DLLNAME, EntryPoint="?EndTabBar@ImGui@@YAXXZ")]
        public static extern void EndTabBar();

        // imgui.h:601
        [DllImport(DLLNAME, EntryPoint="?BeginTabItem@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginTabItem([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiTabItemFlags flags = default);

        // imgui.h:601
        [DllImport(DLLNAME, EntryPoint="?BeginTabItem@ImGui@@YA_NPEBDPEA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginTabItem([MarshalAs(UnmanagedType.LPUTF8Str)]string label, [MarshalAs(UnmanagedType.U1)]IntPtr p_open = default, ImGuiTabItemFlags flags = default);

        // imgui.h:602
        [DllImport(DLLNAME, EntryPoint="?EndTabItem@ImGui@@YAXXZ")]
        public static extern void EndTabItem();

        // imgui.h:603
        [DllImport(DLLNAME, EntryPoint="?SetTabItemClosed@ImGui@@YAXPEBD@Z")]
        public static extern void SetTabItemClosed([MarshalAs(UnmanagedType.LPUTF8Str)]string tab_or_docked_window_label = default);

        // imgui.h:611
        [DllImport(DLLNAME, EntryPoint="?DockSpace@ImGui@@YAXIAEBUImVec2@@HPEBUImGuiWindowClass@@@Z")]
        public static extern void DockSpace(ImGuiID id = default, IntPtr size = default, ImGuiDockNodeFlags flags = default, IntPtr window_class = default);

        // imgui.h:612
        [DllImport(DLLNAME, EntryPoint="?DockSpaceOverViewport@ImGui@@YAIPEAUImGuiViewport@@HPEBUImGuiWindowClass@@@Z")]
        public static extern ImGuiID DockSpaceOverViewport(IntPtr viewport = default, ImGuiDockNodeFlags flags = default, IntPtr window_class = default);

        // imgui.h:613
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowDockID@ImGui@@YAXIH@Z")]
        public static extern void SetNextWindowDockID(ImGuiID dock_id = default, ImGuiCond cond = default);

        // imgui.h:614
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowClass@ImGui@@YAXPEBUImGuiWindowClass@@@Z")]
        public static extern void SetNextWindowClass(IntPtr window_class = default);

        // imgui.h:615
        [DllImport(DLLNAME, EntryPoint="?GetWindowDockID@ImGui@@YAIXZ")]
        public static extern ImGuiID GetWindowDockID();

        // imgui.h:616
        [DllImport(DLLNAME, EntryPoint="?IsWindowDocked@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsWindowDocked();

        // imgui.h:620
        [DllImport(DLLNAME, EntryPoint="?LogToTTY@ImGui@@YAXH@Z")]
        public static extern void LogToTTY(int auto_open_depth = default);

        // imgui.h:621
        [DllImport(DLLNAME, EntryPoint="?LogToFile@ImGui@@YAXHPEBD@Z")]
        public static extern void LogToFile(int auto_open_depth = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string filename = default);

        // imgui.h:622
        [DllImport(DLLNAME, EntryPoint="?LogToClipboard@ImGui@@YAXH@Z")]
        public static extern void LogToClipboard(int auto_open_depth = default);

        // imgui.h:623
        [DllImport(DLLNAME, EntryPoint="?LogFinish@ImGui@@YAXXZ")]
        public static extern void LogFinish();

        // imgui.h:624
        [DllImport(DLLNAME, EntryPoint="?LogButtons@ImGui@@YAXXZ")]
        public static extern void LogButtons();

        // imgui.h:625
        [DllImport(DLLNAME, EntryPoint="?LogText@ImGui@@YAXPEBDZZ")]
        public static extern void LogText([MarshalAs(UnmanagedType.LPUTF8Str)]string fmt = default);

        // imgui.h:629
        [DllImport(DLLNAME, EntryPoint="?BeginDragDropSource@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginDragDropSource(ImGuiDragDropFlags flags = default);

        // imgui.h:630
        [DllImport(DLLNAME, EntryPoint="?SetDragDropPayload@ImGui@@YA_NPEBDPEBX_KH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool SetDragDropPayload([MarshalAs(UnmanagedType.LPUTF8Str)]string type = default, IntPtr data = default, ulong sz = default, ImGuiCond cond = default);

        // imgui.h:631
        [DllImport(DLLNAME, EntryPoint="?EndDragDropSource@ImGui@@YAXXZ")]
        public static extern void EndDragDropSource();

        // imgui.h:632
        [DllImport(DLLNAME, EntryPoint="?BeginDragDropTarget@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginDragDropTarget();

        // imgui.h:633
        [DllImport(DLLNAME, EntryPoint="?AcceptDragDropPayload@ImGui@@YAPEBUImGuiPayload@@PEBDH@Z")]
        public static extern IntPtr AcceptDragDropPayload([MarshalAs(UnmanagedType.LPUTF8Str)]string type = default, ImGuiDragDropFlags flags = default);

        // imgui.h:634
        [DllImport(DLLNAME, EntryPoint="?EndDragDropTarget@ImGui@@YAXXZ")]
        public static extern void EndDragDropTarget();

        // imgui.h:635
        [DllImport(DLLNAME, EntryPoint="?GetDragDropPayload@ImGui@@YAPEBUImGuiPayload@@XZ")]
        public static extern IntPtr GetDragDropPayload();

        // imgui.h:638
        [DllImport(DLLNAME, EntryPoint="?PushClipRect@ImGui@@YAXAEBUImVec2@@0_N@Z")]
        public static extern void PushClipRect(IntPtr clip_rect_min = default, IntPtr clip_rect_max = default, [MarshalAs(UnmanagedType.U1)]bool intersect_with_current_clip_rect = default);

        // imgui.h:639
        [DllImport(DLLNAME, EntryPoint="?PopClipRect@ImGui@@YAXXZ")]
        public static extern void PopClipRect();

        // imgui.h:643
        [DllImport(DLLNAME, EntryPoint="?SetItemDefaultFocus@ImGui@@YAXXZ")]
        public static extern void SetItemDefaultFocus();

        // imgui.h:644
        [DllImport(DLLNAME, EntryPoint="?SetKeyboardFocusHere@ImGui@@YAXH@Z")]
        public static extern void SetKeyboardFocusHere(int offset = default);

        // imgui.h:649
        [DllImport(DLLNAME, EntryPoint="?IsItemHovered@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemHovered(ImGuiHoveredFlags flags = default);

        // imgui.h:650
        [DllImport(DLLNAME, EntryPoint="?IsItemActive@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemActive();

        // imgui.h:651
        [DllImport(DLLNAME, EntryPoint="?IsItemFocused@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemFocused();

        // imgui.h:652
        [DllImport(DLLNAME, EntryPoint="?IsItemClicked@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemClicked(int mouse_button = default);

        // imgui.h:653
        [DllImport(DLLNAME, EntryPoint="?IsItemVisible@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemVisible();

        // imgui.h:654
        [DllImport(DLLNAME, EntryPoint="?IsItemEdited@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemEdited();

        // imgui.h:655
        [DllImport(DLLNAME, EntryPoint="?IsItemActivated@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemActivated();

        // imgui.h:656
        [DllImport(DLLNAME, EntryPoint="?IsItemDeactivated@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemDeactivated();

        // imgui.h:657
        [DllImport(DLLNAME, EntryPoint="?IsItemDeactivatedAfterEdit@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemDeactivatedAfterEdit();

        // imgui.h:658
        [DllImport(DLLNAME, EntryPoint="?IsAnyItemHovered@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyItemHovered();

        // imgui.h:659
        [DllImport(DLLNAME, EntryPoint="?IsAnyItemActive@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyItemActive();

        // imgui.h:660
        [DllImport(DLLNAME, EntryPoint="?IsAnyItemFocused@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyItemFocused();

        // imgui.h:661
        [DllImport(DLLNAME, EntryPoint="?GetItemRectMin@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetItemRectMin();

        // imgui.h:662
        [DllImport(DLLNAME, EntryPoint="?GetItemRectMax@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetItemRectMax();

        // imgui.h:663
        [DllImport(DLLNAME, EntryPoint="?GetItemRectSize@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetItemRectSize();

        // imgui.h:664
        [DllImport(DLLNAME, EntryPoint="?SetItemAllowOverlap@ImGui@@YAXXZ")]
        public static extern void SetItemAllowOverlap();

        // imgui.h:667
        [DllImport(DLLNAME, EntryPoint="?IsRectVisible@ImGui@@YA_NAEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsRectVisible(IntPtr size = default);

        // imgui.h:668
        [DllImport(DLLNAME, EntryPoint="?IsRectVisible@ImGui@@YA_NAEBUImVec2@@0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsRectVisible(IntPtr rect_min = default, IntPtr rect_max = default);

        // imgui.h:669
        [DllImport(DLLNAME, EntryPoint="?GetTime@ImGui@@YANXZ")]
        public static extern double GetTime();

        // imgui.h:670
        [DllImport(DLLNAME, EntryPoint="?GetFrameCount@ImGui@@YAHXZ")]
        public static extern int GetFrameCount();

        // imgui.h:671
        [DllImport(DLLNAME, EntryPoint="?GetBackgroundDrawList@ImGui@@YAPEAUImDrawList@@XZ")]
        public static extern IntPtr GetBackgroundDrawList();

        // imgui.h:672
        [DllImport(DLLNAME, EntryPoint="?GetForegroundDrawList@ImGui@@YAPEAUImDrawList@@XZ")]
        public static extern IntPtr GetForegroundDrawList();

        // imgui.h:673
        [DllImport(DLLNAME, EntryPoint="?GetBackgroundDrawList@ImGui@@YAPEAUImDrawList@@PEAUImGuiViewport@@@Z")]
        public static extern IntPtr GetBackgroundDrawList(IntPtr viewport = default);

        // imgui.h:674
        [DllImport(DLLNAME, EntryPoint="?GetForegroundDrawList@ImGui@@YAPEAUImDrawList@@PEAUImGuiViewport@@@Z")]
        public static extern IntPtr GetForegroundDrawList(IntPtr viewport = default);

        // imgui.h:675
        [DllImport(DLLNAME, EntryPoint="?GetDrawListSharedData@ImGui@@YAPEAUImDrawListSharedData@@XZ")]
        public static extern IntPtr GetDrawListSharedData();

        // imgui.h:676
        [DllImport(DLLNAME, EntryPoint="?GetStyleColorName@ImGui@@YAPEBDH@Z")]
        public static extern IntPtr GetStyleColorName(ImGuiCol idx = default);

        // imgui.h:677
        [DllImport(DLLNAME, EntryPoint="?SetStateStorage@ImGui@@YAXPEAUImGuiStorage@@@Z")]
        public static extern void SetStateStorage(IntPtr storage = default);

        // imgui.h:678
        [DllImport(DLLNAME, EntryPoint="?GetStateStorage@ImGui@@YAPEAUImGuiStorage@@XZ")]
        public static extern IntPtr GetStateStorage();

        // imgui.h:679
        [DllImport(DLLNAME, EntryPoint="?CalcTextSize@ImGui@@YA?AUImVec2@@PEBD0_NM@Z")]
        public static extern ImVec2 CalcTextSize([MarshalAs(UnmanagedType.LPUTF8Str)]string text = default, [MarshalAs(UnmanagedType.LPUTF8Str)]string text_end = default, [MarshalAs(UnmanagedType.U1)]bool hide_text_after_double_hash = default, float wrap_width = default);

        // imgui.h:680
        [DllImport(DLLNAME, EntryPoint="?CalcListClipping@ImGui@@YAXHMPEAH0@Z")]
        public static extern void CalcListClipping(int items_count = default, float items_height = default, IntPtr out_items_display_start = default, IntPtr out_items_display_end = default);

        // imgui.h:681
        [DllImport(DLLNAME, EntryPoint="?BeginChildFrame@ImGui@@YA_NIAEBUImVec2@@H@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool BeginChildFrame(ImGuiID id = default, IntPtr size = default, ImGuiWindowFlags flags = default);

        // imgui.h:682
        [DllImport(DLLNAME, EntryPoint="?EndChildFrame@ImGui@@YAXXZ")]
        public static extern void EndChildFrame();

        // imgui.h:685
        [DllImport(DLLNAME, EntryPoint="?ColorConvertU32ToFloat4@ImGui@@YA?AUImVec4@@I@Z")]
        public static extern ImVec4 ColorConvertU32ToFloat4(uint _in = default);

        // imgui.h:686
        [DllImport(DLLNAME, EntryPoint="?ColorConvertFloat4ToU32@ImGui@@YAIAEBUImVec4@@@Z")]
        public static extern uint ColorConvertFloat4ToU32(IntPtr _in = default);

        // imgui.h:687
        [DllImport(DLLNAME, EntryPoint="?ColorConvertRGBtoHSV@ImGui@@YAXMMMAEAM00@Z")]
        public static extern void ColorConvertRGBtoHSV(float r, float g, float b, ref float out_h, ref float out_s, ref float out_v);

        // imgui.h:688
        [DllImport(DLLNAME, EntryPoint="?ColorConvertHSVtoRGB@ImGui@@YAXMMMAEAM00@Z")]
        public static extern void ColorConvertHSVtoRGB(float h, float s, float v, ref float out_r, ref float out_g, ref float out_b);

        // imgui.h:691
        [DllImport(DLLNAME, EntryPoint="?GetKeyIndex@ImGui@@YAHH@Z")]
        public static extern int GetKeyIndex(ImGuiKey imgui_key = default);

        // imgui.h:692
        [DllImport(DLLNAME, EntryPoint="?IsKeyDown@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsKeyDown(int user_key_index = default);

        // imgui.h:693
        [DllImport(DLLNAME, EntryPoint="?IsKeyPressed@ImGui@@YA_NH_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsKeyPressed(int user_key_index = default, [MarshalAs(UnmanagedType.U1)]bool repeat = default);

        // imgui.h:694
        [DllImport(DLLNAME, EntryPoint="?IsKeyReleased@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsKeyReleased(int user_key_index = default);

        // imgui.h:695
        [DllImport(DLLNAME, EntryPoint="?GetKeyPressedAmount@ImGui@@YAHHMM@Z")]
        public static extern int GetKeyPressedAmount(int key_index = default, float repeat_delay = default, float rate = default);

        // imgui.h:696
        [DllImport(DLLNAME, EntryPoint="?IsMouseDown@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseDown(int button = default);

        // imgui.h:697
        [DllImport(DLLNAME, EntryPoint="?IsAnyMouseDown@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyMouseDown();

        // imgui.h:698
        [DllImport(DLLNAME, EntryPoint="?IsMouseClicked@ImGui@@YA_NH_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseClicked(int button = default, [MarshalAs(UnmanagedType.U1)]bool repeat = default);

        // imgui.h:699
        [DllImport(DLLNAME, EntryPoint="?IsMouseDoubleClicked@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseDoubleClicked(int button = default);

        // imgui.h:700
        [DllImport(DLLNAME, EntryPoint="?IsMouseReleased@ImGui@@YA_NH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseReleased(int button = default);

        // imgui.h:701
        [DllImport(DLLNAME, EntryPoint="?IsMouseDragging@ImGui@@YA_NHM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseDragging(int button = default, float lock_threshold = default);

        // imgui.h:702
        [DllImport(DLLNAME, EntryPoint="?IsMouseHoveringRect@ImGui@@YA_NAEBUImVec2@@0_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMouseHoveringRect(IntPtr r_min = default, IntPtr r_max = default, [MarshalAs(UnmanagedType.U1)]bool clip = default);

        // imgui.h:703
        [DllImport(DLLNAME, EntryPoint="?IsMousePosValid@ImGui@@YA_NPEBUImVec2@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsMousePosValid(IntPtr mouse_pos = default);

        // imgui.h:704
        [DllImport(DLLNAME, EntryPoint="?GetMousePos@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetMousePos();

        // imgui.h:705
        [DllImport(DLLNAME, EntryPoint="?GetMousePosOnOpeningCurrentPopup@ImGui@@YA?AUImVec2@@XZ")]
        public static extern ImVec2 GetMousePosOnOpeningCurrentPopup();

        // imgui.h:706
        [DllImport(DLLNAME, EntryPoint="?GetMouseDragDelta@ImGui@@YA?AUImVec2@@HM@Z")]
        public static extern ImVec2 GetMouseDragDelta(int button = default, float lock_threshold = default);

        // imgui.h:707
        [DllImport(DLLNAME, EntryPoint="?ResetMouseDragDelta@ImGui@@YAXH@Z")]
        public static extern void ResetMouseDragDelta(int button = default);

        // imgui.h:708
        [DllImport(DLLNAME, EntryPoint="?GetMouseCursor@ImGui@@YAHXZ")]
        public static extern ImGuiMouseCursor GetMouseCursor();

        // imgui.h:709
        [DllImport(DLLNAME, EntryPoint="?SetMouseCursor@ImGui@@YAXH@Z")]
        public static extern void SetMouseCursor(ImGuiMouseCursor type = default);

        // imgui.h:710
        [DllImport(DLLNAME, EntryPoint="?CaptureKeyboardFromApp@ImGui@@YAX_N@Z")]
        public static extern void CaptureKeyboardFromApp([MarshalAs(UnmanagedType.U1)]bool want_capture_keyboard_value = default);

        // imgui.h:711
        [DllImport(DLLNAME, EntryPoint="?CaptureMouseFromApp@ImGui@@YAX_N@Z")]
        public static extern void CaptureMouseFromApp([MarshalAs(UnmanagedType.U1)]bool want_capture_mouse_value = default);

        // imgui.h:714
        [DllImport(DLLNAME, EntryPoint="?GetClipboardText@ImGui@@YAPEBDXZ")]
        public static extern IntPtr GetClipboardText();

        // imgui.h:715
        [DllImport(DLLNAME, EntryPoint="?SetClipboardText@ImGui@@YAXPEBD@Z")]
        public static extern void SetClipboardText([MarshalAs(UnmanagedType.LPUTF8Str)]string text = default);

        // imgui.h:720
        [DllImport(DLLNAME, EntryPoint="?LoadIniSettingsFromDisk@ImGui@@YAXPEBD@Z")]
        public static extern void LoadIniSettingsFromDisk([MarshalAs(UnmanagedType.LPUTF8Str)]string ini_filename = default);

        // imgui.h:721
        [DllImport(DLLNAME, EntryPoint="?LoadIniSettingsFromMemory@ImGui@@YAXPEBD_K@Z")]
        public static extern void LoadIniSettingsFromMemory([MarshalAs(UnmanagedType.LPUTF8Str)]string ini_data = default, ulong ini_size = default);

        // imgui.h:722
        [DllImport(DLLNAME, EntryPoint="?SaveIniSettingsToDisk@ImGui@@YAXPEBD@Z")]
        public static extern void SaveIniSettingsToDisk([MarshalAs(UnmanagedType.LPUTF8Str)]string ini_filename = default);

        // imgui.h:723
        [DllImport(DLLNAME, EntryPoint="?SaveIniSettingsToMemory@ImGui@@YAPEBDPEA_K@Z")]
        public static extern IntPtr SaveIniSettingsToMemory(IntPtr out_ini_size = default);

        // imgui.h:728
        [DllImport(DLLNAME, EntryPoint="?SetAllocatorFunctions@ImGui@@YAXP6APEAX_KPEAX@ZP6AX11@Z1@Z")]
        public static extern void SetAllocatorFunctions(IntPtr alloc_func = default, IntPtr free_func = default, IntPtr user_data = default);

        // imgui.h:729
        [DllImport(DLLNAME, EntryPoint="?MemAlloc@ImGui@@YAPEAX_K@Z")]
        public static extern IntPtr MemAlloc(ulong size = default);

        // imgui.h:730
        [DllImport(DLLNAME, EntryPoint="?MemFree@ImGui@@YAXPEAX@Z")]
        public static extern void MemFree(IntPtr ptr = default);

        // imgui.h:734
        [DllImport(DLLNAME, EntryPoint="?GetPlatformIO@ImGui@@YAAEAUImGuiPlatformIO@@XZ")]
        public static extern IntPtr GetPlatformIO();

        // imgui.h:735
        [DllImport(DLLNAME, EntryPoint="?GetMainViewport@ImGui@@YAPEAUImGuiViewport@@XZ")]
        public static extern IntPtr GetMainViewport();

        // imgui.h:736
        [DllImport(DLLNAME, EntryPoint="?UpdatePlatformWindows@ImGui@@YAXXZ")]
        public static extern void UpdatePlatformWindows();

        // imgui.h:737
        [DllImport(DLLNAME, EntryPoint="?RenderPlatformWindowsDefault@ImGui@@YAXPEAX0@Z")]
        public static extern void RenderPlatformWindowsDefault(IntPtr platform_arg = default, IntPtr renderer_arg = default);

        // imgui.h:738
        [DllImport(DLLNAME, EntryPoint="?DestroyPlatformWindows@ImGui@@YAXXZ")]
        public static extern void DestroyPlatformWindows();

        // imgui.h:739
        [DllImport(DLLNAME, EntryPoint="?FindViewportByID@ImGui@@YAPEAUImGuiViewport@@I@Z")]
        public static extern IntPtr FindViewportByID(ImGuiID id = default);

        // imgui.h:740
        [DllImport(DLLNAME, EntryPoint="?FindViewportByPlatformHandle@ImGui@@YAPEAUImGuiViewport@@PEAX@Z")]
        public static extern IntPtr FindViewportByPlatformHandle(IntPtr platform_handle = default);

        // imgui.h:1637
        [DllImport(DLLNAME, EntryPoint="?TreeAdvanceToLabelPos@ImGui@@YAXXZ")]
        public static extern void TreeAdvanceToLabelPos();

        // imgui.h:1639
        [DllImport(DLLNAME, EntryPoint="?SetNextTreeNodeOpen@ImGui@@YAX_NH@Z")]
        public static extern void SetNextTreeNodeOpen([MarshalAs(UnmanagedType.U1)]bool open = default, ImGuiCond cond = default);

        // imgui.h:1641
        [DllImport(DLLNAME, EntryPoint="?GetContentRegionAvailWidth@ImGui@@YAMXZ")]
        public static extern float GetContentRegionAvailWidth();

        // imgui.h:1643
        [DllImport(DLLNAME, EntryPoint="?GetOverlayDrawList@ImGui@@YAPEAUImDrawList@@XZ")]
        public static extern IntPtr GetOverlayDrawList();

        // imgui.h:1645
        [DllImport(DLLNAME, EntryPoint="?SetScrollHere@ImGui@@YAXM@Z")]
        public static extern void SetScrollHere(float center_ratio = default);

        // imgui.h:1647
        [DllImport(DLLNAME, EntryPoint="?IsItemDeactivatedAfterChange@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsItemDeactivatedAfterChange();

        // imgui.h:1649
        [DllImport(DLLNAME, EntryPoint="?InputFloat@ImGui@@YA_NPEBDPEAMMMHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat([MarshalAs(UnmanagedType.LPUTF8Str)]string label, ref float v, float step = default, float step_fast = default, int decimal_precision = default, ImGuiInputTextFlags flags = default);

        // imgui.h:1650
        [DllImport(DLLNAME, EntryPoint="?InputFloat2@ImGui@@YA_NPEBDQEAMHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat2([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int decimal_precision = default, ImGuiInputTextFlags flags = default);

        // imgui.h:1651
        [DllImport(DLLNAME, EntryPoint="?InputFloat3@ImGui@@YA_NPEBDQEAMHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat3([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int decimal_precision = default, ImGuiInputTextFlags flags = default);

        // imgui.h:1652
        [DllImport(DLLNAME, EntryPoint="?InputFloat4@ImGui@@YA_NPEBDQEAMHH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool InputFloat4([MarshalAs(UnmanagedType.LPUTF8Str)]string label = default, IntPtr v = default, int decimal_precision = default, ImGuiInputTextFlags flags = default);

        // imgui.h:1654
        [DllImport(DLLNAME, EntryPoint="?IsAnyWindowFocused@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyWindowFocused();

        // imgui.h:1655
        [DllImport(DLLNAME, EntryPoint="?IsAnyWindowHovered@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsAnyWindowHovered();

        // imgui.h:1656
        [DllImport(DLLNAME, EntryPoint="?CalcItemRectClosestPoint@ImGui@@YA?AUImVec2@@AEBU2@_NM@Z")]
        public static extern ImVec2 CalcItemRectClosestPoint(IntPtr pos = default, [MarshalAs(UnmanagedType.U1)]bool on_edge = default, float outward = default);

        // imgui.h:1658
        [DllImport(DLLNAME, EntryPoint="?ShowTestWindow@ImGui@@YAXXZ")]
        public static extern void ShowTestWindow();

        // imgui.h:1659
        [DllImport(DLLNAME, EntryPoint="?IsRootWindowFocused@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsRootWindowFocused();

        // imgui.h:1660
        [DllImport(DLLNAME, EntryPoint="?IsRootWindowOrAnyChildFocused@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsRootWindowOrAnyChildFocused();

        // imgui.h:1661
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowContentWidth@ImGui@@YAXM@Z")]
        public static extern void SetNextWindowContentWidth(float w = default);

        // imgui.h:1662
        [DllImport(DLLNAME, EntryPoint="?GetItemsLineHeightWithSpacing@ImGui@@YAMXZ")]
        public static extern float GetItemsLineHeightWithSpacing();

        // imgui.h:1664
        [DllImport(DLLNAME, EntryPoint="?Begin@ImGui@@YA_NPEBDPEA_NAEBUImVec2@@MH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Begin([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, IntPtr size_on_first_use = default, float bg_alpha_override = default, ImGuiWindowFlags flags = default);

        // imgui.h:1664
        [DllImport(DLLNAME, EntryPoint="?Begin@ImGui@@YA_NPEBDPEA_NAEBUImVec2@@MH@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Begin([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]IntPtr p_open = default, IntPtr size_on_first_use = default, float bg_alpha_override = default, ImGuiWindowFlags flags = default);

        // imgui.h:1665
        [DllImport(DLLNAME, EntryPoint="?IsRootWindowOrAnyChildHovered@ImGui@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsRootWindowOrAnyChildHovered();

        // imgui.h:1666
        [DllImport(DLLNAME, EntryPoint="?AlignFirstTextHeightToWidgets@ImGui@@YAXXZ")]
        public static extern void AlignFirstTextHeightToWidgets();

        // imgui.h:1667
        [DllImport(DLLNAME, EntryPoint="?SetNextWindowPosCenter@ImGui@@YAXH@Z")]
        public static extern void SetNextWindowPosCenter(ImGuiCond cond = default);
    }
}