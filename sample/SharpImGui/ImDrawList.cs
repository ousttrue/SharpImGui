// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:1969
    
    public struct ImDrawList
    {
        // offsetof: -1
        public ImVector CmdBuffer;
        // offsetof: -1
        public ImVector IdxBuffer;
        // offsetof: -1
        public ImVector VtxBuffer;
        // offsetof: -1
        public ImDrawListFlags Flags;
        // offsetof: -1
        public IntPtr _Data;
        // offsetof: -1
        public IntPtr _OwnerName;
        // offsetof: -1
        public uint _VtxCurrentOffset;
        // offsetof: -1
        public uint _VtxCurrentIdx;
        // offsetof: -1
        public IntPtr _VtxWritePtr;
        // offsetof: -1
        public IntPtr _IdxWritePtr;
        // offsetof: -1
        public ImVector _ClipRectStack;
        // offsetof: -1
        public ImVector _TextureIdStack;
        // offsetof: -1
        public ImVector _Path;
        // offsetof: -1
        public ImDrawListSplitter _Splitter;
    }
}