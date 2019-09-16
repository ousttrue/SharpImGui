// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:2091
    
    public struct ImFontConfig
    {
        // offsetof: 0
        public IntPtr FontData;
        // offsetof: 8
        public int FontDataSize;
        // offsetof: 12
        [MarshalAs(UnmanagedType.U1)]public bool FontDataOwnedByAtlas;
        // offsetof: 16
        public int FontNo;
        // offsetof: 20
        public float SizePixels;
        // offsetof: 24
        public int OversampleH;
        // offsetof: 28
        public int OversampleV;
        // offsetof: 32
        [MarshalAs(UnmanagedType.U1)]public bool PixelSnapH;
        // offsetof: 36
        public ImVec2 GlyphExtraSpacing;
        // offsetof: 44
        public ImVec2 GlyphOffset;
        // offsetof: 56
        public IntPtr GlyphRanges;
        // offsetof: 64
        public float GlyphMinAdvanceX;
        // offsetof: 68
        public float GlyphMaxAdvanceX;
        // offsetof: 72
        [MarshalAs(UnmanagedType.U1)]public bool MergeMode;
        // offsetof: 76
        public uint RasterizerFlags;
        // offsetof: 80
        public float RasterizerMultiply;
        // offsetof: 84
        public IntPtr Name;
        // offsetof: 128
        public IntPtr DstFont;
    }
}