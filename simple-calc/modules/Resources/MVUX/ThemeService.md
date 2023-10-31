---
uid: Workshop.SimpleCalc.MVUX.ThemeService
---

# Finishing the App

We have a fully functional calculator app, but there are still some things we can do to further customize and refine the app. In this module, we will look at the `ThemeService` from Uno.Extensions and use this to toggle between light and dark theme in the app. Then we will finish by overriding the default colors to give the app a more custom look and feel.

## Adding the ThemeService

We need to update the constructor of our `DataContext` (MVU Model) to use the `IThemeService`. First, we need to update the initial value of the `IsDark` property to use the `IThemeServicce.IsDark` property. Because the `IThemeService` may still update the initial theme as initializes, we will want to hook into its `ThemeChanged` event and update the `IsDark` property when the theme changes. Finally, we will want to update the theme when the `IsDark` property is changed by the user.

Update the constructor for the `MainModel` with the following code:

```cs
public MainModel(IThemeService themeService)
{
    Calculator = State.Value(this, () => new Calculator());
    IsDark = State.Value(this, () => themeService.IsDark);

    themeService.ThemeChanged += async (_, _) =>
    {
        // Retrieve the IsDark property whilst still on the UI thread
        var isDark = themeService.IsDark;
        await IsDark.Update(_ => isDark, CancellationToken.None);
    };

    IsDark.ForEachAsync(async (dark, ct) =>
        await themeService.SetThemeAsync(dark ? AppTheme.Dark : AppTheme.Light));
}
```