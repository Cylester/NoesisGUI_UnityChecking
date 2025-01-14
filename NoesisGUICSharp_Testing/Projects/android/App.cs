using NoesisApp;

namespace NoesisGUICSharp_Testing
{
    partial class App : NoesisApp.Application
    {
        [Android.App.Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
        public class MainActivity : AndroidActivity
        {
            protected override void Main()
            {
                App app = new App();
                app.Uri = "/NoesisGUICSharp_Testing;component/App.xaml";
                app.Run();
            }

            protected override void OnCreate(Android.OS.Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            }

            public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [Android.Runtime.GeneratedEnum] Android.Content.PM.Permission[] grantResults)
            {
                Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
                base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }
        }

        protected override Display CreateDisplay()
        {
            return new AndroidDisplay();
        }

        protected override RenderContext CreateRenderContext()
        {
            return new RenderContextEGL();
        }
    }
}