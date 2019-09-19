# NativeProgress

The Uno Platform allows you to reuse views and business logic across platforms. Sometimes though you may want to write different code per platform, either because you need to access platform-specific native APIs and 3rd-party libraries, or because you want your app to look and behave differently depending on the platform.

The `NativeProgress` control demonstrates how a different native control can be used on a per-platform basis.

## Syntax

```xml
<Page ...
    xmlns:controls="using:TodoApp.Shared.Controls">

    <controls:NativeProgress Value="{Binding Value, ElementName=slider}" />
    <Slider x:Name="slider" Value="50.0" />
</Page>
```

## Usage

If used on all platforms, do not set `Maximum above 100` but instead `divide your value by 100`. Additionally, do not use `Minimum`

## Limitations and implementation quirks

There are differences on a per platform basis as where possible the `NativeProgress` control wraps the platform specific progressbar.

### Android

1. Native `Android.Widget.ProgressBar` control is used as a horizontal progressbar and `Indeterminate` is set to `false`
1. Android supports setting `Value`, `Minimum` and  `Maximum`. `Maximum` can be `higher than 100`.

### iOS

1. Native `UIKit.UIProgressView` control is used with defaults.
1. Setting `Value` is supported however iOS does not support setting `Minimum` or `Maximum`. The `Minimum` is always `0` and the `Maximum` is always `100`.

### UWP

1. Native `Windows.UI.Xaml.Controls.ProgressBar` control is used with defaults.
1. UWP supports setting `Value`, `Minimum` and  `Maximum`. `Maximum` can be `higher than 100`.

### WebAssembly

1. HTML `progress` indicator element is used with defaults.
1. Setting `Value` is supported however HTML does not support setting `Minimum`. The `Minimum` is always `0` and the `Maximum` can be `higher than 100`.

## API Source Code

- https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.progressbar
- https://docs.microsoft.com/en-us/dotnet/api/uikit.uiprogressview?view=xamarin-ios-sdk-12
- https://docs.microsoft.com/en-us/dotnet/api/android.widget.progressbar?view=xamarin-android-sdk-9
- https://developer.mozilla.org/en-US/docs/Web/HTML/Element/progres

## Related Topics

- [Platform-specific XAML markup in Uno](https://platform.uno/docs/articles/platform-specific-xaml.html)
- [Platform-specific C# code in Uno](https://platform.uno/docs/articles/platform-specific-csharp.html)
