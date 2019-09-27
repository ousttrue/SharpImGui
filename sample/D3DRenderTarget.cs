using System;
using System.Numerics;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace sample
{
    public class D3DRenderTarget : IDisposable
    {
        RenderTargetView m_rtv;
        public RenderTargetView RTV => m_rtv;

        DepthStencilView m_dsv;
        public DepthStencilView DSV => m_dsv;

        // DepthStencilState m_ds;
        // if (m_ds == null)
        // {
        //     m_ds = new DepthStencilState(Device,
        //     new DepthStencilStateDescription
        //     {
        //         IsDepthEnabled = true,
        //         DepthWriteMask = DepthWriteMask.All,
        //         DepthComparison = Comparison.Less,
        //     });
        // }


        public void Dispose()
        {
            if (m_rtv != null)
            {
                m_rtv.Dispose();
                m_rtv = null;
            }
            if (m_dsv != null)
            {
                m_dsv.Dispose();
                m_dsv = null;
            }
        }

        int m_width;
        int m_height;

        /// <summary>
        /// srcからRTVとDSVを作る
        /// </summary>
        public void FromTexture(SharpDX.Direct3D11.Device device, Texture2D src)
        {
            Dispose();

            m_rtv = new RenderTargetView(device, src);

            var depthDesc = src.Description;
            m_width = depthDesc.Width;
            m_height = depthDesc.Height;

            depthDesc.MipLevels = 1;
            depthDesc.ArraySize = 1;
            depthDesc.Format = Format.D24_UNorm_S8_UInt;
            depthDesc.BindFlags = BindFlags.DepthStencil;
            using (var depthTexture = new Texture2D(device, depthDesc))
            {
                m_dsv = new DepthStencilView(device, depthTexture);
            }
        }

        public void Setup(SharpDX.Direct3D11.Device device, Vector3 clearColor)
        {
            device.ImmediateContext.ClearRenderTargetView(m_rtv,
            new SharpDX.Mathematics.Interop.RawColor4(clearColor.X, clearColor.Y, clearColor.Z, 1.0f));
            device.ImmediateContext.ClearDepthStencilView(m_dsv, DepthStencilClearFlags.Depth | DepthStencilClearFlags.Stencil, 1.0f, 0);

            device.ImmediateContext.OutputMerger.SetRenderTargets(m_dsv, m_rtv);

            device.ImmediateContext.Rasterizer.SetViewport(0, 0, m_width, m_height, 0, 1.0f);
        }
    }
}
