# SharpImGui

DllImport for imgui.dll (without extern "C")

Resovle name manging by clang.cindex

```cs
// imgui.h:260
[DllImport(DLLNAME, EntryPoint="?Begin@ImGui@@YA_NPEBDPEA_NH@Z")]
[return: MarshalAs(UnmanagedType.U1)]
public static extern bool Begin([MarshalAs(UnmanagedType.LPUTF8Str)]string name, [MarshalAs(UnmanagedType.U1)]ref bool p_open, ImGuiWindowFlags flags = 0);
```
