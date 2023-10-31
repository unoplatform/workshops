---
uid: Workshop.SimpleCalc.MVVM.ThemeService
---

# Finishing the App

We have a fully functional calculator app, but there are still some things we can do to further customize and refine the app. In this module, we will look at the `ThemeService` from Uno.Extensions and use this to toggle between light and dark theme in the app. Then we will finish by overriding the default colors to give the app a more custom look and feel.

## Adding the ThemeService

We need to update the constructor of our `DataContext` (MVVM ViewModel) to use the `IThemeService`. First, we need to update the initial value of the `IsDark` property to use the `IThemeServicce.IsDark` property. Because the `IThemeService` may still update the initial theme as initializes, we will want to hook into its `ThemeChanged` event and update the `IsDark` property when the theme changes. Finally, we will want to update the theme when the `IsDark` property is changed by the user.

Update the `MainViewModel` with the following constructor, `_themeService` field and `IsDark` property:

```cs
namespace SimpleCalculator;

public partial class MainViewModel : ObservableObject
{
    private readonly IThemeService _themeService;

    public MainViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        IsDark = _themeService.IsDark;
        _themeService.ThemeChanged += (_, _) => IsDark = _themeService.IsDark;
    }

    private bool _isDark;
    public bool IsDark
    {
        get => _isDark;
        set
        {
            if (SetProperty(ref _isDark, value))
            {
                _themeService.SetThemeAsync(value ? AppTheme.Dark : AppTheme.Light);
            }
        }
    }

    [ObservableProperty]
    private Calculator _calculator = new();

    [RelayCommand]
    private void Input(string key) =>
        Calculator = Calculator.Input(key);
}
```
