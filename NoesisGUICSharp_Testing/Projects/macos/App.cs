using System;
using Noesis;
using NoesisApp;

namespace NoesisGUICSharp_Testing
{
    partial class App : Application
    {
        protected override Display CreateDisplay()
        {
            return new AppKitDisplay();
        }

        protected override RenderContext CreateRenderContext()
        {
            return new RenderContextMTL();
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
