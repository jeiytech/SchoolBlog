using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace SchoolBlog;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
        {
            GetDecorView().SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
            Window?.SetStatusBarColor(Android.Graphics.Color.White); // Set your desired color here
        }

        // Rest of your code
    }

    private Android.Views.View GetDecorView()
    {
        return Window.DecorView;
    }
}
