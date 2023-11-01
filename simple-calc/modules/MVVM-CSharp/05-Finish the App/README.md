---
uid: Workshop.SimpleCalc.MVVM.CSharp.Finishing
---

[!include[MVVM ThemeService](../../Resources/MVVM/ThemeService.md)]

With our `ViewModel` updated we need to update our MainPage.cs file so that we initialize the `MainViewModel` with an `IThemeService` instance.

```cs
namespace SimpleCalculator;

public partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext(new MainViewModel(this.GetThemeService()), (page, vm) => page
          // Left out for brevity
        );
    }
}
```

[!include[ColorPaletteOverride](../../Resources/CSharp/Customizing-Palette.md)]

**[Previous](xref:Workshop.SimpleCalc.MVVM.CSharp.Architecture)**