using Windows.UI.Xaml;
using Android.App;
using Android.Content.PM;
using Android.Views;

namespace TodoApp.Droid
{
    [Activity(
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
    )]
    public class MainActivity : ApplicationActivity
    {
    }
}