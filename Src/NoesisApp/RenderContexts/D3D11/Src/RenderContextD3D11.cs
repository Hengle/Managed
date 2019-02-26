﻿using System;
using System.Runtime.InteropServices;
using Noesis;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace NoesisApp
{
    public class RenderContextD3D11 : RenderContext
    {
        public RenderContextD3D11()
        {
        }

        public override RenderDevice Device
        {
            get { return _device; }
        }

        private IntPtr _display;
        private IntPtr _window;
        private RenderDeviceD3D11 _device;
        private SharpDX.Direct3D11.Device _dev;
        private SwapChain _swapChain;
        private RenderTargetView _renderTarget;
        private DepthStencilView _depthStencil;
        private SharpDX.Mathematics.Interop.RawViewportF _viewport;
        private bool _vsync;

        public override void Init(IntPtr display, IntPtr window, uint samples, bool vsync, bool sRGB)
        {
            _display = display;
            _window = window;
            _vsync = vsync;

            FeatureLevel[] features =
            {
                FeatureLevel.Level_11_0,
                FeatureLevel.Level_10_1,
                FeatureLevel.Level_10_0,
                FeatureLevel.Level_9_3,
                FeatureLevel.Level_9_2,
                FeatureLevel.Level_9_1
            };

            _dev = new SharpDX.Direct3D11.Device(DriverType.Hardware, DeviceCreationFlags.None, features);

            SampleDescription sampleDesc = new SampleDescription();
            do
            {
                if (_dev.CheckMultisampleQualityLevels(Format.R8G8B8A8_UNorm, (int)samples) > 0)
                {
                    sampleDesc.Count = (int)samples;
                    sampleDesc.Quality = 0;
                    break;
                }
                else
                {
                    samples >>= 1;
                }
            } while (samples > 0);

            SwapChainDescription desc = new SwapChainDescription();
            desc.ModeDescription = new ModeDescription();
            desc.ModeDescription.Width = 0;
            desc.ModeDescription.Height = 0;
            desc.ModeDescription.RefreshRate.Numerator = 0;
            desc.ModeDescription.RefreshRate.Denominator = 0;
            desc.ModeDescription.Format = sRGB ? Format.R8G8B8A8_UNorm_SRgb : Format.R8G8B8A8_UNorm;
            desc.ModeDescription.ScanlineOrdering = DisplayModeScanlineOrder.Unspecified;
            desc.ModeDescription.Scaling = DisplayModeScaling.Unspecified;
            desc.SampleDescription = sampleDesc;
            desc.Usage = Usage.RenderTargetOutput;
            desc.BufferCount = 1;
            desc.OutputHandle = window;
            desc.IsWindowed = true;
            desc.SwapEffect = SwapEffect.Discard;
            desc.Flags = SwapChainFlags.None;

            SharpDX.DXGI.Device dev = _dev.QueryInterface<SharpDX.DXGI.Device>();
            Adapter adapter = dev.Adapter;
            Factory factory = adapter.GetParent<Factory>();
            _swapChain = new SwapChain(factory, _dev, desc);

            _device = new RenderDeviceD3D11(_dev.ImmediateContext.NativePointer, sRGB);
        }

        public override void SetWindow(IntPtr window) { }

        public override void BeginRender() { }

        public override void EndRender() { }

        public override void SetDefaultRenderTarget(int width, int height, bool doClearColor)
        {
            if (doClearColor)
            {
                _dev.ImmediateContext.ClearRenderTargetView(_renderTarget, new SharpDX.Mathematics.Interop.RawColor4(0.0f, 0.0f, 0.0f, 0.0f));
            }

            _dev.ImmediateContext.ClearDepthStencilView(_depthStencil, DepthStencilClearFlags.Stencil, 0.0f, 0);
            _dev.ImmediateContext.OutputMerger.SetRenderTargets(_depthStencil, _renderTarget);
            _dev.ImmediateContext.Rasterizer.SetViewport(_viewport);
        }

        public override void Swap()
        {
            _swapChain.Present(_vsync ? 1 : 0, PresentFlags.None);
        }

        public override void Resize()
        {
            _dev.ImmediateContext.OutputMerger.SetRenderTargets(null, (RenderTargetView)null);
            _swapChain.ResizeBuffers(0, 0, 0, Format.Unknown, SwapChainFlags.None);

            SwapChainDescription desc = _swapChain.Description;
            Texture2D color = _swapChain.GetBackBuffer<Texture2D>(0);
            _renderTarget = new RenderTargetView(_dev, color);

            Texture2DDescription textureDesc = new Texture2DDescription();
            textureDesc.Width = desc.ModeDescription.Width;
            textureDesc.Height = desc.ModeDescription.Height;
            textureDesc.MipLevels = 1;
            textureDesc.ArraySize = 1;
            textureDesc.SampleDescription = desc.SampleDescription;
            textureDesc.Usage = ResourceUsage.Default;
            textureDesc.BindFlags = BindFlags.DepthStencil;
            textureDesc.CpuAccessFlags = CpuAccessFlags.None;
            textureDesc.OptionFlags = ResourceOptionFlags.None;
            textureDesc.Format = Format.D24_UNorm_S8_UInt;

            Texture2D depthStencil = new Texture2D(_dev, textureDesc);
            _depthStencil = new DepthStencilView(_dev, depthStencil);

            _viewport.X = 0.0f;
            _viewport.Y = 0.0f;
            _viewport.Width = (float)desc.ModeDescription.Width;
            _viewport.Height = (float)desc.ModeDescription.Height;
            _viewport.MinDepth = 0.0f;
            _viewport.MaxDepth = 1.0f;
        }

    }
}
