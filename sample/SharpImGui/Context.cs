// // generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    // im3d.h:571
    
    public struct Context
    {
        // offsetof: 0
        [MarshalAs(UnmanagedType.U1)]public bool m_gizmoLocal;
        // offsetof: 4
        public GizmoMode m_gizmoMode;
        // offsetof: 8
        public Id m_activeId;
        // offsetof: 12
        public Id m_hotId;
        // offsetof: 16
        public Id m_appId;
        // offsetof: 20
        public Id m_appActiveId;
        // offsetof: 24
        public Id m_appHotId;
        // offsetof: 28
        public float m_hotDepth;
        // offsetof: 32
        public Vec3 m_gizmoStateVec3;
        // offsetof: 44
        public Mat3 m_gizmoStateMat3;
        // offsetof: 80
        public float m_gizmoStateFloat;
        // offsetof: 84
        public float m_gizmoHeightPixels;
        // offsetof: 88
        public float m_gizmoSizePixels;
        // offsetof: 96
        public Vector m_colorStack;
        // offsetof: 112
        public Vector m_alphaStack;
        // offsetof: 128
        public Vector m_sizeStack;
        // offsetof: 144
        public Vector m_enableSortingStack;
        // offsetof: 160
        public Vector m_matrixStack;
        // offsetof: 176
        public Vector m_idStack;
        // offsetof: 192
        public Vector m_layerIdStack;
        // offsetof: 208
        public IntPtr m_vertexData;
        // offsetof: 240
        public int m_vertexDataIndex;
        // offsetof: 248
        public Vector m_layerIdMap;
        // offsetof: 264
        public int m_layerIndex;
        // offsetof: 272
        public Vector m_drawLists;
        // offsetof: 288
        [MarshalAs(UnmanagedType.U1)]public bool m_sortCalled;
        // offsetof: 289
        [MarshalAs(UnmanagedType.U1)]public bool m_endFrameCalled;
        // offsetof: 292
        public PrimitiveMode m_primMode;
        // offsetof: 296
        public DrawPrimitiveType m_primType;
        // offsetof: 300
        public U32 m_firstVertThisPrim;
        // offsetof: 304
        public U32 m_vertCountThisPrim;
        // offsetof: 308
        public Vec3 m_minVertThisPrim;
        // offsetof: 320
        public Vec3 m_maxVertThisPrim;
        // offsetof: 336
        public AppData m_appData;
        // offsetof: 552
        public IntPtr m_keyDownCurr;
        // offsetof: 557
        public IntPtr m_keyDownPrev;
        // offsetof: 564
        public IntPtr m_cullFrustum;
        // offsetof: 660
        public int m_cullFrustumCount;
    }
}