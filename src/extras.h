#pragma once
#define IMGUI_IMPL_API extern "C" __declspec(dllexport)
#include <imgui.h>
#include <imgui_internal.h>

// #include <imgui_impl_dx11.h>
struct ID3D11Device;
struct ID3D11DeviceContext;

IMGUI_IMPL_API bool ImGui_ImplDX11_Init(ID3D11Device *device, ID3D11DeviceContext *device_context);
IMGUI_IMPL_API void ImGui_ImplDX11_Shutdown();
IMGUI_IMPL_API void ImGui_ImplDX11_NewFrame();
IMGUI_IMPL_API void ImGui_ImplDX11_RenderDrawData(ImDrawData *draw_data);

// Use if you want to reset your rendering device without losing ImGui state.
IMGUI_IMPL_API void ImGui_ImplDX11_InvalidateDeviceObjects();
IMGUI_IMPL_API bool ImGui_ImplDX11_CreateDeviceObjects();
#include <imgui_impl_dx11.cpp>

// #include <imgui_impl_win32.h>
IMGUI_IMPL_API bool ImGui_ImplWin32_Init(void *hwnd);
IMGUI_IMPL_API void ImGui_ImplWin32_Shutdown();
IMGUI_IMPL_API void ImGui_ImplWin32_NewFrame();

// DPI-related helpers (which run and compile without requiring 8.1 or 10, neither Windows version, neither associated SDK)
IMGUI_IMPL_API void ImGui_ImplWin32_EnableDpiAwareness();
IMGUI_IMPL_API float ImGui_ImplWin32_GetDpiScaleForHwnd(void *hwnd);       // HWND hwnd
IMGUI_IMPL_API float ImGui_ImplWin32_GetDpiScaleForMonitor(void *monitor); // HMONITOR monitor

// Handler for Win32 messages, update mouse/keyboard data.
// You may or not need this for your implementation, but it can serve as reference for handling inputs.
// Intentionally commented out to avoid dragging dependencies on <windows.h> types. You can COPY this line into your .cpp code instead.
IMGUI_IMPL_API void *ImGui_ImplWin32_WndProcHandler(void *hWnd, unsigned int msg, void *wParam, void *lParam);

#include <imgui_impl_win32.cpp>

IMGUI_IMPL_API void exDockSpace(ImGuiID id, const ImVec2 size, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API ImGuiID exDockSpaceOverViewport(ImGuiViewport *viewport, ImGuiDockNodeFlags flags, const ImGuiWindowClass *window_class);
IMGUI_IMPL_API void exSetNextWindowDockID(ImGuiID dock_id, ImGuiCond cond);     // set next window dock id (FIXME-DOCK)
IMGUI_IMPL_API void exSetNextWindowClass(const ImGuiWindowClass *window_class); // set next window class (rare/advanced uses: provide hints to the platform back-end via altered viewport flags and parent/child info)
IMGUI_IMPL_API ImGuiID exGetWindowDockID();
IMGUI_IMPL_API bool exIsWindowDocked(); // is current window docked into another window?
