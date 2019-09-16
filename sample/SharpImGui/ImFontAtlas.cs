// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:2178
    
    public struct ImFontAtlas
    {
        // offsetof: 0
        [MarshalAs(UnmanagedType.U1)]public bool Locked;
        // offsetof: 4
        public ImFontAtlasFlags Flags;
        // offsetof: 8
        public ImTextureID TexID;
        // offsetof: 16
        public int TexDesiredWidth;
        // offsetof: 20
        public int TexGlyphPadding;
        // offsetof: 24
        public IntPtr TexPixelsAlpha8;
        // offsetof: 32
        public IntPtr TexPixelsRGBA32;
        // offsetof: 40
        public int TexWidth;
        // offsetof: 44
        public int TexHeight;
        // offsetof: 48
        public ImVec2 TexUvScale;
        // offsetof: 56
        public ImVec2 TexUvWhitePixel;
        // offsetof: 64
        public ImVector Fonts;
        // offsetof: 80
        public ImVector CustomRects;
        // offsetof: 96
        public ImVector ConfigData;
        // offsetof: 112
        public IntPtr CustomRectIds;
    }
}