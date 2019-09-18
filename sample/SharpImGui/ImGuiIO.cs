// generated cpptypeinfo-0.1.0
using System;
using System.Runtime.InteropServices;
using System.Numerics;


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
        // offsetof: 0
        public ImGuiConfigFlags ConfigFlags
        {
            get => (ImGuiConfigFlags)(Marshal.ReadInt32(IntPtr.Add(m_p, 0)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 0), (int)value);
        }
        // offsetof: 4
        public ImGuiBackendFlags BackendFlags
        {
            get => (ImGuiBackendFlags)(Marshal.ReadInt32(IntPtr.Add(m_p, 4)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 4), (int)value);
        }
        // offsetof: 16
        public float DeltaTime
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 16)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 16), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 20
        public float IniSavingRate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 20)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 20), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 24
        public IntPtr IniFilename
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 24)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 24), value.ToInt64());
        }
        // offsetof: 32
        public IntPtr LogFilename
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 32)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 32), value.ToInt64());
        }
        // offsetof: 40
        public float MouseDoubleClickTime
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 40)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 40), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 44
        public float MouseDoubleClickMaxDist
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 44)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 44), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 48
        public float MouseDragThreshold
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 48)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 48), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 52
        public IntPtr KeyMap
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 52)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 52), value.ToInt64());
        }
        // offsetof: 140
        public float KeyRepeatDelay
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 140)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 140), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 144
        public float KeyRepeatRate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 144)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 144), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 152
        public IntPtr UserData
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 152)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 152), value.ToInt64());
        }
        // offsetof: 160
        public IntPtr Fonts
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 160)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 160), value.ToInt64());
        }
        // offsetof: 168
        public float FontGlobalScale
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 168)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 168), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 176
        public IntPtr FontDefault
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 176)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 176), value.ToInt64());
        }
        // offsetof: 208
        public float ConfigWindowsMemoryCompactTimer
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 208)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 208), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 216
        public IntPtr BackendPlatformName
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 216)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 216), value.ToInt64());
        }
        // offsetof: 224
        public IntPtr BackendRendererName
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 224)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 224), value.ToInt64());
        }
        // offsetof: 232
        public IntPtr BackendPlatformUserData
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 232)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 232), value.ToInt64());
        }
        // offsetof: 240
        public IntPtr BackendRendererUserData
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 240)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 240), value.ToInt64());
        }
        // offsetof: 248
        public IntPtr BackendLanguageUserData
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 248)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 248), value.ToInt64());
        }
        // offsetof: 272
        public IntPtr ClipboardUserData
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 272)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 272), value.ToInt64());
        }
        // offsetof: 296
        public IntPtr MouseDown
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 296)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 296), value.ToInt64());
        }
        // offsetof: 304
        public float MouseWheel
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 304)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 304), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 308
        public float MouseWheelH
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 308)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 308), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 320
        public IntPtr KeysDown
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 320)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 320), value.ToInt64());
        }
        // offsetof: 832
        public IntPtr NavInputs
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 832)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 832), value.ToInt64());
        }
        // offsetof: 928
        public float Framerate
        {
            get => BitConverter.Int32BitsToSingle(Marshal.ReadInt32(IntPtr.Add(m_p, 928)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 928), BitConverter.SingleToInt32Bits(value));
        }
        // offsetof: 932
        public int MetricsRenderVertices
        {
            get => (Marshal.ReadInt32(IntPtr.Add(m_p, 932)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 932), value);
        }
        // offsetof: 936
        public int MetricsRenderIndices
        {
            get => (Marshal.ReadInt32(IntPtr.Add(m_p, 936)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 936), value);
        }
        // offsetof: 940
        public int MetricsRenderWindows
        {
            get => (Marshal.ReadInt32(IntPtr.Add(m_p, 940)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 940), value);
        }
        // offsetof: 944
        public int MetricsActiveWindows
        {
            get => (Marshal.ReadInt32(IntPtr.Add(m_p, 944)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 944), value);
        }
        // offsetof: 948
        public int MetricsActiveAllocations
        {
            get => (Marshal.ReadInt32(IntPtr.Add(m_p, 948)));
            set => Marshal.WriteInt32(IntPtr.Add(m_p, 948), value);
        }
        // offsetof: 968
        public IntPtr MouseClickedPos
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 968)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 968), value.ToInt64());
        }
        // offsetof: 1008
        public IntPtr MouseClickedTime
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1008)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1008), value.ToInt64());
        }
        // offsetof: 1048
        public IntPtr MouseClicked
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1048)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1048), value.ToInt64());
        }
        // offsetof: 1053
        public IntPtr MouseDoubleClicked
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1053)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1053), value.ToInt64());
        }
        // offsetof: 1058
        public IntPtr MouseReleased
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1058)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1058), value.ToInt64());
        }
        // offsetof: 1063
        public IntPtr MouseDownOwned
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1063)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1063), value.ToInt64());
        }
        // offsetof: 1068
        public IntPtr MouseDownWasDoubleClick
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1068)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1068), value.ToInt64());
        }
        // offsetof: 1076
        public IntPtr MouseDownDuration
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1076)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1076), value.ToInt64());
        }
        // offsetof: 1096
        public IntPtr MouseDownDurationPrev
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1096)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1096), value.ToInt64());
        }
        // offsetof: 1116
        public IntPtr MouseDragMaxDistanceAbs
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1116)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1116), value.ToInt64());
        }
        // offsetof: 1156
        public IntPtr MouseDragMaxDistanceSqr
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1156)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1156), value.ToInt64());
        }
        // offsetof: 1176
        public IntPtr KeysDownDuration
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 1176)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 1176), value.ToInt64());
        }
        // offsetof: 3224
        public IntPtr KeysDownDurationPrev
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 3224)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 3224), value.ToInt64());
        }
        // offsetof: 5272
        public IntPtr NavInputsDownDuration
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 5272)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 5272), value.ToInt64());
        }
        // offsetof: 5360
        public IntPtr NavInputsDownDurationPrev
        {
            get => new IntPtr(Marshal.ReadInt64(IntPtr.Add(m_p, 5360)));
            set => Marshal.WriteInt64(IntPtr.Add(m_p, 5360), value.ToInt64());
        }
    }
}