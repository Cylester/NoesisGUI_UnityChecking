using System;
using System.Runtime.InteropServices;
using NoesisApp;

namespace NoesisGUICSharp_Testing
{
    partial class App : Application
    {
        protected override Display CreateDisplay()
        {
            return Noesis.Platform.ID switch
            {
                Noesis.PlatformID.Windows => new Win32Display(),
                Noesis.PlatformID.Linux => new XDisplay(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        protected override RenderContext CreateRenderContext()
        {
            return Noesis.Platform.ID switch
            {
                Noesis.PlatformID.Windows => new RenderContextD3D11(),
                Noesis.PlatformID.Linux when RuntimeInformation.OSArchitecture is Architecture.Arm or Architecture.Arm64 =>
                    new RenderContextEGL(),
                Noesis.PlatformID.Linux => new RenderContextGLX(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        [STAThread]
        static void Main()
        {
            App app = new App();
            app.Uri = "/NoesisGUICSharp_Testing;component/App.xaml";
            app.Run();
        }
    }
}
