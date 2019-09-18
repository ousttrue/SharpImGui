#include "extras.h"

IMGUI_IMPL_API void exDockSpace(ImGuiID id, const ImVec2 size, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class)
{
    ImGui::DockSpace(id, size, flags, window_class);
}

IMGUI_IMPL_API ImGuiID exDockSpaceOverViewport(ImGuiViewport *viewport, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class)
{
    return ImGui::DockSpaceOverViewport(viewport, flags, window_class);
}

IMGUI_IMPL_API void exSetNextWindowDockID(ImGuiID dock_id, ImGuiCond cond)
{
    ImGui::SetNextWindowDockID(dock_id, cond);
}

IMGUI_IMPL_API void exSetNextWindowClass(const ImGuiWindowClass *window_class)
{
    ImGui::SetNextWindowClass(window_class);
}

IMGUI_IMPL_API ImGuiID exGetWindowDockID()
{
    return ImGui::GetWindowDockID();
}

IMGUI_IMPL_API bool exIsWindowDocked()
{
    return ImGui::IsWindowDocked();
}

IMGUI_IMPL_API void *exImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas *font)
{
    return (void *)font->GetGlyphRangesJapanese();
}

IMGUI_IMPL_API void *exImFontAtlas_AddFontFromFileTTF(ImFontAtlas *font, const char *filename, float size_pixels, const ImFontConfig *font_cfg_template, const ImWchar *glyph_ranges)
{
    return font->AddFontFromFileTTF(filename, size_pixels, font_cfg_template, glyph_ranges);
}
