// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:2178
    
    public struct ImFontAtlas
    {
        // offsetof: -1
        [MarshalAs(UnmanagedType.U1)]public bool Locked;
        // offsetof: -1
        public ImFontAtlasFlags Flags;
        // offsetof: -1
        public ImTextureID TexID;
        // offsetof: -1
        public int TexDesiredWidth;
        // offsetof: -1
        public int TexGlyphPadding;
        // offsetof: -1
        public IntPtr TexPixelsAlpha8;
        // offsetof: -1
        public IntPtr TexPixelsRGBA32;
        // offsetof: -1
        public int TexWidth;
        // offsetof: -1
        public int TexHeight;
        // offsetof: -1
        public ImVec2 TexUvScale;
        // offsetof: -1
        public ImVec2 TexUvWhitePixel;
        // offsetof: -1
        public ImVector Fonts;
        // offsetof: -1
        public ImVector CustomRects;
        // offsetof: -1
        public ImVector ConfigData;
        // offsetof: -1
        public IntPtr CustomRectIds;
    }
}