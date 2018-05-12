using Android.App;
using Android.Content.PM;
using Android.OS;
using StarWarsDemoApp.Droid.Helpers.Version;
using StarWarsDemoApp.Helpers.Version;
using Xamarin.Forms;

namespace StarWarsDemoApp.Droid
{
    [Activity(Label = "StarWarsDemoApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            DependencyService.Register<IApplicationVersionHelper, ApplicationVersionHelper>();

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

