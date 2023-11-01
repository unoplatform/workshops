---
uid: Workshop.SimpleCalc.MVVM.XAML.Finishing
---

[!include[MVVM ThemeService](../../Resources/MVVM/ThemeService.md)]

With our `ViewModel` updated we need to update our MainPage.xaml.cs file so that we initialize the `MainViewModel` with an `IThemeService` instance.

```cs
namespace SimpleCalculator;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = new MainViewModel(this.GetThemeService());
    }
}
```

[!include[ColorPaletteOverride](../../Resources/XAML/Customizing-Palette.md)]

**[Previous](xref:Workshop.SimpleCalc.MVVM.XAML.Architecture)**