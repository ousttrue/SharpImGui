using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    public static class CImGuiImpl
    {
        const string DllName = "cimgui.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(IntPtr shared_font_atlas);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);
    }

    public class Wrapper : IDisposable
    {
        IntPtr m_ptr;

        public void Dispose()
        {
            if (m_ptr != IntPtr.Zero)
            {
                CImGuiImpl.igDestroyContext(m_ptr);
                m_ptr = IntPtr.Zero;
            }
        }

        public Wrapper()
        {
            m_ptr = CImGuiImpl.igCreateContext(IntPtr.Zero);
        }
    }
}