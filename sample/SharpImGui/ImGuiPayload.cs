// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // imgui.h:1607
    
    public struct ImGuiPayload
    {
        // offsetof: 0
        public IntPtr Data;
        // offsetof: 8
        public int DataSize;
        // offsetof: 12
        public ImGuiID SourceId;
        // offsetof: 16
        public ImGuiID SourceParentId;
        // offsetof: 20
        public int DataFrameCount;
        // offsetof: 24
        public IntPtr DataType;
        // offsetof: 57
        [MarshalAs(UnmanagedType.U1)]public bool Preview;
        // offsetof: 58
        [MarshalAs(UnmanagedType.U1)]public bool Delivery;
    }
}