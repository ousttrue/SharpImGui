// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:2268
    
    public struct ImFont
    {
        // offsetof: -1
        public ImVector IndexAdvanceX;
        // offsetof: -1
        public float FallbackAdvanceX;
        // offsetof: -1
        public float FontSize;
        // offsetof: -1
        public ImVector IndexLookup;
        // offsetof: -1
        public ImVector Glyphs;
        // offsetof: -1
        public IntPtr FallbackGlyph;
        // offsetof: -1
        public ImVec2 DisplayOffset;
        // offsetof: -1
        public IntPtr ContainerAtlas;
        // offsetof: -1
        public IntPtr ConfigData;
        // offsetof: -1
        public short ConfigDataCount;
        // offsetof: -1
        public ImWchar FallbackChar;
        // offsetof: -1
        public float Scale;
        // offsetof: -1
        public float Ascent;
        // offsetof: -1
        public float Descent;
        // offsetof: -1
        public int MetricsTotalSurface;
        // offsetof: -1
        [MarshalAs(UnmanagedType.U1)]public bool DirtyLookupTables;
    }
}