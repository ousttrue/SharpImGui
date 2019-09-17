// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:2067
    
    public struct ImDrawData
    {
        // offsetof: 0
        [MarshalAs(UnmanagedType.U1)]public bool Valid;
        // offsetof: 8
        public IntPtr CmdLists;
        // offsetof: 16
        public int CmdListsCount;
        // offsetof: 20
        public int TotalIdxCount;
        // offsetof: 24
        public int TotalVtxCount;
        // offsetof: 28
        public Vector2 DisplayPos;
        // offsetof: 36
        public Vector2 DisplaySize;
        // offsetof: 44
        public Vector2 FramebufferScale;
        // offsetof: 56
        public IntPtr OwnerViewport;
    }
}