// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    // imgui.h:1555
    
    public struct ImGuiInputTextCallbackData
    {
        // offsetof: 0
        public ImGuiInputTextFlags EventFlag;
        // offsetof: 4
        public ImGuiInputTextFlags Flags;
        // offsetof: 8
        public IntPtr UserData;
        // offsetof: 16
        public ImWchar EventChar;
        // offsetof: 20
        public ImGuiKey EventKey;
        // offsetof: 24
        public IntPtr Buf;
        // offsetof: 32
        public int BufTextLen;
        // offsetof: 36
        public int BufSize;
        // offsetof: 40
        [MarshalAs(UnmanagedType.U1)]public bool BufDirty;
        // offsetof: 44
        public int CursorPos;
        // offsetof: 48
        public int SelectionStart;
        // offsetof: 52
        public int SelectionEnd;
    }
}