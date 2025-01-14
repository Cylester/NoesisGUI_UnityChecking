using UIKit;
using Foundation;
using ObjCRuntime;
using System.IO;
using NoesisApp;

namespace NoesisGUICSharp_Testing
{
    partial class App : Application
    {
        [Register("AppDelegate")]
        public partial class AppDelegate : UIApplicationDelegate
        {
            public override bool FinishedLaunching(UIApplication application, NSDictionary options)
            {
                UIApplication.SharedApplication.StatusBarHidden = true;
                PerformSelector(new Selector("PerformInit:"), null, 0.2f);
                return true;
            }

            [Export("PerformInit:")]
            private void PerformInit(NSObject @object)
            {
                App app = new App();
                app.Uri = "/NoesisGUICSharp_Testing;component/App.xaml";
                app.Run();
            }
        }

        protected override Display CreateDisplay()
        {
            return new UIKitDisplay();
        }

        protected override RenderContext CreateRenderContext()
        {
            return new RenderContextMTL();
        }

        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(NSBundle.MainBundle.BundlePath);
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}