using System;
using System.Numerics;
using SharpDX.Direct3D11;
using SharpImGui;

namespace sample
{
    /// <summary>
    /// Scene, Camera, Gizmo
    /// </summary>
    public class ImGuiSceneView : IDisposable
    {
        public void Dispose()
        {
            m_im3d.Dispose();
            m_im3d = null;

            if (m_rt != null)
            {
                m_rt.Dispose();
                m_rt = null;
            }

            if (m_srv != null)
            {
                m_srv.Dispose();
                m_srv = null;
            }
            if (m_renderTexture != null)
            {
                m_renderTexture.Dispose();
                m_renderTexture = null;
            }
        }

        readonly string m_name;

        public ImGuiSceneView(string name)
        {
            m_name = name;
        }

        D3DRenderTarget m_rt = new D3DRenderTarget();

        Texture2D m_renderTexture;

        ShaderResourceView m_srv;

        Im3dContext m_im3d = new Im3dContext();

        Matrix4x4 m_model = Matrix4x4.Identity;

        OrbitCamera m_camera = new OrbitCamera();

        Vector3 m_clearColor = new Vector3(0.4f, 0.5f, 0.6f);

        MouseState m_mouse;

        public void UpdateFrame(SharpDX.Direct3D11.Device device, TimeSpan deltaTime, ref MouseState mouse)
        {
            var nextSize = new Vector2(200, 200);
            ImGui.SetNextWindowSize(ref nextSize, ImGuiCond.FirstUseEver);
            var padding = Vector2.Zero;
            ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, ref padding);
            if (ImGui.Begin(m_name))
            {
                var size = ImGui.GetContentRegionAvail();
                var pos = ImGui.GetWindowPos();
                var frameHeight = ImGui.GetFrameHeight();
                var localMouse = ImGui.GetMousePos() - pos - new Vector2(0, frameHeight);
                var width = (int)size.X;
                var height = (int)size.Y;
                if (localMouse.X >= 0 && localMouse.Y >= 0 && localMouse.X < size.X && localMouse.Y < size.Y)
                {
                    m_mouse = mouse;
                    // cursor on view
                    m_mouse.X = (int)localMouse.X;
                    m_mouse.Y = (int)localMouse.Y;
                }

                m_camera.MouseInput(m_mouse, width, height);

                // update
                m_im3d.Set();
                Im3d.Im3dGui_NewFrame(ref m_camera.state, ref m_mouse, (float)deltaTime.TotalSeconds, -1);
                Im3d.Gizmo("gizmo", ref m_model.M11);
                Im3d.EndFrame();


                if (m_renderTexture != null)
                {
                    var desc = m_renderTexture.Description;
                    if (desc.Width != width || desc.Height != height)
                    {
                        m_renderTexture.Dispose();
                        m_renderTexture = null;

                        m_srv.Dispose();
                        m_srv = null;
                    }
                }
                if (m_renderTexture == null)
                {
                    m_renderTexture = new Texture2D(device, new Texture2DDescription
                    {
                        Format = SharpDX.DXGI.Format.B8G8R8X8_UNorm,
                        ArraySize = 1,
                        MipLevels = 1,
                        Width = width,
                        Height = height,
                        SampleDescription = new SharpDX.DXGI.SampleDescription
                        {
                            Count = 1,
                            Quality = 0
                        },
                        BindFlags = BindFlags.RenderTarget | BindFlags.ShaderResource
                    });

                    m_srv = new ShaderResourceView(device, m_renderTexture);

                    m_rt.FromTexture(device, m_renderTexture);
                }
                m_rt.Setup(device, m_clearColor);

                // render
                ImGui.DX11_DrawTeapot(device.ImmediateContext.NativePointer, ref m_camera.state.viewProjection.M11, ref m_model.M11);

                // im3d
                Im3d.Im3d_DX11_Draw(device.ImmediateContext.NativePointer, ref m_camera.state.viewProjection.M11,
                (int)m_camera.state.viewportWidth,
                (int)m_camera.state.viewportHeight,
                Im3d.GetDrawLists(), (int)Im3d.GetDrawListCount().Value);

                //
                // show render target
                //
                var uv0 = Vector2.Zero;
                var uv1 = Vector2.One;
                var bg = new Vector4(1, 1, 1, 1);
                var tint = new Vector4(1, 1, 1, 1);
                ImGui.ImageButton(m_srv.NativePointer, ref size, ref uv0, ref uv1, 0, ref bg, ref tint);
            }
            ImGui.End();
            ImGui.PopStyleVar();
        }
    }
}
