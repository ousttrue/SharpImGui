// generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    public struct ImGuiIO
    {
        public static implicit operator ImGuiIO(IntPtr p)
        {
            return new ImGuiIO(p);
        }

        readonly IntPtr m_p;

        public ImGuiIO(IntPtr ptr)
        {
            m_p = ptr;
        }
        public ImGuiConfigFlags ConfigFlags
        {
            get => (ImGuiConfigFlags)Marshal.ReadInt32(IntPtr.Add(m_p, 0));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 0), (int)value);
        }
        public ImGuiBackendFlags BackendFlags
        {
            get => (ImGuiBackendFlags)Marshal.ReadInt32(IntPtr.Add(m_p, 4));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 4), (int)value);
        }
        public float DeltaTime
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 16)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 16), BitConverter.SingleToInt32Bits(value));
        }
        public float IniSavingRate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 20)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 20), BitConverter.SingleToInt32Bits(value));
        }
        public float MouseDoubleClickTime
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 40)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 40), BitConverter.SingleToInt32Bits(value));
        }
        public float MouseDoubleClickMaxDist
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 44)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 44), BitConverter.SingleToInt32Bits(value));
        }
        public float MouseDragThreshold
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 48)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 48), BitConverter.SingleToInt32Bits(value));
        }
        public float KeyRepeatDelay
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 140)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 140), BitConverter.SingleToInt32Bits(value));
        }
        public float KeyRepeatRate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 144)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 144), BitConverter.SingleToInt32Bits(value));
        }
        public float FontGlobalScale
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 168)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 168), BitConverter.SingleToInt32Bits(value));
        }
        public float ConfigWindowsMemoryCompactTimer
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 208)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 208), BitConverter.SingleToInt32Bits(value));
        }
        public float MouseWheel
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 304)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 304), BitConverter.SingleToInt32Bits(value));
        }
        public float MouseWheelH
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 308)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 308), BitConverter.SingleToInt32Bits(value));
        }
        public float Framerate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 928)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 928), BitConverter.SingleToInt32Bits(value));
        }
        public int MetricsRenderVertices
        {
            get => (int)Marshal.ReadInt32(IntPtr.Add(m_p, 932));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 932), (int)value);
        }
        public int MetricsRenderIndices
        {
            get => (int)Marshal.ReadInt32(IntPtr.Add(m_p, 936));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 936), (int)value);
        }
        public int MetricsRenderWindows
        {
            get => (int)Marshal.ReadInt32(IntPtr.Add(m_p, 940));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 940), (int)value);
        }
        public int MetricsActiveWindows
        {
            get => (int)Marshal.ReadInt32(IntPtr.Add(m_p, 944));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 944), (int)value);
        }
        public int MetricsActiveAllocations
        {
            get => (int)Marshal.ReadInt32(IntPtr.Add(m_p, 948));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 948), (int)value);
        }
    }
}