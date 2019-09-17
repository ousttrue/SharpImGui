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
            get => (ImGuiConfigFlags)Marshal.ReadInt32(IntPtr.Add(m_p, -1));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, -1), (int)value);
        }
        public ImGuiBackendFlags BackendFlags
        {
            get => (ImGuiBackendFlags)Marshal.ReadInt32(IntPtr.Add(m_p, -1));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, -1), (int)value);
        }
    }
}