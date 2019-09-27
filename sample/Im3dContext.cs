using System;
using SharpImGui;

namespace sample
{
    class Im3dContext : IDisposable
    {
        IntPtr m_context;
        public Im3dContext()
        {
            m_context = Im3d.NewContext();
        }

        public void Dispose()
        {
            if (m_context != IntPtr.Zero)
            {
                Im3d.DestoryContext(m_context);
                m_context = IntPtr.Zero;
            }
        }

        public void Set()
        {
            Im3d.SetContext(m_context);
        }
    }
}
