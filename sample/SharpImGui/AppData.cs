// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // im3d.h:448
    
    public struct AppData
    {
        // offsetof: 0
        public IntPtr m_keyDown;
        // offsetof: 8
        public IntPtr m_cullFrustum;
        // offsetof: 104
        public Vec3 m_cursorRayOrigin;
        // offsetof: 116
        public Vec3 m_cursorRayDirection;
        // offsetof: 128
        public Vec3 m_worldUp;
        // offsetof: 140
        public Vec3 m_viewOrigin;
        // offsetof: 152
        public Vec3 m_viewDirection;
        // offsetof: 164
        public Vector2 m_viewportSize;
        // offsetof: 172
        public float m_projScaleY;
        // offsetof: 176
        [MarshalAs(UnmanagedType.U1)]public bool m_projOrtho;
        // offsetof: 180
        public float m_deltaTime;
        // offsetof: 184
        public float m_snapTranslation;
        // offsetof: 188
        public float m_snapRotation;
        // offsetof: 192
        public float m_snapScale;
        // offsetof: 200
        public IntPtr m_appData;
        // offsetof: 208
        public IntPtr drawCallback;
    }
}