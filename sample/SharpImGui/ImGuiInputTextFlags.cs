// generated cpptypeinfo-0.2.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:793
    [Flags]
    public enum ImGuiInputTextFlags
    {
        None = 0,
        CharsDecimal = 1,
        CharsHexadecimal = 2,
        CharsUppercase = 4,
        CharsNoBlank = 8,
        AutoSelectAll = 16,
        EnterReturnsTrue = 32,
        CallbackCompletion = 64,
        CallbackHistory = 128,
        CallbackAlways = 256,
        CallbackCharFilter = 512,
        AllowTabInput = 1024,
        CtrlEnterForNewLine = 2048,
        NoHorizontalScroll = 4096,
        AlwaysInsertMode = 8192,
        ReadOnly = 16384,
        Password = 32768,
        NoUndoRedo = 65536,
        CharsScientific = 131072,
        CallbackResize = 262144,
        Multiline = 1048576,
        NoMarkEdited = 2097152,
    }
}