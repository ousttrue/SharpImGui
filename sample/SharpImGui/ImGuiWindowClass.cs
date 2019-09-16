// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:1594
    
    public struct ImGuiWindowClass
    {
        // offsetof: 0
        public ImGuiID ClassId;
        // offsetof: 4
        public ImGuiID ParentViewportId;
        // offsetof: 8
        public ImGuiViewportFlags ViewportFlagsOverrideSet;
        // offsetof: 12
        public ImGuiViewportFlags ViewportFlagsOverrideClear;
        // offsetof: 16
        [MarshalAs(UnmanagedType.U1)]public bool DockingAlwaysTabBar;
        // offsetof: 17
        [MarshalAs(UnmanagedType.U1)]public bool DockingAllowUnclassed;
    }
}