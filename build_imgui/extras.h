#pragma once
#include <Windows.h>
#include <imgui.h>
#include <imgui_internal.h>

// Handler for Win32 messages, update mouse/keyboard data.
// You may or not need this for your implementation, but it can serve as reference for handling inputs.
// Intentionally commented out to avoid dragging dependencies on <windows.h> types. You can COPY this line into your .cpp code instead.
IMGUI_IMPL_API LRESULT ImGui_ImplWin32_WndProcHandler(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

IMGUI_IMPL_API void exDockSpace(ImGuiID id, const ImVec2 size, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API ImGuiID exDockSpaceOverViewport(ImGuiViewport *viewport, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API void exSetNextWindowDockID(ImGuiID dock_id, ImGuiCond cond);     // set next window dock id (FIXME-DOCK)
IMGUI_IMPL_API void exSetNextWindowClass(const ImGuiWindowClass *window_class); // set next window class (rare/advanced uses: provide hints to the platform back-end via altered viewport flags and parent/child info)
IMGUI_IMPL_API ImGuiID exGetWindowDockID();
IMGUI_IMPL_API bool exIsWindowDocked(); // is current window docked into another window?
