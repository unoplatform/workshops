#if __IOS__
using System;
using UIKit;
using Uno.UI.Views.Controls;
using Windows.UI.Xaml;
using CoreImage;

namespace TodoApp.Shared.Controls
{
    /// 📚 <see cref="https://docs.microsoft.com/en-us/dotnet/api/uikit.uiprogressview?view=xamarin-ios-sdk-12"/>
    public partial class NativeProgress : BindableUIProgressView
    {
        private static void OnValueChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            (dependencyObject as NativeProgress)?.Update();
        }

        private static void OnMinChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            (dependencyObject as NativeProgress)?.Update();
        }

        private static void OnMaxChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            (dependencyObject as NativeProgress)?.Update();
        }

        private void Update()
        {
            var max = Maximum;
            if (max < 1)
            {
                Progress = 0;
                return;
            }

            Progress = (float)((Value - Minimum) / Maximum);
        }
    }
}
#endif