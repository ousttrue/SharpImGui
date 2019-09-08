#pragma once
#define IMGUI_IMPL_API extern "C" __declspec(dllexport)
#include <imgui.h>
#include <imgui_internal.h>
#include <imgui_impl_dx11.h>
#include <imgui_impl_dx11.cpp>
#include <imgui_impl_win32.h>
#include <imgui_impl_win32.cpp>

IMGUI_IMPL_API void exDockSpace(ImGuiID id, const ImVec2 size, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API ImGuiID exDockSpaceOverViewport(ImGuiViewport *viewport, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API void exSetNextWindowDockID(ImGuiID dock_id, ImGuiCond cond); // set next window dock id (FIXME-DOCK)
IMGUI_IMPL_API void exSetNextWindowClass(const ImGuiWindowClass *window_class); // set next window class (rare/advanced uses: provide hints to the platform back-end via altered viewport flags and parent/child info)
IMGUI_IMPL_API ImGuiID exGetWindowDockID();
IMGUI_IMPL_API bool exIsWindowDocked(); // is current window docked into another window?
