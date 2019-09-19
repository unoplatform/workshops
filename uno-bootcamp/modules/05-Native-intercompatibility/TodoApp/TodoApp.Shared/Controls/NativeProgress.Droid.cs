#if __ANDROID__
using System;
using Windows.UI.Xaml;
using Android.Widget;
using Uno.UI;
using Resource = Android.Resource;
using Uno.UI.Controls;

namespace TodoApp.Shared.Controls
{
    /// 📚 <see cref="https://docs.microsoft.com/en-us/dotnet/api/android.widget.progressbar?view=xamarin-android-sdk-9" />
    public partial class NativeProgress : BindableProgressBar
    {
        public NativeProgress() : base(ContextHelper.Current, null, Resource.Attribute.ProgressBarStyleHorizontal)
        {
            Indeterminate = false;

            Min = Convert.ToInt32(GetValue(MinProperty));
            Progress = Convert.ToInt32(GetValue(ValueProperty));
            Max = Convert.ToInt32(GetValue(MaxProperty));
        }

        private static void OnValueChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((ProgressBar) dependencyObject).Progress = Convert.ToInt32(args.NewValue);
        }

        private static void OnMinChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((ProgressBar) dependencyObject).Min = Convert.ToInt32(args.NewValue);
        }

        private static void OnMaxChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((ProgressBar) dependencyObject).Max = Convert.ToInt32(args.NewValue);
        }
    }
}
#endif