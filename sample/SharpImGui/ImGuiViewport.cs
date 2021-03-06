// // generated cpptypeinfo-0.2.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:2415
    
    public struct ImGuiViewport
    {
        // offsetof: 0
        public ImGuiID ID;
        // offsetof: 4
        public ImGuiViewportFlags Flags;
        // offsetof: 8
        public Vector2 Pos;
        // offsetof: 16
        public Vector2 Size;
        // offsetof: 24
        public float DpiScale;
        // offsetof: 32
        public IntPtr DrawData;
        // offsetof: 40
        public ImGuiID ParentViewportId;
        // offsetof: 48
        public IntPtr RendererUserData;
        // offsetof: 56
        public IntPtr PlatformUserData;
        // offsetof: 64
        public IntPtr PlatformHandle;
        // offsetof: 72
        public IntPtr PlatformHandleRaw;
        // offsetof: 80
        [MarshalAs(UnmanagedType.U1)]public bool PlatformRequestClose;
        // offsetof: 81
        [MarshalAs(UnmanagedType.U1)]public bool PlatformRequestMove;
        // offsetof: 82
        [MarshalAs(UnmanagedType.U1)]public bool PlatformRequestResize;
    }
}