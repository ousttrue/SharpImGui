// generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    public static class CImGui
    {
        const string DLLNAME = "cimgui.dll";

        // cimgui.h:892
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple ImVec2ToSimple(ImVec2 vec);

        // cimgui.h:899
        [DllImport(DLLNAME)]
        public static extern ImVec4_Simple ImVec4ToSimple(ImVec4 vec);

        // cimgui.h:908
        [DllImport(DLLNAME)]
        public static extern ImColor_Simple ImColorToSimple(ImColor col);

        // cimgui.h:937
        [DllImport(DLLNAME)]
        public static extern IntPtr ImVec2_ImVec2();

        // cimgui.h:938
        [DllImport(DLLNAME)]
        public static extern void ImVec2_destroy(IntPtr self);

        // cimgui.h:939
        [DllImport(DLLNAME)]
        public static extern IntPtr ImVec2_ImVec2Float(float _x, float _y);

        // cimgui.h:940
        [DllImport(DLLNAME)]
        public static extern IntPtr ImVec4_ImVec4();

        // cimgui.h:941
        [DllImport(DLLNAME)]
        public static extern void ImVec4_destroy(IntPtr self);

        // cimgui.h:942
        [DllImport(DLLNAME)]
        public static extern IntPtr ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);

        // cimgui.h:943
        [DllImport(DLLNAME)]
        public static extern IntPtr igCreateContext(IntPtr shared_font_atlas);

        // cimgui.h:944
        [DllImport(DLLNAME)]
        public static extern void igDestroyContext(IntPtr ctx);

        // cimgui.h:945
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetCurrentContext();

        // cimgui.h:946
        [DllImport(DLLNAME)]
        public static extern void igSetCurrentContext(IntPtr ctx);

        // cimgui.h:947
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDebugCheckVersionAndDataLayout(IntPtr version_str, ulong sz_io, ulong sz_style, ulong sz_vec2, ulong sz_vec4, ulong sz_drawvert, ulong sz_drawidx);

        // cimgui.h:948
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetIO();

        // cimgui.h:949
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetStyle();

        // cimgui.h:950
        [DllImport(DLLNAME)]
        public static extern void igNewFrame();

        // cimgui.h:951
        [DllImport(DLLNAME)]
        public static extern void igEndFrame();

        // cimgui.h:952
        [DllImport(DLLNAME)]
        public static extern void igRender();

        // cimgui.h:953
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetDrawData();

        // cimgui.h:954
        [DllImport(DLLNAME)]
        public static extern void igShowDemoWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // cimgui.h:955
        [DllImport(DLLNAME)]
        public static extern void igShowAboutWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // cimgui.h:956
        [DllImport(DLLNAME)]
        public static extern void igShowMetricsWindow([MarshalAs(UnmanagedType.U1)]ref bool p_open);

        // cimgui.h:957
        [DllImport(DLLNAME)]
        public static extern void igShowStyleEditor(IntPtr _ref);

        // cimgui.h:958
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igShowStyleSelector(IntPtr label);

        // cimgui.h:959
        [DllImport(DLLNAME)]
        public static extern void igShowFontSelector(IntPtr label);

        // cimgui.h:960
        [DllImport(DLLNAME)]
        public static extern void igShowUserGuide();

        // cimgui.h:961
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetVersion();

        // cimgui.h:962
        [DllImport(DLLNAME)]
        public static extern void igStyleColorsDark(IntPtr dst);

        // cimgui.h:963
        [DllImport(DLLNAME)]
        public static extern void igStyleColorsClassic(IntPtr dst);

        // cimgui.h:964
        [DllImport(DLLNAME)]
        public static extern void igStyleColorsLight(IntPtr dst);

        // cimgui.h:965
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBegin(IntPtr name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiWindowFlags flags);

        // cimgui.h:966
        [DllImport(DLLNAME)]
        public static extern void igEnd();

        // cimgui.h:967
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginChild(IntPtr str_id, ImVec2 size, [MarshalAs(UnmanagedType.U1)]bool border, ImGuiWindowFlags flags);

        // cimgui.h:968
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginChildID(ImGuiID id, ImVec2 size, [MarshalAs(UnmanagedType.U1)]bool border, ImGuiWindowFlags flags);

        // cimgui.h:969
        [DllImport(DLLNAME)]
        public static extern void igEndChild();

        // cimgui.h:970
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsWindowAppearing();

        // cimgui.h:971
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsWindowCollapsed();

        // cimgui.h:972
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsWindowFocused(ImGuiFocusedFlags flags);

        // cimgui.h:973
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsWindowHovered(ImGuiHoveredFlags flags);

        // cimgui.h:974
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetWindowDrawList();

        // cimgui.h:975
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetWindowPos();

        // cimgui.h:976
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetWindowSize();

        // cimgui.h:977
        [DllImport(DLLNAME)]
        public static extern float igGetWindowWidth();

        // cimgui.h:978
        [DllImport(DLLNAME)]
        public static extern float igGetWindowHeight();

        // cimgui.h:979
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowPos(ImVec2 pos, ImGuiCond cond, ImVec2 pivot);

        // cimgui.h:980
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowSize(ImVec2 size, ImGuiCond cond);

        // cimgui.h:981
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowSizeConstraints(ImVec2 size_min, ImVec2 size_max, IntPtr custom_callback, IntPtr custom_callback_data);

        // cimgui.h:982
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowContentSize(ImVec2 size);

        // cimgui.h:983
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowCollapsed([MarshalAs(UnmanagedType.U1)]bool collapsed, ImGuiCond cond);

        // cimgui.h:984
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowFocus();

        // cimgui.h:985
        [DllImport(DLLNAME)]
        public static extern void igSetNextWindowBgAlpha(float alpha);

        // cimgui.h:986
        [DllImport(DLLNAME)]
        public static extern void igSetWindowPosVec2(ImVec2 pos, ImGuiCond cond);

        // cimgui.h:987
        [DllImport(DLLNAME)]
        public static extern void igSetWindowSizeVec2(ImVec2 size, ImGuiCond cond);

        // cimgui.h:988
        [DllImport(DLLNAME)]
        public static extern void igSetWindowCollapsedBool([MarshalAs(UnmanagedType.U1)]bool collapsed, ImGuiCond cond);

        // cimgui.h:989
        [DllImport(DLLNAME)]
        public static extern void igSetWindowFocus();

        // cimgui.h:990
        [DllImport(DLLNAME)]
        public static extern void igSetWindowFontScale(float scale);

        // cimgui.h:991
        [DllImport(DLLNAME)]
        public static extern void igSetWindowPosStr(IntPtr name, ImVec2 pos, ImGuiCond cond);

        // cimgui.h:992
        [DllImport(DLLNAME)]
        public static extern void igSetWindowSizeStr(IntPtr name, ImVec2 size, ImGuiCond cond);

        // cimgui.h:993
        [DllImport(DLLNAME)]
        public static extern void igSetWindowCollapsedStr(IntPtr name, [MarshalAs(UnmanagedType.U1)]bool collapsed, ImGuiCond cond);

        // cimgui.h:994
        [DllImport(DLLNAME)]
        public static extern void igSetWindowFocusStr(IntPtr name);

        // cimgui.h:995
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetContentRegionMax();

        // cimgui.h:996
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetContentRegionAvail();

        // cimgui.h:997
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetWindowContentRegionMin();

        // cimgui.h:998
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetWindowContentRegionMax();

        // cimgui.h:999
        [DllImport(DLLNAME)]
        public static extern float igGetWindowContentRegionWidth();

        // cimgui.h:1000
        [DllImport(DLLNAME)]
        public static extern float igGetScrollX();

        // cimgui.h:1001
        [DllImport(DLLNAME)]
        public static extern float igGetScrollY();

        // cimgui.h:1002
        [DllImport(DLLNAME)]
        public static extern float igGetScrollMaxX();

        // cimgui.h:1003
        [DllImport(DLLNAME)]
        public static extern float igGetScrollMaxY();

        // cimgui.h:1004
        [DllImport(DLLNAME)]
        public static extern void igSetScrollX(float scroll_x);

        // cimgui.h:1005
        [DllImport(DLLNAME)]
        public static extern void igSetScrollY(float scroll_y);

        // cimgui.h:1006
        [DllImport(DLLNAME)]
        public static extern void igSetScrollHereX(float center_x_ratio);

        // cimgui.h:1007
        [DllImport(DLLNAME)]
        public static extern void igSetScrollHereY(float center_y_ratio);

        // cimgui.h:1008
        [DllImport(DLLNAME)]
        public static extern void igSetScrollFromPosX(float local_x, float center_x_ratio);

        // cimgui.h:1009
        [DllImport(DLLNAME)]
        public static extern void igSetScrollFromPosY(float local_y, float center_y_ratio);

        // cimgui.h:1010
        [DllImport(DLLNAME)]
        public static extern void igPushFont(IntPtr font);

        // cimgui.h:1011
        [DllImport(DLLNAME)]
        public static extern void igPopFont();

        // cimgui.h:1012
        [DllImport(DLLNAME)]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);

        // cimgui.h:1013
        [DllImport(DLLNAME)]
        public static extern void igPushStyleColor(ImGuiCol idx, ImVec4 col);

        // cimgui.h:1014
        [DllImport(DLLNAME)]
        public static extern void igPopStyleColor(int count);

        // cimgui.h:1015
        [DllImport(DLLNAME)]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);

        // cimgui.h:1016
        [DllImport(DLLNAME)]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, ImVec2 val);

        // cimgui.h:1017
        [DllImport(DLLNAME)]
        public static extern void igPopStyleVar(int count);

        // cimgui.h:1018
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetStyleColorVec4(ImGuiCol idx);

        // cimgui.h:1019
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetFont();

        // cimgui.h:1020
        [DllImport(DLLNAME)]
        public static extern float igGetFontSize();

        // cimgui.h:1021
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetFontTexUvWhitePixel();

        // cimgui.h:1022
        [DllImport(DLLNAME)]
        public static extern uint igGetColorU32(ImGuiCol idx, float alpha_mul);

        // cimgui.h:1023
        [DllImport(DLLNAME)]
        public static extern uint igGetColorU32Vec4(ImVec4 col);

        // cimgui.h:1024
        [DllImport(DLLNAME)]
        public static extern uint igGetColorU32U32(uint col);

        // cimgui.h:1025
        [DllImport(DLLNAME)]
        public static extern void igPushItemWidth(float item_width);

        // cimgui.h:1026
        [DllImport(DLLNAME)]
        public static extern void igPopItemWidth();

        // cimgui.h:1027
        [DllImport(DLLNAME)]
        public static extern void igSetNextItemWidth(float item_width);

        // cimgui.h:1028
        [DllImport(DLLNAME)]
        public static extern float igCalcItemWidth();

        // cimgui.h:1029
        [DllImport(DLLNAME)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);

        // cimgui.h:1030
        [DllImport(DLLNAME)]
        public static extern void igPopTextWrapPos();

        // cimgui.h:1031
        [DllImport(DLLNAME)]
        public static extern void igPushAllowKeyboardFocus([MarshalAs(UnmanagedType.U1)]bool allow_keyboard_focus);

        // cimgui.h:1032
        [DllImport(DLLNAME)]
        public static extern void igPopAllowKeyboardFocus();

        // cimgui.h:1033
        [DllImport(DLLNAME)]
        public static extern void igPushButtonRepeat([MarshalAs(UnmanagedType.U1)]bool repeat);

        // cimgui.h:1034
        [DllImport(DLLNAME)]
        public static extern void igPopButtonRepeat();

        // cimgui.h:1035
        [DllImport(DLLNAME)]
        public static extern void igSeparator();

        // cimgui.h:1036
        [DllImport(DLLNAME)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);

        // cimgui.h:1037
        [DllImport(DLLNAME)]
        public static extern void igNewLine();

        // cimgui.h:1038
        [DllImport(DLLNAME)]
        public static extern void igSpacing();

        // cimgui.h:1039
        [DllImport(DLLNAME)]
        public static extern void igDummy(ImVec2 size);

        // cimgui.h:1040
        [DllImport(DLLNAME)]
        public static extern void igIndent(float indent_w);

        // cimgui.h:1041
        [DllImport(DLLNAME)]
        public static extern void igUnindent(float indent_w);

        // cimgui.h:1042
        [DllImport(DLLNAME)]
        public static extern void igBeginGroup();

        // cimgui.h:1043
        [DllImport(DLLNAME)]
        public static extern void igEndGroup();

        // cimgui.h:1044
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetCursorPos();

        // cimgui.h:1045
        [DllImport(DLLNAME)]
        public static extern float igGetCursorPosX();

        // cimgui.h:1046
        [DllImport(DLLNAME)]
        public static extern float igGetCursorPosY();

        // cimgui.h:1047
        [DllImport(DLLNAME)]
        public static extern void igSetCursorPos(ImVec2 local_pos);

        // cimgui.h:1048
        [DllImport(DLLNAME)]
        public static extern void igSetCursorPosX(float local_x);

        // cimgui.h:1049
        [DllImport(DLLNAME)]
        public static extern void igSetCursorPosY(float local_y);

        // cimgui.h:1050
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetCursorStartPos();

        // cimgui.h:1051
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetCursorScreenPos();

        // cimgui.h:1052
        [DllImport(DLLNAME)]
        public static extern void igSetCursorScreenPos(ImVec2 pos);

        // cimgui.h:1053
        [DllImport(DLLNAME)]
        public static extern void igAlignTextToFramePadding();

        // cimgui.h:1054
        [DllImport(DLLNAME)]
        public static extern float igGetTextLineHeight();

        // cimgui.h:1055
        [DllImport(DLLNAME)]
        public static extern float igGetTextLineHeightWithSpacing();

        // cimgui.h:1056
        [DllImport(DLLNAME)]
        public static extern float igGetFrameHeight();

        // cimgui.h:1057
        [DllImport(DLLNAME)]
        public static extern float igGetFrameHeightWithSpacing();

        // cimgui.h:1058
        [DllImport(DLLNAME)]
        public static extern void igPushIDStr(IntPtr str_id);

        // cimgui.h:1059
        [DllImport(DLLNAME)]
        public static extern void igPushIDRange(IntPtr str_id_begin, IntPtr str_id_end);

        // cimgui.h:1060
        [DllImport(DLLNAME)]
        public static extern void igPushIDPtr(IntPtr ptr_id);

        // cimgui.h:1061
        [DllImport(DLLNAME)]
        public static extern void igPushIDInt(int int_id);

        // cimgui.h:1062
        [DllImport(DLLNAME)]
        public static extern void igPopID();

        // cimgui.h:1063
        [DllImport(DLLNAME)]
        public static extern ImGuiID igGetIDStr(IntPtr str_id);

        // cimgui.h:1064
        [DllImport(DLLNAME)]
        public static extern ImGuiID igGetIDRange(IntPtr str_id_begin, IntPtr str_id_end);

        // cimgui.h:1065
        [DllImport(DLLNAME)]
        public static extern ImGuiID igGetIDPtr(IntPtr ptr_id);

        // cimgui.h:1066
        [DllImport(DLLNAME)]
        public static extern void igTextUnformatted(IntPtr text, IntPtr text_end);

        // cimgui.h:1067
        [DllImport(DLLNAME)]
        public static extern void igText(IntPtr fmt);

        // cimgui.h:1068
        [DllImport(DLLNAME)]
        public static extern void igTextV(IntPtr fmt, int args);

        // cimgui.h:1069
        [DllImport(DLLNAME)]
        public static extern void igTextColored(ImVec4 col, IntPtr fmt);

        // cimgui.h:1070
        [DllImport(DLLNAME)]
        public static extern void igTextColoredV(ImVec4 col, IntPtr fmt, int args);

        // cimgui.h:1071
        [DllImport(DLLNAME)]
        public static extern void igTextDisabled(IntPtr fmt);

        // cimgui.h:1072
        [DllImport(DLLNAME)]
        public static extern void igTextDisabledV(IntPtr fmt, int args);

        // cimgui.h:1073
        [DllImport(DLLNAME)]
        public static extern void igTextWrapped(IntPtr fmt);

        // cimgui.h:1074
        [DllImport(DLLNAME)]
        public static extern void igTextWrappedV(IntPtr fmt, int args);

        // cimgui.h:1075
        [DllImport(DLLNAME)]
        public static extern void igLabelText(IntPtr label, IntPtr fmt);

        // cimgui.h:1076
        [DllImport(DLLNAME)]
        public static extern void igLabelTextV(IntPtr label, IntPtr fmt, int args);

        // cimgui.h:1077
        [DllImport(DLLNAME)]
        public static extern void igBulletText(IntPtr fmt);

        // cimgui.h:1078
        [DllImport(DLLNAME)]
        public static extern void igBulletTextV(IntPtr fmt, int args);

        // cimgui.h:1079
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igButton(IntPtr label, ImVec2 size);

        // cimgui.h:1080
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSmallButton(IntPtr label);

        // cimgui.h:1081
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInvisibleButton(IntPtr str_id, ImVec2 size);

        // cimgui.h:1082
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igArrowButton(IntPtr str_id, ImGuiDir dir);

        // cimgui.h:1083
        [DllImport(DLLNAME)]
        public static extern void igImage(ImTextureID user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, ImVec4 tint_col, ImVec4 border_col);

        // cimgui.h:1084
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igImageButton(ImTextureID user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, int frame_padding, ImVec4 bg_col, ImVec4 tint_col);

        // cimgui.h:1085
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igCheckbox(IntPtr label, [MarshalAs(UnmanagedType.U1)]ref bool v);

        // cimgui.h:1086
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igCheckboxFlags(IntPtr label, IntPtr flags, uint flags_value);

        // cimgui.h:1087
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igRadioButtonBool(IntPtr label, [MarshalAs(UnmanagedType.U1)]bool active);

        // cimgui.h:1088
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igRadioButtonIntPtr(IntPtr label, IntPtr v, int v_button);

        // cimgui.h:1089
        [DllImport(DLLNAME)]
        public static extern void igProgressBar(float fraction, ImVec2 size_arg, IntPtr overlay);

        // cimgui.h:1090
        [DllImport(DLLNAME)]
        public static extern void igBullet();

        // cimgui.h:1091
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginCombo(IntPtr label, IntPtr preview_value, ImGuiComboFlags flags);

        // cimgui.h:1092
        [DllImport(DLLNAME)]
        public static extern void igEndCombo();

        // cimgui.h:1093
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igCombo(IntPtr label, IntPtr current_item, IntPtr items, int items_count, int popup_max_height_in_items);

        // cimgui.h:1094
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igComboStr(IntPtr label, IntPtr current_item, IntPtr items_separated_by_zeros, int popup_max_height_in_items);

        // cimgui.h:1095
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igComboFnPtr(IntPtr label, IntPtr current_item, IntPtr items_getter, IntPtr data, int items_count, int popup_max_height_in_items);

        // cimgui.h:1096
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragFloat(IntPtr label, IntPtr v, float v_speed, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1097
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragFloat2(IntPtr label, IntPtr v, float v_speed, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1098
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragFloat3(IntPtr label, IntPtr v, float v_speed, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1099
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragFloat4(IntPtr label, IntPtr v, float v_speed, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1100
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragFloatRange2(IntPtr label, IntPtr v_current_min, IntPtr v_current_max, float v_speed, float v_min, float v_max, IntPtr format, IntPtr format_max, float power);

        // cimgui.h:1101
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragInt(IntPtr label, IntPtr v, float v_speed, int v_min, int v_max, IntPtr format);

        // cimgui.h:1102
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragInt2(IntPtr label, IntPtr v, float v_speed, int v_min, int v_max, IntPtr format);

        // cimgui.h:1103
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragInt3(IntPtr label, IntPtr v, float v_speed, int v_min, int v_max, IntPtr format);

        // cimgui.h:1104
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragInt4(IntPtr label, IntPtr v, float v_speed, int v_min, int v_max, IntPtr format);

        // cimgui.h:1105
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragIntRange2(IntPtr label, IntPtr v_current_min, IntPtr v_current_max, float v_speed, int v_min, int v_max, IntPtr format, IntPtr format_max);

        // cimgui.h:1106
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragScalar(IntPtr label, ImGuiDataType data_type, IntPtr v, float v_speed, IntPtr v_min, IntPtr v_max, IntPtr format, float power);

        // cimgui.h:1107
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igDragScalarN(IntPtr label, ImGuiDataType data_type, IntPtr v, int components, float v_speed, IntPtr v_min, IntPtr v_max, IntPtr format, float power);

        // cimgui.h:1108
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderFloat(IntPtr label, IntPtr v, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1109
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderFloat2(IntPtr label, IntPtr v, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1110
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderFloat3(IntPtr label, IntPtr v, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1111
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderFloat4(IntPtr label, IntPtr v, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1112
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderAngle(IntPtr label, IntPtr v_rad, float v_degrees_min, float v_degrees_max, IntPtr format);

        // cimgui.h:1113
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderInt(IntPtr label, IntPtr v, int v_min, int v_max, IntPtr format);

        // cimgui.h:1114
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderInt2(IntPtr label, IntPtr v, int v_min, int v_max, IntPtr format);

        // cimgui.h:1115
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderInt3(IntPtr label, IntPtr v, int v_min, int v_max, IntPtr format);

        // cimgui.h:1116
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderInt4(IntPtr label, IntPtr v, int v_min, int v_max, IntPtr format);

        // cimgui.h:1117
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderScalar(IntPtr label, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, IntPtr format, float power);

        // cimgui.h:1118
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSliderScalarN(IntPtr label, ImGuiDataType data_type, IntPtr v, int components, IntPtr v_min, IntPtr v_max, IntPtr format, float power);

        // cimgui.h:1119
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igVSliderFloat(IntPtr label, ImVec2 size, IntPtr v, float v_min, float v_max, IntPtr format, float power);

        // cimgui.h:1120
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igVSliderInt(IntPtr label, ImVec2 size, IntPtr v, int v_min, int v_max, IntPtr format);

        // cimgui.h:1121
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igVSliderScalar(IntPtr label, ImVec2 size, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, IntPtr format, float power);

        // cimgui.h:1122
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputText(IntPtr label, IntPtr buf, ulong buf_size, ImGuiInputTextFlags flags, IntPtr callback, IntPtr user_data);

        // cimgui.h:1123
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputTextMultiline(IntPtr label, IntPtr buf, ulong buf_size, ImVec2 size, ImGuiInputTextFlags flags, IntPtr callback, IntPtr user_data);

        // cimgui.h:1124
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputTextWithHint(IntPtr label, IntPtr hint, IntPtr buf, ulong buf_size, ImGuiInputTextFlags flags, IntPtr callback, IntPtr user_data);

        // cimgui.h:1125
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputFloat(IntPtr label, IntPtr v, float step, float step_fast, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1126
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputFloat2(IntPtr label, IntPtr v, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1127
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputFloat3(IntPtr label, IntPtr v, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1128
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputFloat4(IntPtr label, IntPtr v, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1129
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputInt(IntPtr label, IntPtr v, int step, int step_fast, ImGuiInputTextFlags flags);

        // cimgui.h:1130
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputInt2(IntPtr label, IntPtr v, ImGuiInputTextFlags flags);

        // cimgui.h:1131
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputInt3(IntPtr label, IntPtr v, ImGuiInputTextFlags flags);

        // cimgui.h:1132
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputInt4(IntPtr label, IntPtr v, ImGuiInputTextFlags flags);

        // cimgui.h:1133
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputDouble(IntPtr label, IntPtr v, double step, double step_fast, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1134
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputScalar(IntPtr label, ImGuiDataType data_type, IntPtr v, IntPtr step, IntPtr step_fast, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1135
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igInputScalarN(IntPtr label, ImGuiDataType data_type, IntPtr v, int components, IntPtr step, IntPtr step_fast, IntPtr format, ImGuiInputTextFlags flags);

        // cimgui.h:1136
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igColorEdit3(IntPtr label, IntPtr col, ImGuiColorEditFlags flags);

        // cimgui.h:1137
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igColorEdit4(IntPtr label, IntPtr col, ImGuiColorEditFlags flags);

        // cimgui.h:1138
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igColorPicker3(IntPtr label, IntPtr col, ImGuiColorEditFlags flags);

        // cimgui.h:1139
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igColorPicker4(IntPtr label, IntPtr col, ImGuiColorEditFlags flags, IntPtr ref_col);

        // cimgui.h:1140
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igColorButton(IntPtr desc_id, ImVec4 col, ImGuiColorEditFlags flags, ImVec2 size);

        // cimgui.h:1141
        [DllImport(DLLNAME)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);

        // cimgui.h:1142
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeStr(IntPtr label);

        // cimgui.h:1143
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeStrStr(IntPtr str_id, IntPtr fmt);

        // cimgui.h:1144
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodePtr(IntPtr ptr_id, IntPtr fmt);

        // cimgui.h:1145
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeVStr(IntPtr str_id, IntPtr fmt, int args);

        // cimgui.h:1146
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeVPtr(IntPtr ptr_id, IntPtr fmt, int args);

        // cimgui.h:1147
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeExStr(IntPtr label, ImGuiTreeNodeFlags flags);

        // cimgui.h:1148
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeExStrStr(IntPtr str_id, ImGuiTreeNodeFlags flags, IntPtr fmt);

        // cimgui.h:1149
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeExPtr(IntPtr ptr_id, ImGuiTreeNodeFlags flags, IntPtr fmt);

        // cimgui.h:1150
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeExVStr(IntPtr str_id, ImGuiTreeNodeFlags flags, IntPtr fmt, int args);

        // cimgui.h:1151
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igTreeNodeExVPtr(IntPtr ptr_id, ImGuiTreeNodeFlags flags, IntPtr fmt, int args);

        // cimgui.h:1152
        [DllImport(DLLNAME)]
        public static extern void igTreePushStr(IntPtr str_id);

        // cimgui.h:1153
        [DllImport(DLLNAME)]
        public static extern void igTreePushPtr(IntPtr ptr_id);

        // cimgui.h:1154
        [DllImport(DLLNAME)]
        public static extern void igTreePop();

        // cimgui.h:1155
        [DllImport(DLLNAME)]
        public static extern float igGetTreeNodeToLabelSpacing();

        // cimgui.h:1156
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igCollapsingHeader(IntPtr label, ImGuiTreeNodeFlags flags);

        // cimgui.h:1157
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igCollapsingHeaderBoolPtr(IntPtr label, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiTreeNodeFlags flags);

        // cimgui.h:1158
        [DllImport(DLLNAME)]
        public static extern void igSetNextItemOpen([MarshalAs(UnmanagedType.U1)]bool is_open, ImGuiCond cond);

        // cimgui.h:1159
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSelectable(IntPtr label, [MarshalAs(UnmanagedType.U1)]bool selected, ImGuiSelectableFlags flags, ImVec2 size);

        // cimgui.h:1160
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSelectableBoolPtr(IntPtr label, [MarshalAs(UnmanagedType.U1)]ref bool p_selected, ImGuiSelectableFlags flags, ImVec2 size);

        // cimgui.h:1161
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igListBoxStr_arr(IntPtr label, IntPtr current_item, IntPtr items, int items_count, int height_in_items);

        // cimgui.h:1162
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igListBoxFnPtr(IntPtr label, IntPtr current_item, IntPtr items_getter, IntPtr data, int items_count, int height_in_items);

        // cimgui.h:1163
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igListBoxHeaderVec2(IntPtr label, ImVec2 size);

        // cimgui.h:1164
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igListBoxHeaderInt(IntPtr label, int items_count, int height_in_items);

        // cimgui.h:1165
        [DllImport(DLLNAME)]
        public static extern void igListBoxFooter();

        // cimgui.h:1166
        [DllImport(DLLNAME)]
        public static extern void igPlotLines(IntPtr label, IntPtr values, int values_count, int values_offset, IntPtr overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        // cimgui.h:1167
        [DllImport(DLLNAME)]
        public static extern void igPlotLinesFnPtr(IntPtr label, IntPtr values_getter, IntPtr data, int values_count, int values_offset, IntPtr overlay_text, float scale_min, float scale_max, ImVec2 graph_size);

        // cimgui.h:1168
        [DllImport(DLLNAME)]
        public static extern void igPlotHistogramFloatPtr(IntPtr label, IntPtr values, int values_count, int values_offset, IntPtr overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        // cimgui.h:1169
        [DllImport(DLLNAME)]
        public static extern void igPlotHistogramFnPtr(IntPtr label, IntPtr values_getter, IntPtr data, int values_count, int values_offset, IntPtr overlay_text, float scale_min, float scale_max, ImVec2 graph_size);

        // cimgui.h:1170
        [DllImport(DLLNAME)]
        public static extern void igValueBool(IntPtr prefix, [MarshalAs(UnmanagedType.U1)]bool b);

        // cimgui.h:1171
        [DllImport(DLLNAME)]
        public static extern void igValueInt(IntPtr prefix, int v);

        // cimgui.h:1172
        [DllImport(DLLNAME)]
        public static extern void igValueUint(IntPtr prefix, uint v);

        // cimgui.h:1173
        [DllImport(DLLNAME)]
        public static extern void igValueFloat(IntPtr prefix, float v, IntPtr float_format);

        // cimgui.h:1174
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginMainMenuBar();

        // cimgui.h:1175
        [DllImport(DLLNAME)]
        public static extern void igEndMainMenuBar();

        // cimgui.h:1176
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginMenuBar();

        // cimgui.h:1177
        [DllImport(DLLNAME)]
        public static extern void igEndMenuBar();

        // cimgui.h:1178
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginMenu(IntPtr label, [MarshalAs(UnmanagedType.U1)]bool enabled);

        // cimgui.h:1179
        [DllImport(DLLNAME)]
        public static extern void igEndMenu();

        // cimgui.h:1180
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igMenuItemBool(IntPtr label, IntPtr shortcut, [MarshalAs(UnmanagedType.U1)]bool selected, [MarshalAs(UnmanagedType.U1)]bool enabled);

        // cimgui.h:1181
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igMenuItemBoolPtr(IntPtr label, IntPtr shortcut, [MarshalAs(UnmanagedType.U1)]ref bool p_selected, [MarshalAs(UnmanagedType.U1)]bool enabled);

        // cimgui.h:1182
        [DllImport(DLLNAME)]
        public static extern void igBeginTooltip();

        // cimgui.h:1183
        [DllImport(DLLNAME)]
        public static extern void igEndTooltip();

        // cimgui.h:1184
        [DllImport(DLLNAME)]
        public static extern void igSetTooltip(IntPtr fmt);

        // cimgui.h:1185
        [DllImport(DLLNAME)]
        public static extern void igSetTooltipV(IntPtr fmt, int args);

        // cimgui.h:1186
        [DllImport(DLLNAME)]
        public static extern void igOpenPopup(IntPtr str_id);

        // cimgui.h:1187
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginPopup(IntPtr str_id, ImGuiWindowFlags flags);

        // cimgui.h:1188
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginPopupContextItem(IntPtr str_id, int mouse_button);

        // cimgui.h:1189
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginPopupContextWindow(IntPtr str_id, int mouse_button, [MarshalAs(UnmanagedType.U1)]bool also_over_items);

        // cimgui.h:1190
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginPopupContextVoid(IntPtr str_id, int mouse_button);

        // cimgui.h:1191
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginPopupModal(IntPtr name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiWindowFlags flags);

        // cimgui.h:1192
        [DllImport(DLLNAME)]
        public static extern void igEndPopup();

        // cimgui.h:1193
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igOpenPopupOnItemClick(IntPtr str_id, int mouse_button);

        // cimgui.h:1194
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsPopupOpen(IntPtr str_id);

        // cimgui.h:1195
        [DllImport(DLLNAME)]
        public static extern void igCloseCurrentPopup();

        // cimgui.h:1196
        [DllImport(DLLNAME)]
        public static extern void igColumns(int count, IntPtr id, [MarshalAs(UnmanagedType.U1)]bool border);

        // cimgui.h:1197
        [DllImport(DLLNAME)]
        public static extern void igNextColumn();

        // cimgui.h:1198
        [DllImport(DLLNAME)]
        public static extern int igGetColumnIndex();

        // cimgui.h:1199
        [DllImport(DLLNAME)]
        public static extern float igGetColumnWidth(int column_index);

        // cimgui.h:1200
        [DllImport(DLLNAME)]
        public static extern void igSetColumnWidth(int column_index, float width);

        // cimgui.h:1201
        [DllImport(DLLNAME)]
        public static extern float igGetColumnOffset(int column_index);

        // cimgui.h:1202
        [DllImport(DLLNAME)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);

        // cimgui.h:1203
        [DllImport(DLLNAME)]
        public static extern int igGetColumnsCount();

        // cimgui.h:1204
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginTabBar(IntPtr str_id, ImGuiTabBarFlags flags);

        // cimgui.h:1205
        [DllImport(DLLNAME)]
        public static extern void igEndTabBar();

        // cimgui.h:1206
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginTabItem(IntPtr label, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiTabItemFlags flags);

        // cimgui.h:1207
        [DllImport(DLLNAME)]
        public static extern void igEndTabItem();

        // cimgui.h:1208
        [DllImport(DLLNAME)]
        public static extern void igSetTabItemClosed(IntPtr tab_or_docked_window_label);

        // cimgui.h:1209
        [DllImport(DLLNAME)]
        public static extern void igLogToTTY(int auto_open_depth);

        // cimgui.h:1210
        [DllImport(DLLNAME)]
        public static extern void igLogToFile(int auto_open_depth, IntPtr filename);

        // cimgui.h:1211
        [DllImport(DLLNAME)]
        public static extern void igLogToClipboard(int auto_open_depth);

        // cimgui.h:1212
        [DllImport(DLLNAME)]
        public static extern void igLogFinish();

        // cimgui.h:1213
        [DllImport(DLLNAME)]
        public static extern void igLogButtons();

        // cimgui.h:1214
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginDragDropSource(ImGuiDragDropFlags flags);

        // cimgui.h:1215
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igSetDragDropPayload(IntPtr type, IntPtr data, ulong sz, ImGuiCond cond);

        // cimgui.h:1216
        [DllImport(DLLNAME)]
        public static extern void igEndDragDropSource();

        // cimgui.h:1217
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginDragDropTarget();

        // cimgui.h:1218
        [DllImport(DLLNAME)]
        public static extern IntPtr igAcceptDragDropPayload(IntPtr type, ImGuiDragDropFlags flags);

        // cimgui.h:1219
        [DllImport(DLLNAME)]
        public static extern void igEndDragDropTarget();

        // cimgui.h:1220
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetDragDropPayload();

        // cimgui.h:1221
        [DllImport(DLLNAME)]
        public static extern void igPushClipRect(ImVec2 clip_rect_min, ImVec2 clip_rect_max, [MarshalAs(UnmanagedType.U1)]bool intersect_with_current_clip_rect);

        // cimgui.h:1222
        [DllImport(DLLNAME)]
        public static extern void igPopClipRect();

        // cimgui.h:1223
        [DllImport(DLLNAME)]
        public static extern void igSetItemDefaultFocus();

        // cimgui.h:1224
        [DllImport(DLLNAME)]
        public static extern void igSetKeyboardFocusHere(int offset);

        // cimgui.h:1225
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemHovered(ImGuiHoveredFlags flags);

        // cimgui.h:1226
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemActive();

        // cimgui.h:1227
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemFocused();

        // cimgui.h:1228
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemClicked(int mouse_button);

        // cimgui.h:1229
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemVisible();

        // cimgui.h:1230
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemEdited();

        // cimgui.h:1231
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemActivated();

        // cimgui.h:1232
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemDeactivated();

        // cimgui.h:1233
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsItemDeactivatedAfterEdit();

        // cimgui.h:1234
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsAnyItemHovered();

        // cimgui.h:1235
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsAnyItemActive();

        // cimgui.h:1236
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsAnyItemFocused();

        // cimgui.h:1237
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetItemRectMin();

        // cimgui.h:1238
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetItemRectMax();

        // cimgui.h:1239
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetItemRectSize();

        // cimgui.h:1240
        [DllImport(DLLNAME)]
        public static extern void igSetItemAllowOverlap();

        // cimgui.h:1241
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsRectVisible(ImVec2 size);

        // cimgui.h:1242
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsRectVisibleVec2(ImVec2 rect_min, ImVec2 rect_max);

        // cimgui.h:1243
        [DllImport(DLLNAME)]
        public static extern double igGetTime();

        // cimgui.h:1244
        [DllImport(DLLNAME)]
        public static extern int igGetFrameCount();

        // cimgui.h:1245
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetBackgroundDrawList();

        // cimgui.h:1246
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetForegroundDrawList();

        // cimgui.h:1247
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetDrawListSharedData();

        // cimgui.h:1248
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetStyleColorName(ImGuiCol idx);

        // cimgui.h:1249
        [DllImport(DLLNAME)]
        public static extern void igSetStateStorage(IntPtr storage);

        // cimgui.h:1250
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetStateStorage();

        // cimgui.h:1251
        [DllImport(DLLNAME)]
        public static extern ImVec2 igCalcTextSize(IntPtr text, IntPtr text_end, [MarshalAs(UnmanagedType.U1)]bool hide_text_after_double_hash, float wrap_width);

        // cimgui.h:1252
        [DllImport(DLLNAME)]
        public static extern void igCalcListClipping(int items_count, float items_height, IntPtr out_items_display_start, IntPtr out_items_display_end);

        // cimgui.h:1253
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igBeginChildFrame(ImGuiID id, ImVec2 size, ImGuiWindowFlags flags);

        // cimgui.h:1254
        [DllImport(DLLNAME)]
        public static extern void igEndChildFrame();

        // cimgui.h:1255
        [DllImport(DLLNAME)]
        public static extern ImVec4 igColorConvertU32ToFloat4(uint _in);

        // cimgui.h:1256
        [DllImport(DLLNAME)]
        public static extern uint igColorConvertFloat4ToU32(ImVec4 _in);

        // cimgui.h:1257
        [DllImport(DLLNAME)]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);

        // cimgui.h:1258
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsKeyDown(int user_key_index);

        // cimgui.h:1259
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsKeyPressed(int user_key_index, [MarshalAs(UnmanagedType.U1)]bool repeat);

        // cimgui.h:1260
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsKeyReleased(int user_key_index);

        // cimgui.h:1261
        [DllImport(DLLNAME)]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);

        // cimgui.h:1262
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseDown(int button);

        // cimgui.h:1263
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsAnyMouseDown();

        // cimgui.h:1264
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseClicked(int button, [MarshalAs(UnmanagedType.U1)]bool repeat);

        // cimgui.h:1265
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseDoubleClicked(int button);

        // cimgui.h:1266
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseReleased(int button);

        // cimgui.h:1267
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseDragging(int button, float lock_threshold);

        // cimgui.h:1268
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMouseHoveringRect(ImVec2 r_min, ImVec2 r_max, [MarshalAs(UnmanagedType.U1)]bool clip);

        // cimgui.h:1269
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool igIsMousePosValid(IntPtr mouse_pos);

        // cimgui.h:1270
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetMousePos();

        // cimgui.h:1271
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetMousePosOnOpeningCurrentPopup();

        // cimgui.h:1272
        [DllImport(DLLNAME)]
        public static extern ImVec2 igGetMouseDragDelta(int button, float lock_threshold);

        // cimgui.h:1273
        [DllImport(DLLNAME)]
        public static extern void igResetMouseDragDelta(int button);

        // cimgui.h:1274
        [DllImport(DLLNAME)]
        public static extern ImGuiMouseCursor igGetMouseCursor();

        // cimgui.h:1275
        [DllImport(DLLNAME)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor type);

        // cimgui.h:1276
        [DllImport(DLLNAME)]
        public static extern void igCaptureKeyboardFromApp([MarshalAs(UnmanagedType.U1)]bool want_capture_keyboard_value);

        // cimgui.h:1277
        [DllImport(DLLNAME)]
        public static extern void igCaptureMouseFromApp([MarshalAs(UnmanagedType.U1)]bool want_capture_mouse_value);

        // cimgui.h:1278
        [DllImport(DLLNAME)]
        public static extern IntPtr igGetClipboardText();

        // cimgui.h:1279
        [DllImport(DLLNAME)]
        public static extern void igSetClipboardText(IntPtr text);

        // cimgui.h:1280
        [DllImport(DLLNAME)]
        public static extern void igLoadIniSettingsFromDisk(IntPtr ini_filename);

        // cimgui.h:1281
        [DllImport(DLLNAME)]
        public static extern void igLoadIniSettingsFromMemory(IntPtr ini_data, ulong ini_size);

        // cimgui.h:1282
        [DllImport(DLLNAME)]
        public static extern void igSaveIniSettingsToDisk(IntPtr ini_filename);

        // cimgui.h:1283
        [DllImport(DLLNAME)]
        public static extern IntPtr igSaveIniSettingsToMemory(IntPtr out_ini_size);

        // cimgui.h:1284
        [DllImport(DLLNAME)]
        public static extern void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, IntPtr user_data);

        // cimgui.h:1285
        [DllImport(DLLNAME)]
        public static extern IntPtr igMemAlloc(ulong size);

        // cimgui.h:1286
        [DllImport(DLLNAME)]
        public static extern void igMemFree(IntPtr ptr);

        // cimgui.h:1287
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStyle_ImGuiStyle();

        // cimgui.h:1288
        [DllImport(DLLNAME)]
        public static extern void ImGuiStyle_destroy(IntPtr self);

        // cimgui.h:1289
        [DllImport(DLLNAME)]
        public static extern void ImGuiStyle_ScaleAllSizes(IntPtr self, float scale_factor);

        // cimgui.h:1290
        [DllImport(DLLNAME)]
        public static extern void ImGuiIO_AddInputCharacter(IntPtr self, uint c);

        // cimgui.h:1291
        [DllImport(DLLNAME)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(IntPtr self, IntPtr str);

        // cimgui.h:1292
        [DllImport(DLLNAME)]
        public static extern void ImGuiIO_ClearInputCharacters(IntPtr self);

        // cimgui.h:1293
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiIO_ImGuiIO();

        // cimgui.h:1294
        [DllImport(DLLNAME)]
        public static extern void ImGuiIO_destroy(IntPtr self);

        // cimgui.h:1295
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();

        // cimgui.h:1296
        [DllImport(DLLNAME)]
        public static extern void ImGuiInputTextCallbackData_destroy(IntPtr self);

        // cimgui.h:1297
        [DllImport(DLLNAME)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(IntPtr self, int pos, int bytes_count);

        // cimgui.h:1298
        [DllImport(DLLNAME)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(IntPtr self, int pos, IntPtr text, IntPtr text_end);

        // cimgui.h:1299
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiInputTextCallbackData_HasSelection(IntPtr self);

        // cimgui.h:1300
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiPayload_ImGuiPayload();

        // cimgui.h:1301
        [DllImport(DLLNAME)]
        public static extern void ImGuiPayload_destroy(IntPtr self);

        // cimgui.h:1302
        [DllImport(DLLNAME)]
        public static extern void ImGuiPayload_Clear(IntPtr self);

        // cimgui.h:1303
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiPayload_IsDataType(IntPtr self, IntPtr type);

        // cimgui.h:1304
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiPayload_IsPreview(IntPtr self);

        // cimgui.h:1305
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiPayload_IsDelivery(IntPtr self);

        // cimgui.h:1306
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();

        // cimgui.h:1307
        [DllImport(DLLNAME)]
        public static extern void ImGuiOnceUponAFrame_destroy(IntPtr self);

        // cimgui.h:1308
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextFilter_ImGuiTextFilter(IntPtr default_filter);

        // cimgui.h:1309
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextFilter_destroy(IntPtr self);

        // cimgui.h:1310
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiTextFilter_Draw(IntPtr self, IntPtr label, float width);

        // cimgui.h:1311
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiTextFilter_PassFilter(IntPtr self, IntPtr text, IntPtr text_end);

        // cimgui.h:1312
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextFilter_Build(IntPtr self);

        // cimgui.h:1313
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextFilter_Clear(IntPtr self);

        // cimgui.h:1314
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiTextFilter_IsActive(IntPtr self);

        // cimgui.h:1315
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextRange_ImGuiTextRange();

        // cimgui.h:1316
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextRange_destroy(IntPtr self);

        // cimgui.h:1317
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextRange_ImGuiTextRangeStr(IntPtr _b, IntPtr _e);

        // cimgui.h:1318
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiTextRange_empty(IntPtr self);

        // cimgui.h:1319
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextRange_split(IntPtr self, sbyte separator, IntPtr _out);

        // cimgui.h:1320
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextBuffer_ImGuiTextBuffer();

        // cimgui.h:1321
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_destroy(IntPtr self);

        // cimgui.h:1322
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextBuffer_begin(IntPtr self);

        // cimgui.h:1323
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextBuffer_end(IntPtr self);

        // cimgui.h:1324
        [DllImport(DLLNAME)]
        public static extern int ImGuiTextBuffer_size(IntPtr self);

        // cimgui.h:1325
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiTextBuffer_empty(IntPtr self);

        // cimgui.h:1326
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_clear(IntPtr self);

        // cimgui.h:1327
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_reserve(IntPtr self, int capacity);

        // cimgui.h:1328
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiTextBuffer_c_str(IntPtr self);

        // cimgui.h:1329
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_append(IntPtr self, IntPtr str, IntPtr str_end);

        // cimgui.h:1330
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_appendfv(IntPtr self, IntPtr fmt, int args);

        // cimgui.h:1331
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStoragePair_ImGuiStoragePairInt(ImGuiID _key, int _val_i);

        // cimgui.h:1332
        [DllImport(DLLNAME)]
        public static extern void ImGuiStoragePair_destroy(IntPtr self);

        // cimgui.h:1333
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStoragePair_ImGuiStoragePairFloat(ImGuiID _key, float _val_f);

        // cimgui.h:1334
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStoragePair_ImGuiStoragePairPtr(ImGuiID _key, IntPtr _val_p);

        // cimgui.h:1335
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_Clear(IntPtr self);

        // cimgui.h:1336
        [DllImport(DLLNAME)]
        public static extern int ImGuiStorage_GetInt(IntPtr self, ImGuiID key, int default_val);

        // cimgui.h:1337
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_SetInt(IntPtr self, ImGuiID key, int val);

        // cimgui.h:1338
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiStorage_GetBool(IntPtr self, ImGuiID key, [MarshalAs(UnmanagedType.U1)]bool default_val);

        // cimgui.h:1339
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_SetBool(IntPtr self, ImGuiID key, [MarshalAs(UnmanagedType.U1)]bool val);

        // cimgui.h:1340
        [DllImport(DLLNAME)]
        public static extern float ImGuiStorage_GetFloat(IntPtr self, ImGuiID key, float default_val);

        // cimgui.h:1341
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_SetFloat(IntPtr self, ImGuiID key, float val);

        // cimgui.h:1342
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStorage_GetVoidPtr(IntPtr self, ImGuiID key);

        // cimgui.h:1343
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_SetVoidPtr(IntPtr self, ImGuiID key, IntPtr val);

        // cimgui.h:1344
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStorage_GetIntRef(IntPtr self, ImGuiID key, int default_val);

        // cimgui.h:1345
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern ref bool ImGuiStorage_GetBoolRef(IntPtr self, ImGuiID key, [MarshalAs(UnmanagedType.U1)]bool default_val);

        // cimgui.h:1346
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStorage_GetFloatRef(IntPtr self, ImGuiID key, float default_val);

        // cimgui.h:1347
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiStorage_GetVoidPtrRef(IntPtr self, ImGuiID key, IntPtr default_val);

        // cimgui.h:1348
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_SetAllInt(IntPtr self, int val);

        // cimgui.h:1349
        [DllImport(DLLNAME)]
        public static extern void ImGuiStorage_BuildSortByKey(IntPtr self);

        // cimgui.h:1350
        [DllImport(DLLNAME)]
        public static extern IntPtr ImGuiListClipper_ImGuiListClipper(int items_count, float items_height);

        // cimgui.h:1351
        [DllImport(DLLNAME)]
        public static extern void ImGuiListClipper_destroy(IntPtr self);

        // cimgui.h:1352
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImGuiListClipper_Step(IntPtr self);

        // cimgui.h:1353
        [DllImport(DLLNAME)]
        public static extern void ImGuiListClipper_Begin(IntPtr self, int items_count, float items_height);

        // cimgui.h:1354
        [DllImport(DLLNAME)]
        public static extern void ImGuiListClipper_End(IntPtr self);

        // cimgui.h:1355
        [DllImport(DLLNAME)]
        public static extern IntPtr ImColor_ImColor();

        // cimgui.h:1356
        [DllImport(DLLNAME)]
        public static extern void ImColor_destroy(IntPtr self);

        // cimgui.h:1357
        [DllImport(DLLNAME)]
        public static extern IntPtr ImColor_ImColorInt(int r, int g, int b, int a);

        // cimgui.h:1358
        [DllImport(DLLNAME)]
        public static extern IntPtr ImColor_ImColorU32(uint rgba);

        // cimgui.h:1359
        [DllImport(DLLNAME)]
        public static extern IntPtr ImColor_ImColorFloat(float r, float g, float b, float a);

        // cimgui.h:1360
        [DllImport(DLLNAME)]
        public static extern IntPtr ImColor_ImColorVec4(ImVec4 col);

        // cimgui.h:1361
        [DllImport(DLLNAME)]
        public static extern void ImColor_SetHSV(IntPtr self, float h, float s, float v, float a);

        // cimgui.h:1362
        [DllImport(DLLNAME)]
        public static extern ImColor ImColor_HSV(IntPtr self, float h, float s, float v, float a);

        // cimgui.h:1363
        [DllImport(DLLNAME)]
        public static extern IntPtr ImDrawCmd_ImDrawCmd();

        // cimgui.h:1364
        [DllImport(DLLNAME)]
        public static extern void ImDrawCmd_destroy(IntPtr self);

        // cimgui.h:1365
        [DllImport(DLLNAME)]
        public static extern IntPtr ImDrawListSplitter_ImDrawListSplitter();

        // cimgui.h:1366
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_destroy(IntPtr self);

        // cimgui.h:1367
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_Clear(IntPtr self);

        // cimgui.h:1368
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(IntPtr self);

        // cimgui.h:1369
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_Split(IntPtr self, IntPtr draw_list, int count);

        // cimgui.h:1370
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_Merge(IntPtr self, IntPtr draw_list);

        // cimgui.h:1371
        [DllImport(DLLNAME)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(IntPtr self, IntPtr draw_list, int channel_idx);

        // cimgui.h:1372
        [DllImport(DLLNAME)]
        public static extern IntPtr ImDrawList_ImDrawList(IntPtr shared_data);

        // cimgui.h:1373
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_destroy(IntPtr self);

        // cimgui.h:1374
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PushClipRect(IntPtr self, ImVec2 clip_rect_min, ImVec2 clip_rect_max, [MarshalAs(UnmanagedType.U1)]bool intersect_with_current_clip_rect);

        // cimgui.h:1375
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PushClipRectFullScreen(IntPtr self);

        // cimgui.h:1376
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PopClipRect(IntPtr self);

        // cimgui.h:1377
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PushTextureID(IntPtr self, ImTextureID texture_id);

        // cimgui.h:1378
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PopTextureID(IntPtr self);

        // cimgui.h:1379
        [DllImport(DLLNAME)]
        public static extern ImVec2 ImDrawList_GetClipRectMin(IntPtr self);

        // cimgui.h:1380
        [DllImport(DLLNAME)]
        public static extern ImVec2 ImDrawList_GetClipRectMax(IntPtr self);

        // cimgui.h:1381
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddLine(IntPtr self, ImVec2 a, ImVec2 b, uint col, float thickness);

        // cimgui.h:1382
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddRect(IntPtr self, ImVec2 a, ImVec2 b, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);

        // cimgui.h:1383
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddRectFilled(IntPtr self, ImVec2 a, ImVec2 b, uint col, float rounding, ImDrawCornerFlags rounding_corners);

        // cimgui.h:1384
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddRectFilledMultiColor(IntPtr self, ImVec2 a, ImVec2 b, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);

        // cimgui.h:1385
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddQuad(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 c, ImVec2 d, uint col, float thickness);

        // cimgui.h:1386
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddQuadFilled(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 c, ImVec2 d, uint col);

        // cimgui.h:1387
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddTriangle(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 c, uint col, float thickness);

        // cimgui.h:1388
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddTriangleFilled(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 c, uint col);

        // cimgui.h:1389
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddCircle(IntPtr self, ImVec2 centre, float radius, uint col, int num_segments, float thickness);

        // cimgui.h:1390
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddCircleFilled(IntPtr self, ImVec2 centre, float radius, uint col, int num_segments);

        // cimgui.h:1391
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddText(IntPtr self, ImVec2 pos, uint col, IntPtr text_begin, IntPtr text_end);

        // cimgui.h:1392
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddTextFontPtr(IntPtr self, IntPtr font, float font_size, ImVec2 pos, uint col, IntPtr text_begin, IntPtr text_end, float wrap_width, IntPtr cpu_fine_clip_rect);

        // cimgui.h:1393
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddImage(IntPtr self, ImTextureID user_texture_id, ImVec2 a, ImVec2 b, ImVec2 uv_a, ImVec2 uv_b, uint col);

        // cimgui.h:1394
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddImageQuad(IntPtr self, ImTextureID user_texture_id, ImVec2 a, ImVec2 b, ImVec2 c, ImVec2 d, ImVec2 uv_a, ImVec2 uv_b, ImVec2 uv_c, ImVec2 uv_d, uint col);

        // cimgui.h:1395
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddImageRounded(IntPtr self, ImTextureID user_texture_id, ImVec2 a, ImVec2 b, ImVec2 uv_a, ImVec2 uv_b, uint col, float rounding, ImDrawCornerFlags rounding_corners);

        // cimgui.h:1396
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddPolyline(IntPtr self, IntPtr points, int num_points, uint col, [MarshalAs(UnmanagedType.U1)]bool closed, float thickness);

        // cimgui.h:1397
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddConvexPolyFilled(IntPtr self, IntPtr points, int num_points, uint col);

        // cimgui.h:1398
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddBezierCurve(IntPtr self, ImVec2 pos0, ImVec2 cp0, ImVec2 cp1, ImVec2 pos1, uint col, float thickness, int num_segments);

        // cimgui.h:1399
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathClear(IntPtr self);

        // cimgui.h:1400
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathLineTo(IntPtr self, ImVec2 pos);

        // cimgui.h:1401
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(IntPtr self, ImVec2 pos);

        // cimgui.h:1402
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathFillConvex(IntPtr self, uint col);

        // cimgui.h:1403
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathStroke(IntPtr self, uint col, [MarshalAs(UnmanagedType.U1)]bool closed, float thickness);

        // cimgui.h:1404
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathArcTo(IntPtr self, ImVec2 centre, float radius, float a_min, float a_max, int num_segments);

        // cimgui.h:1405
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathArcToFast(IntPtr self, ImVec2 centre, float radius, int a_min_of_12, int a_max_of_12);

        // cimgui.h:1406
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathBezierCurveTo(IntPtr self, ImVec2 p1, ImVec2 p2, ImVec2 p3, int num_segments);

        // cimgui.h:1407
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PathRect(IntPtr self, ImVec2 rect_min, ImVec2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);

        // cimgui.h:1408
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddCallback(IntPtr self, IntPtr callback, IntPtr callback_data);

        // cimgui.h:1409
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_AddDrawCmd(IntPtr self);

        // cimgui.h:1410
        [DllImport(DLLNAME)]
        public static extern IntPtr ImDrawList_CloneOutput(IntPtr self);

        // cimgui.h:1411
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_ChannelsSplit(IntPtr self, int count);

        // cimgui.h:1412
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_ChannelsMerge(IntPtr self);

        // cimgui.h:1413
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_ChannelsSetCurrent(IntPtr self, int n);

        // cimgui.h:1414
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_Clear(IntPtr self);

        // cimgui.h:1415
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_ClearFreeMemory(IntPtr self);

        // cimgui.h:1416
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimReserve(IntPtr self, int idx_count, int vtx_count);

        // cimgui.h:1417
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimRect(IntPtr self, ImVec2 a, ImVec2 b, uint col);

        // cimgui.h:1418
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimRectUV(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 uv_a, ImVec2 uv_b, uint col);

        // cimgui.h:1419
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimQuadUV(IntPtr self, ImVec2 a, ImVec2 b, ImVec2 c, ImVec2 d, ImVec2 uv_a, ImVec2 uv_b, ImVec2 uv_c, ImVec2 uv_d, uint col);

        // cimgui.h:1420
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimWriteVtx(IntPtr self, ImVec2 pos, ImVec2 uv, uint col);

        // cimgui.h:1421
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimWriteIdx(IntPtr self, ImDrawIdx idx);

        // cimgui.h:1422
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_PrimVtx(IntPtr self, ImVec2 pos, ImVec2 uv, uint col);

        // cimgui.h:1423
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_UpdateClipRect(IntPtr self);

        // cimgui.h:1424
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_UpdateTextureID(IntPtr self);

        // cimgui.h:1425
        [DllImport(DLLNAME)]
        public static extern IntPtr ImDrawData_ImDrawData();

        // cimgui.h:1426
        [DllImport(DLLNAME)]
        public static extern void ImDrawData_destroy(IntPtr self);

        // cimgui.h:1427
        [DllImport(DLLNAME)]
        public static extern void ImDrawData_Clear(IntPtr self);

        // cimgui.h:1428
        [DllImport(DLLNAME)]
        public static extern void ImDrawData_DeIndexAllBuffers(IntPtr self);

        // cimgui.h:1429
        [DllImport(DLLNAME)]
        public static extern void ImDrawData_ScaleClipRects(IntPtr self, ImVec2 fb_scale);

        // cimgui.h:1430
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontConfig_ImFontConfig();

        // cimgui.h:1431
        [DllImport(DLLNAME)]
        public static extern void ImFontConfig_destroy(IntPtr self);

        // cimgui.h:1432
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();

        // cimgui.h:1433
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_destroy(IntPtr self);

        // cimgui.h:1434
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_Clear(IntPtr self);

        // cimgui.h:1435
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFontGlyphRangesBuilder_GetBit(IntPtr self, int n);

        // cimgui.h:1436
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(IntPtr self, int n);

        // cimgui.h:1437
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(IntPtr self, ImWchar c);

        // cimgui.h:1438
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_AddText(IntPtr self, IntPtr text, IntPtr text_end);

        // cimgui.h:1439
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(IntPtr self, IntPtr ranges);

        // cimgui.h:1440
        [DllImport(DLLNAME)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(IntPtr self, IntPtr out_ranges);

        // cimgui.h:1441
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlasCustomRect_ImFontAtlasCustomRect();

        // cimgui.h:1442
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlasCustomRect_destroy(IntPtr self);

        // cimgui.h:1443
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFontAtlasCustomRect_IsPacked(IntPtr self);

        // cimgui.h:1444
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_ImFontAtlas();

        // cimgui.h:1445
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_destroy(IntPtr self);

        // cimgui.h:1446
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFont(IntPtr self, IntPtr font_cfg);

        // cimgui.h:1447
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFontDefault(IntPtr self, IntPtr font_cfg);

        // cimgui.h:1448
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFontFromFileTTF(IntPtr self, IntPtr filename, float size_pixels, IntPtr font_cfg, IntPtr glyph_ranges);

        // cimgui.h:1449
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFontFromMemoryTTF(IntPtr self, IntPtr font_data, int font_size, float size_pixels, IntPtr font_cfg, IntPtr glyph_ranges);

        // cimgui.h:1450
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFontFromMemoryCompressedTTF(IntPtr self, IntPtr compressed_font_data, int compressed_font_size, float size_pixels, IntPtr font_cfg, IntPtr glyph_ranges);

        // cimgui.h:1451
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(IntPtr self, IntPtr compressed_font_data_base85, float size_pixels, IntPtr font_cfg, IntPtr glyph_ranges);

        // cimgui.h:1452
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_ClearInputData(IntPtr self);

        // cimgui.h:1453
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_ClearTexData(IntPtr self);

        // cimgui.h:1454
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_ClearFonts(IntPtr self);

        // cimgui.h:1455
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_Clear(IntPtr self);

        // cimgui.h:1456
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFontAtlas_Build(IntPtr self);

        // cimgui.h:1457
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(IntPtr self, IntPtr out_pixels, IntPtr out_width, IntPtr out_height, IntPtr out_bytes_per_pixel);

        // cimgui.h:1458
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(IntPtr self, IntPtr out_pixels, IntPtr out_width, IntPtr out_height, IntPtr out_bytes_per_pixel);

        // cimgui.h:1459
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFontAtlas_IsBuilt(IntPtr self);

        // cimgui.h:1460
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_SetTexID(IntPtr self, ImTextureID id);

        // cimgui.h:1461
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesDefault(IntPtr self);

        // cimgui.h:1462
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesKorean(IntPtr self);

        // cimgui.h:1463
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesJapanese(IntPtr self);

        // cimgui.h:1464
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesChineseFull(IntPtr self);

        // cimgui.h:1465
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(IntPtr self);

        // cimgui.h:1466
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesCyrillic(IntPtr self);

        // cimgui.h:1467
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesThai(IntPtr self);

        // cimgui.h:1468
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetGlyphRangesVietnamese(IntPtr self);

        // cimgui.h:1469
        [DllImport(DLLNAME)]
        public static extern int ImFontAtlas_AddCustomRectRegular(IntPtr self, uint id, int width, int height);

        // cimgui.h:1470
        [DllImport(DLLNAME)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(IntPtr self, IntPtr font, ImWchar id, int width, int height, float advance_x, ImVec2 offset);

        // cimgui.h:1471
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFontAtlas_GetCustomRectByIndex(IntPtr self, int index);

        // cimgui.h:1472
        [DllImport(DLLNAME)]
        public static extern void ImFontAtlas_CalcCustomRectUV(IntPtr self, IntPtr rect, IntPtr out_uv_min, IntPtr out_uv_max);

        // cimgui.h:1473
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFontAtlas_GetMouseCursorTexData(IntPtr self, ImGuiMouseCursor cursor, IntPtr out_offset, IntPtr out_size, IntPtr out_uv_border, IntPtr out_uv_fill);

        // cimgui.h:1474
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFont_ImFont();

        // cimgui.h:1475
        [DllImport(DLLNAME)]
        public static extern void ImFont_destroy(IntPtr self);

        // cimgui.h:1476
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFont_FindGlyph(IntPtr self, ImWchar c);

        // cimgui.h:1477
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFont_FindGlyphNoFallback(IntPtr self, ImWchar c);

        // cimgui.h:1478
        [DllImport(DLLNAME)]
        public static extern float ImFont_GetCharAdvance(IntPtr self, ImWchar c);

        // cimgui.h:1479
        [DllImport(DLLNAME)]
        [return: MarshalAs(UnmanagedType.U1)]

        public static extern bool ImFont_IsLoaded(IntPtr self);

        // cimgui.h:1480
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFont_GetDebugName(IntPtr self);

        // cimgui.h:1481
        [DllImport(DLLNAME)]
        public static extern ImVec2 ImFont_CalcTextSizeA(IntPtr self, float size, float max_width, float wrap_width, IntPtr text_begin, IntPtr text_end, IntPtr remaining);

        // cimgui.h:1482
        [DllImport(DLLNAME)]
        public static extern IntPtr ImFont_CalcWordWrapPositionA(IntPtr self, float scale, IntPtr text, IntPtr text_end, float wrap_width);

        // cimgui.h:1483
        [DllImport(DLLNAME)]
        public static extern void ImFont_RenderChar(IntPtr self, IntPtr draw_list, float size, ImVec2 pos, uint col, ImWchar c);

        // cimgui.h:1484
        [DllImport(DLLNAME)]
        public static extern void ImFont_RenderText(IntPtr self, IntPtr draw_list, float size, ImVec2 pos, uint col, ImVec4 clip_rect, IntPtr text_begin, IntPtr text_end, float wrap_width, [MarshalAs(UnmanagedType.U1)]bool cpu_fine_clip);

        // cimgui.h:1485
        [DllImport(DLLNAME)]
        public static extern void ImFont_BuildLookupTable(IntPtr self);

        // cimgui.h:1486
        [DllImport(DLLNAME)]
        public static extern void ImFont_ClearOutputData(IntPtr self);

        // cimgui.h:1487
        [DllImport(DLLNAME)]
        public static extern void ImFont_GrowIndex(IntPtr self, int new_size);

        // cimgui.h:1488
        [DllImport(DLLNAME)]
        public static extern void ImFont_AddGlyph(IntPtr self, ImWchar c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);

        // cimgui.h:1489
        [DllImport(DLLNAME)]
        public static extern void ImFont_AddRemapChar(IntPtr self, ImWchar dst, ImWchar src, [MarshalAs(UnmanagedType.U1)]bool overwrite_dst);

        // cimgui.h:1490
        [DllImport(DLLNAME)]
        public static extern void ImFont_SetFallbackChar(IntPtr self, ImWchar c);

        // cimgui.h:1491
        [DllImport(DLLNAME)]
        public static extern void igGetWindowPos_nonUDT(IntPtr pOut);

        // cimgui.h:1492
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetWindowPos_nonUDT2();

        // cimgui.h:1493
        [DllImport(DLLNAME)]
        public static extern void igGetWindowSize_nonUDT(IntPtr pOut);

        // cimgui.h:1494
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetWindowSize_nonUDT2();

        // cimgui.h:1495
        [DllImport(DLLNAME)]
        public static extern void igGetContentRegionMax_nonUDT(IntPtr pOut);

        // cimgui.h:1496
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetContentRegionMax_nonUDT2();

        // cimgui.h:1497
        [DllImport(DLLNAME)]
        public static extern void igGetContentRegionAvail_nonUDT(IntPtr pOut);

        // cimgui.h:1498
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetContentRegionAvail_nonUDT2();

        // cimgui.h:1499
        [DllImport(DLLNAME)]
        public static extern void igGetWindowContentRegionMin_nonUDT(IntPtr pOut);

        // cimgui.h:1500
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetWindowContentRegionMin_nonUDT2();

        // cimgui.h:1501
        [DllImport(DLLNAME)]
        public static extern void igGetWindowContentRegionMax_nonUDT(IntPtr pOut);

        // cimgui.h:1502
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetWindowContentRegionMax_nonUDT2();

        // cimgui.h:1503
        [DllImport(DLLNAME)]
        public static extern void igGetFontTexUvWhitePixel_nonUDT(IntPtr pOut);

        // cimgui.h:1504
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetFontTexUvWhitePixel_nonUDT2();

        // cimgui.h:1505
        [DllImport(DLLNAME)]
        public static extern void igGetCursorPos_nonUDT(IntPtr pOut);

        // cimgui.h:1506
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetCursorPos_nonUDT2();

        // cimgui.h:1507
        [DllImport(DLLNAME)]
        public static extern void igGetCursorStartPos_nonUDT(IntPtr pOut);

        // cimgui.h:1508
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetCursorStartPos_nonUDT2();

        // cimgui.h:1509
        [DllImport(DLLNAME)]
        public static extern void igGetCursorScreenPos_nonUDT(IntPtr pOut);

        // cimgui.h:1510
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetCursorScreenPos_nonUDT2();

        // cimgui.h:1511
        [DllImport(DLLNAME)]
        public static extern void igGetItemRectMin_nonUDT(IntPtr pOut);

        // cimgui.h:1512
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetItemRectMin_nonUDT2();

        // cimgui.h:1513
        [DllImport(DLLNAME)]
        public static extern void igGetItemRectMax_nonUDT(IntPtr pOut);

        // cimgui.h:1514
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetItemRectMax_nonUDT2();

        // cimgui.h:1515
        [DllImport(DLLNAME)]
        public static extern void igGetItemRectSize_nonUDT(IntPtr pOut);

        // cimgui.h:1516
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetItemRectSize_nonUDT2();

        // cimgui.h:1517
        [DllImport(DLLNAME)]
        public static extern void igCalcTextSize_nonUDT(IntPtr pOut, IntPtr text, IntPtr text_end, [MarshalAs(UnmanagedType.U1)]bool hide_text_after_double_hash, float wrap_width);

        // cimgui.h:1518
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igCalcTextSize_nonUDT2(IntPtr text, IntPtr text_end, [MarshalAs(UnmanagedType.U1)]bool hide_text_after_double_hash, float wrap_width);

        // cimgui.h:1519
        [DllImport(DLLNAME)]
        public static extern void igColorConvertU32ToFloat4_nonUDT(IntPtr pOut, uint _in);

        // cimgui.h:1520
        [DllImport(DLLNAME)]
        public static extern ImVec4_Simple igColorConvertU32ToFloat4_nonUDT2(uint _in);

        // cimgui.h:1521
        [DllImport(DLLNAME)]
        public static extern void igGetMousePos_nonUDT(IntPtr pOut);

        // cimgui.h:1522
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetMousePos_nonUDT2();

        // cimgui.h:1523
        [DllImport(DLLNAME)]
        public static extern void igGetMousePosOnOpeningCurrentPopup_nonUDT(IntPtr pOut);

        // cimgui.h:1524
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetMousePosOnOpeningCurrentPopup_nonUDT2();

        // cimgui.h:1525
        [DllImport(DLLNAME)]
        public static extern void igGetMouseDragDelta_nonUDT(IntPtr pOut, int button, float lock_threshold);

        // cimgui.h:1526
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple igGetMouseDragDelta_nonUDT2(int button, float lock_threshold);

        // cimgui.h:1527
        [DllImport(DLLNAME)]
        public static extern void ImColor_HSV_nonUDT(IntPtr pOut, IntPtr self, float h, float s, float v, float a);

        // cimgui.h:1528
        [DllImport(DLLNAME)]
        public static extern ImColor_Simple ImColor_HSV_nonUDT2(IntPtr self, float h, float s, float v, float a);

        // cimgui.h:1529
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_GetClipRectMin_nonUDT(IntPtr pOut, IntPtr self);

        // cimgui.h:1530
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple ImDrawList_GetClipRectMin_nonUDT2(IntPtr self);

        // cimgui.h:1531
        [DllImport(DLLNAME)]
        public static extern void ImDrawList_GetClipRectMax_nonUDT(IntPtr pOut, IntPtr self);

        // cimgui.h:1532
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple ImDrawList_GetClipRectMax_nonUDT2(IntPtr self);

        // cimgui.h:1533
        [DllImport(DLLNAME)]
        public static extern void ImFont_CalcTextSizeA_nonUDT(IntPtr pOut, IntPtr self, float size, float max_width, float wrap_width, IntPtr text_begin, IntPtr text_end, IntPtr remaining);

        // cimgui.h:1534
        [DllImport(DLLNAME)]
        public static extern ImVec2_Simple ImFont_CalcTextSizeA_nonUDT2(IntPtr self, float size, float max_width, float wrap_width, IntPtr text_begin, IntPtr text_end, IntPtr remaining);

        // cimgui.h:2035
        [DllImport(DLLNAME)]
        public static extern void igLogText(IntPtr fmt);

        // cimgui.h:2037
        [DllImport(DLLNAME)]
        public static extern void ImGuiTextBuffer_appendf(IntPtr buffer, IntPtr fmt);

        // cimgui.h:2039
        [DllImport(DLLNAME)]
        public static extern float igGET_FLT_MAX();

        // cimgui.h:2041
        [DllImport(DLLNAME)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, IntPtr out_h, IntPtr out_s, IntPtr out_v);

        // cimgui.h:2042
        [DllImport(DLLNAME)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, IntPtr out_r, IntPtr out_g, IntPtr out_b);
    }
}