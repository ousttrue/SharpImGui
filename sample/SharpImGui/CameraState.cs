// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // camera_state.h:68
    
    public struct CameraState
    {
        // offsetof: 0
        public float fovYRadians;
        // offsetof: 4
        public Matrix4x4 projection;
        // offsetof: 68
        public float viewportWidth;
        // offsetof: 72
        public float viewportHeight;
        // offsetof: 76
        public Matrix4x4 view;
        // offsetof: 140
        public Matrix4x4 viewInverse;
        // offsetof: 204
        public Matrix4x4 viewProjection;
    }
}