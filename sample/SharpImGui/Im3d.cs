// generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


namespace SharpImGui
{
    public static class Im3d
    {
        const string DLLNAME = "imgui.dll";

        // im3d_newframe.h:6
        [DllImport(DLLNAME, EntryPoint="?Im3dGui_NewFrame@@YAXPEBUCameraState@camera@@PEBUMouseState@@MM@Z")]
        public static extern void Im3dGui_NewFrame(ref CameraState camera, ref MouseState mouse, float deltaTime, float rayZValue);

        // im3d_impl_dx11.h:14
        [DllImport(DLLNAME, EntryPoint="?Im3d_DX11_Draw@@YAXPEAXPEBMHHPEBUDrawList@Im3d@@H@Z")]
        public static extern void Im3d_DX11_Draw(IntPtr deviceContext, ref float viewProjection, int w, int h, IntPtr drawList, int count);

        // im3d_impl_dx11.h:15
        [DllImport(DLLNAME, EntryPoint="?Im3d_DX11_Initialize@@YA_NXZ")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Im3d_DX11_Initialize();

        // im3d_impl_dx11.h:16
        [DllImport(DLLNAME, EntryPoint="?Im3d_DX11_Finalize@@YAXXZ")]
        public static extern void Im3d_DX11_Finalize();

        // im3d.h:37
        [DllImport(DLLNAME, EntryPoint="?GetAppData@Im3d@@YAAEAUAppData@1@XZ")]
        public static extern IntPtr GetAppData();

        // im3d.h:40
        [DllImport(DLLNAME, EntryPoint="?NewFrame@Im3d@@YAXXZ")]
        public static extern void NewFrame();

        // im3d.h:42
        [DllImport(DLLNAME, EntryPoint="?EndFrame@Im3d@@YAXXZ")]
        public static extern void EndFrame();

        // im3d.h:45
        [DllImport(DLLNAME, EntryPoint="?GetDrawLists@Im3d@@YAPEBUDrawList@1@XZ")]
        public static extern IntPtr GetDrawLists();

        // im3d.h:46
        [DllImport(DLLNAME, EntryPoint="?GetDrawListCount@Im3d@@YAIXZ")]
        public static extern U32 GetDrawListCount();

        // im3d.h:50
        [DllImport(DLLNAME, EntryPoint="?Draw@Im3d@@YAXXZ")]
        public static extern void Draw();

        // im3d.h:53
        [DllImport(DLLNAME, EntryPoint="?BeginPoints@Im3d@@YAXXZ")]
        public static extern void BeginPoints();

        // im3d.h:54
        [DllImport(DLLNAME, EntryPoint="?BeginLines@Im3d@@YAXXZ")]
        public static extern void BeginLines();

        // im3d.h:55
        [DllImport(DLLNAME, EntryPoint="?BeginLineLoop@Im3d@@YAXXZ")]
        public static extern void BeginLineLoop();

        // im3d.h:56
        [DllImport(DLLNAME, EntryPoint="?BeginLineStrip@Im3d@@YAXXZ")]
        public static extern void BeginLineStrip();

        // im3d.h:57
        [DllImport(DLLNAME, EntryPoint="?BeginTriangles@Im3d@@YAXXZ")]
        public static extern void BeginTriangles();

        // im3d.h:58
        [DllImport(DLLNAME, EntryPoint="?BeginTriangleStrip@Im3d@@YAXXZ")]
        public static extern void BeginTriangleStrip();

        // im3d.h:59
        [DllImport(DLLNAME, EntryPoint="?End@Im3d@@YAXXZ")]
        public static extern void End();

        // im3d.h:62
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXAEBUVec3@1@@Z")]
        public static extern void Vertex(IntPtr _position);

        // im3d.h:63
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXAEBUVec3@1@UColor@1@@Z")]
        public static extern void Vertex(IntPtr _position, Color _color);

        // im3d.h:64
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXAEBUVec3@1@M@Z")]
        public static extern void Vertex(IntPtr _position, float _size);

        // im3d.h:65
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXAEBUVec3@1@MUColor@1@@Z")]
        public static extern void Vertex(IntPtr _position, float _size, Color _color);

        // im3d.h:66
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXMMM@Z")]
        public static extern void Vertex(float _x, float _y, float _z);

        // im3d.h:67
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXMMMUColor@1@@Z")]
        public static extern void Vertex(float _x, float _y, float _z, Color _color);

        // im3d.h:68
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXMMMM@Z")]
        public static extern void Vertex(float _x, float _y, float _z, float _size);

        // im3d.h:69
        [DllImport(DLLNAME, EntryPoint="?Vertex@Im3d@@YAXMMMMUColor@1@@Z")]
        public static extern void Vertex(float _x, float _y, float _z, float _size, Color _color);

        // im3d.h:72
        [DllImport(DLLNAME, EntryPoint="?PushColor@Im3d@@YAXXZ")]
        public static extern void PushColor();

        // im3d.h:73
        [DllImport(DLLNAME, EntryPoint="?PushColor@Im3d@@YAXUColor@1@@Z")]
        public static extern void PushColor(Color _color);

        // im3d.h:74
        [DllImport(DLLNAME, EntryPoint="?PopColor@Im3d@@YAXXZ")]
        public static extern void PopColor();

        // im3d.h:75
        [DllImport(DLLNAME, EntryPoint="?SetColor@Im3d@@YAXUColor@1@@Z")]
        public static extern void SetColor(Color _color);

        // im3d.h:76
        [DllImport(DLLNAME, EntryPoint="?SetColor@Im3d@@YAXMMMM@Z")]
        public static extern void SetColor(float _r, float _g, float _b, float _a = 1.0f);

        // im3d.h:77
        [DllImport(DLLNAME, EntryPoint="?GetColor@Im3d@@YA?AUColor@1@XZ")]
        public static extern Color GetColor();

        // im3d.h:80
        [DllImport(DLLNAME, EntryPoint="?PushAlpha@Im3d@@YAXXZ")]
        public static extern void PushAlpha();

        // im3d.h:81
        [DllImport(DLLNAME, EntryPoint="?PushAlpha@Im3d@@YAXM@Z")]
        public static extern void PushAlpha(float _alpha);

        // im3d.h:82
        [DllImport(DLLNAME, EntryPoint="?PopAlpha@Im3d@@YAXXZ")]
        public static extern void PopAlpha();

        // im3d.h:83
        [DllImport(DLLNAME, EntryPoint="?SetAlpha@Im3d@@YAXM@Z")]
        public static extern void SetAlpha(float _alpha);

        // im3d.h:84
        [DllImport(DLLNAME, EntryPoint="?GetAlpha@Im3d@@YAMXZ")]
        public static extern float GetAlpha();

        // im3d.h:87
        [DllImport(DLLNAME, EntryPoint="?PushSize@Im3d@@YAXXZ")]
        public static extern void PushSize();

        // im3d.h:88
        [DllImport(DLLNAME, EntryPoint="?PushSize@Im3d@@YAXM@Z")]
        public static extern void PushSize(float _size);

        // im3d.h:89
        [DllImport(DLLNAME, EntryPoint="?PopSize@Im3d@@YAXXZ")]
        public static extern void PopSize();

        // im3d.h:90
        [DllImport(DLLNAME, EntryPoint="?SetSize@Im3d@@YAXM@Z")]
        public static extern void SetSize(float _size);

        // im3d.h:91
        [DllImport(DLLNAME, EntryPoint="?GetSize@Im3d@@YAMXZ")]
        public static extern float GetSize();

        // im3d.h:94
        [DllImport(DLLNAME, EntryPoint="?PushEnableSorting@Im3d@@YAXXZ")]
        public static extern void PushEnableSorting();

        // im3d.h:95
        [DllImport(DLLNAME, EntryPoint="?PushEnableSorting@Im3d@@YAX_N@Z")]
        public static extern void PushEnableSorting([MarshalAs(UnmanagedType.U1)]bool _enable);

        // im3d.h:96
        [DllImport(DLLNAME, EntryPoint="?PopEnableSorting@Im3d@@YAXXZ")]
        public static extern void PopEnableSorting();

        // im3d.h:97
        [DllImport(DLLNAME, EntryPoint="?EnableSorting@Im3d@@YAX_N@Z")]
        public static extern void EnableSorting([MarshalAs(UnmanagedType.U1)]bool _enable);

        // im3d.h:100
        [DllImport(DLLNAME, EntryPoint="?PushDrawState@Im3d@@YAXXZ")]
        public static extern void PushDrawState();

        // im3d.h:101
        [DllImport(DLLNAME, EntryPoint="?PopDrawState@Im3d@@YAXXZ")]
        public static extern void PopDrawState();

        // im3d.h:104
        [DllImport(DLLNAME, EntryPoint="?PushMatrix@Im3d@@YAXXZ")]
        public static extern void PushMatrix();

        // im3d.h:105
        [DllImport(DLLNAME, EntryPoint="?PushMatrix@Im3d@@YAXAEBUMat4@1@@Z")]
        public static extern void PushMatrix(IntPtr _mat4);

        // im3d.h:106
        [DllImport(DLLNAME, EntryPoint="?PopMatrix@Im3d@@YAXXZ")]
        public static extern void PopMatrix();

        // im3d.h:107
        [DllImport(DLLNAME, EntryPoint="?SetMatrix@Im3d@@YAXAEBUMat4@1@@Z")]
        public static extern void SetMatrix(IntPtr _mat4);

        // im3d.h:108
        [DllImport(DLLNAME, EntryPoint="?SetIdentity@Im3d@@YAXXZ")]
        public static extern void SetIdentity();

        // im3d.h:109
        [DllImport(DLLNAME, EntryPoint="?MulMatrix@Im3d@@YAXAEBUMat4@1@@Z")]
        public static extern void MulMatrix(IntPtr _mat4);

        // im3d.h:110
        [DllImport(DLLNAME, EntryPoint="?Translate@Im3d@@YAXMMM@Z")]
        public static extern void Translate(float _x, float _y, float _z);

        // im3d.h:111
        [DllImport(DLLNAME, EntryPoint="?Translate@Im3d@@YAXAEBUVec3@1@@Z")]
        public static extern void Translate(IntPtr _vec3);

        // im3d.h:112
        [DllImport(DLLNAME, EntryPoint="?Rotate@Im3d@@YAXAEBUVec3@1@M@Z")]
        public static extern void Rotate(IntPtr _axis, float _angle);

        // im3d.h:113
        [DllImport(DLLNAME, EntryPoint="?Rotate@Im3d@@YAXAEBUMat3@1@@Z")]
        public static extern void Rotate(IntPtr _rotation);

        // im3d.h:114
        [DllImport(DLLNAME, EntryPoint="?Scale@Im3d@@YAXMMM@Z")]
        public static extern void Scale(float _x, float _y, float _z);

        // im3d.h:117
        [DllImport(DLLNAME, EntryPoint="?DrawXyzAxes@Im3d@@YAXXZ")]
        public static extern void DrawXyzAxes();

        // im3d.h:118
        [DllImport(DLLNAME, EntryPoint="?DrawPoint@Im3d@@YAXAEBUVec3@1@MUColor@1@@Z")]
        public static extern void DrawPoint(IntPtr _position, float _size, Color _color);

        // im3d.h:119
        [DllImport(DLLNAME, EntryPoint="?DrawLine@Im3d@@YAXAEBUVec3@1@0MUColor@1@@Z")]
        public static extern void DrawLine(IntPtr _a, IntPtr _b, float _size, Color _color);

        // im3d.h:120
        [DllImport(DLLNAME, EntryPoint="?DrawQuad@Im3d@@YAXAEBUVec3@1@000@Z")]
        public static extern void DrawQuad(IntPtr _a, IntPtr _b, IntPtr _c, IntPtr _d);

        // im3d.h:121
        [DllImport(DLLNAME, EntryPoint="?DrawQuad@Im3d@@YAXAEBUVec3@1@0AEBUVec2@1@@Z")]
        public static extern void DrawQuad(IntPtr _origin, IntPtr _normal, ref Vector2 _size);

        // im3d.h:122
        [DllImport(DLLNAME, EntryPoint="?DrawQuadFilled@Im3d@@YAXAEBUVec3@1@000@Z")]
        public static extern void DrawQuadFilled(IntPtr _a, IntPtr _b, IntPtr _c, IntPtr _d);

        // im3d.h:123
        [DllImport(DLLNAME, EntryPoint="?DrawQuadFilled@Im3d@@YAXAEBUVec3@1@0AEBUVec2@1@@Z")]
        public static extern void DrawQuadFilled(IntPtr _origin, IntPtr _normal, ref Vector2 _size);

        // im3d.h:124
        [DllImport(DLLNAME, EntryPoint="?DrawCircle@Im3d@@YAXAEBUVec3@1@0MH@Z")]
        public static extern void DrawCircle(IntPtr _origin, IntPtr _normal, float _radius, int _detail = -1);

        // im3d.h:125
        [DllImport(DLLNAME, EntryPoint="?DrawCircleFilled@Im3d@@YAXAEBUVec3@1@0MH@Z")]
        public static extern void DrawCircleFilled(IntPtr _origin, IntPtr _normal, float _radius, int _detail = -1);

        // im3d.h:126
        [DllImport(DLLNAME, EntryPoint="?DrawSphere@Im3d@@YAXAEBUVec3@1@MH@Z")]
        public static extern void DrawSphere(IntPtr _origin, float _radius, int _detail = -1);

        // im3d.h:127
        [DllImport(DLLNAME, EntryPoint="?DrawSphereFilled@Im3d@@YAXAEBUVec3@1@MH@Z")]
        public static extern void DrawSphereFilled(IntPtr _origin, float _radius, int _detail = -1);

        // im3d.h:128
        [DllImport(DLLNAME, EntryPoint="?DrawAlignedBox@Im3d@@YAXAEBUVec3@1@0@Z")]
        public static extern void DrawAlignedBox(IntPtr _min, IntPtr _max);

        // im3d.h:129
        [DllImport(DLLNAME, EntryPoint="?DrawAlignedBoxFilled@Im3d@@YAXAEBUVec3@1@0@Z")]
        public static extern void DrawAlignedBoxFilled(IntPtr _min, IntPtr _max);

        // im3d.h:130
        [DllImport(DLLNAME, EntryPoint="?DrawCylinder@Im3d@@YAXAEBUVec3@1@0MH@Z")]
        public static extern void DrawCylinder(IntPtr _start, IntPtr _end, float _radius, int _detail = -1);

        // im3d.h:131
        [DllImport(DLLNAME, EntryPoint="?DrawCapsule@Im3d@@YAXAEBUVec3@1@0MH@Z")]
        public static extern void DrawCapsule(IntPtr _start, IntPtr _end, float _radius, int _detail = -1);

        // im3d.h:132
        [DllImport(DLLNAME, EntryPoint="?DrawPrism@Im3d@@YAXAEBUVec3@1@0MH@Z")]
        public static extern void DrawPrism(IntPtr _start, IntPtr _end, float _radius, int _sides);

        // im3d.h:133
        [DllImport(DLLNAME, EntryPoint="?DrawArrow@Im3d@@YAXAEBUVec3@1@0MM@Z")]
        public static extern void DrawArrow(IntPtr _start, IntPtr _end, float _headLength = -1.0f, float _headThickness = -1.0f);

        // im3d.h:137
        [DllImport(DLLNAME, EntryPoint="?MakeId@Im3d@@YAIPEBD@Z")]
        public static extern Id MakeId([MarshalAs(UnmanagedType.LPUTF8Str)]string _str);

        // im3d.h:138
        [DllImport(DLLNAME, EntryPoint="?MakeId@Im3d@@YAIPEBX@Z")]
        public static extern Id MakeId(IntPtr _ptr);

        // im3d.h:139
        [DllImport(DLLNAME, EntryPoint="?MakeId@Im3d@@YAIH@Z")]
        public static extern Id MakeId(int _i);

        // im3d.h:142
        [DllImport(DLLNAME, EntryPoint="?PushId@Im3d@@YAXXZ")]
        public static extern void PushId();

        // im3d.h:143
        [DllImport(DLLNAME, EntryPoint="?PushId@Im3d@@YAXI@Z")]
        public static extern void PushId(Id _id);

        // im3d.h:144
        [DllImport(DLLNAME, EntryPoint="?PushId@Im3d@@YAXPEBD@Z")]
        public static extern void PushId([MarshalAs(UnmanagedType.LPUTF8Str)]string _str);

        // im3d.h:145
        [DllImport(DLLNAME, EntryPoint="?PushId@Im3d@@YAXPEBX@Z")]
        public static extern void PushId(IntPtr _ptr);

        // im3d.h:146
        [DllImport(DLLNAME, EntryPoint="?PushId@Im3d@@YAXH@Z")]
        public static extern void PushId(int _i);

        // im3d.h:147
        [DllImport(DLLNAME, EntryPoint="?PopId@Im3d@@YAXXZ")]
        public static extern void PopId();

        // im3d.h:148
        [DllImport(DLLNAME, EntryPoint="?GetId@Im3d@@YAIXZ")]
        public static extern Id GetId();

        // im3d.h:149
        [DllImport(DLLNAME, EntryPoint="?GetActiveId@Im3d@@YAIXZ")]
        public static extern Id GetActiveId();

        // im3d.h:150
        [DllImport(DLLNAME, EntryPoint="?GetHotId@Im3d@@YAIXZ")]
        public static extern Id GetHotId();

        // im3d.h:153
        [DllImport(DLLNAME, EntryPoint="?PushLayerId@Im3d@@YAXI@Z")]
        public static extern void PushLayerId(Id _layer);

        // im3d.h:154
        [DllImport(DLLNAME, EntryPoint="?PushLayerId@Im3d@@YAXPEBD@Z")]
        public static extern void PushLayerId([MarshalAs(UnmanagedType.LPUTF8Str)]string _str);

        // im3d.h:155
        [DllImport(DLLNAME, EntryPoint="?PopLayerId@Im3d@@YAXXZ")]
        public static extern void PopLayerId();

        // im3d.h:156
        [DllImport(DLLNAME, EntryPoint="?GetLayerId@Im3d@@YAIXZ")]
        public static extern Id GetLayerId();

        // im3d.h:161
        [DllImport(DLLNAME, EntryPoint="?GizmoTranslation@Im3d@@YA_NPEBDQEAM_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoTranslation([MarshalAs(UnmanagedType.LPUTF8Str)]string _id, ref float _translation_, [MarshalAs(UnmanagedType.U1)]bool _local = default);

        // im3d.h:162
        [DllImport(DLLNAME, EntryPoint="?GizmoRotation@Im3d@@YA_NPEBDQEAM_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoRotation([MarshalAs(UnmanagedType.LPUTF8Str)]string _id, ref float _rotation_, [MarshalAs(UnmanagedType.U1)]bool _local = default);

        // im3d.h:163
        [DllImport(DLLNAME, EntryPoint="?GizmoScale@Im3d@@YA_NPEBDQEAM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoScale([MarshalAs(UnmanagedType.LPUTF8Str)]string _id, ref float _scale_);

        // im3d.h:165
        [DllImport(DLLNAME, EntryPoint="?Gizmo@Im3d@@YA_NPEBDQEAM11@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Gizmo([MarshalAs(UnmanagedType.LPUTF8Str)]string _id, ref float _translation_, ref float _rotation_, ref float _scale_);

        // im3d.h:166
        [DllImport(DLLNAME, EntryPoint="?Gizmo@Im3d@@YA_NPEBDQEAM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Gizmo([MarshalAs(UnmanagedType.LPUTF8Str)]string _id, ref float _transform_);

        // im3d.h:169
        [DllImport(DLLNAME, EntryPoint="?GizmoTranslation@Im3d@@YA_NIQEAM_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoTranslation(Id _id, ref float _translation_, [MarshalAs(UnmanagedType.U1)]bool _local = default);

        // im3d.h:170
        [DllImport(DLLNAME, EntryPoint="?GizmoRotation@Im3d@@YA_NIQEAM_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoRotation(Id _id, ref float _rotation_, [MarshalAs(UnmanagedType.U1)]bool _local = default);

        // im3d.h:171
        [DllImport(DLLNAME, EntryPoint="?GizmoScale@Im3d@@YA_NIQEAM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool GizmoScale(Id _id, ref float _scale_);

        // im3d.h:172
        [DllImport(DLLNAME, EntryPoint="?Gizmo@Im3d@@YA_NIQEAM@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Gizmo(Id _id, ref float _transform_);

        // im3d.h:173
        [DllImport(DLLNAME, EntryPoint="?Gizmo@Im3d@@YA_NIQEAM00@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Gizmo(Id _id, ref float _translation_, ref float _rotation_, ref float _scale_);

        // im3d.h:176
        [DllImport(DLLNAME, EntryPoint="?IsVisible@Im3d@@YA_NAEBUVec3@1@M@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsVisible(IntPtr _origin, float _radius);

        // im3d.h:177
        [DllImport(DLLNAME, EntryPoint="?IsVisible@Im3d@@YA_NAEBUVec3@1@0@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsVisible(IntPtr _min, IntPtr _max);

        // im3d.h:180
        [DllImport(DLLNAME, EntryPoint="?GetContext@Im3d@@YAAEAVContext@1@XZ")]
        public static extern IntPtr GetContext();

        // im3d.h:181
        [DllImport(DLLNAME, EntryPoint="?SetContext@Im3d@@YAXAEAVContext@1@@Z")]
        public static extern void SetContext(IntPtr _ctx);

        // im3d.h:182
        [DllImport(DLLNAME, EntryPoint="?NewContext@Im3d@@YAPEAVContext@1@XZ")]
        public static extern IntPtr NewContext();

        // im3d.h:183
        [DllImport(DLLNAME, EntryPoint="?DestoryContext@Im3d@@YAXPEAVContext@1@@Z")]
        public static extern void DestoryContext(IntPtr c);

        // im3d.h:186
        [DllImport(DLLNAME, EntryPoint="?MergeContexts@Im3d@@YAXAEAVContext@1@AEBV21@@Z")]
        public static extern void MergeContexts(IntPtr _dst_, IntPtr _src);
    }
}