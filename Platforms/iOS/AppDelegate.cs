using Foundation;
using UIKit;

namespace SchoolBlog;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        // ...

        if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
        {
            // Set the status bar icon color using the statusBarStyle property
            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false); // Set your desired style here
        }
        else
        {
            // Set the status bar icon color using the statusBarStyle property
            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false); // Set your desired style here
        }

        return base.FinishedLaunching(app, options);
    }

}
