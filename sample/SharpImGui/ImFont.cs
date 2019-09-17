// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:2268
    
    public struct ImFont
    {
        // offsetof: 0
        public ImVector IndexAdvanceX;
        // offsetof: 16
        public float FallbackAdvanceX;
        // offsetof: 20
        public float FontSize;
        // offsetof: 24
        public ImVector IndexLookup;
        // offsetof: 40
        public ImVector Glyphs;
        // offsetof: 56
        public IntPtr FallbackGlyph;
        // offsetof: 64
        public Vector2 DisplayOffset;
        // offsetof: 72
        public IntPtr ContainerAtlas;
        // offsetof: 80
        public IntPtr ConfigData;
        // offsetof: 88
        public short ConfigDataCount;
        // offsetof: 90
        public ImWchar FallbackChar;
        // offsetof: 92
        public float Scale;
        // offsetof: 96
        public float Ascent;
        // offsetof: 100
        public float Descent;
        // offsetof: 104
        public int MetricsTotalSurface;
        // offsetof: 108
        [MarshalAs(UnmanagedType.U1)]public bool DirtyLookupTables;
    }
}