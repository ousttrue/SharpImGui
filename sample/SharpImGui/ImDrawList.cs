// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:1969
    
    public struct ImDrawList
    {
        // offsetof: 0
        public ImVector CmdBuffer;
        // offsetof: 16
        public ImVector IdxBuffer;
        // offsetof: 32
        public ImVector VtxBuffer;
        // offsetof: 48
        public ImDrawListFlags Flags;
        // offsetof: 56
        public IntPtr _Data;
        // offsetof: 64
        public IntPtr _OwnerName;
        // offsetof: 72
        public uint _VtxCurrentOffset;
        // offsetof: 76
        public uint _VtxCurrentIdx;
        // offsetof: 80
        public IntPtr _VtxWritePtr;
        // offsetof: 88
        public IntPtr _IdxWritePtr;
        // offsetof: 96
        public ImVector _ClipRectStack;
        // offsetof: 112
        public ImVector _TextureIdStack;
        // offsetof: 128
        public ImVector _Path;
        // offsetof: 144
        public ImDrawListSplitter _Splitter;
    }
}