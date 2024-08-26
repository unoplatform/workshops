---
uid: Workshop.SimpleCalc.MVUX.CSharp.Finishing
---

[!include[MVUX ThemeService](../../Resources/MVUX/ThemeService.md)]

With our model updated we need to update our MainPage.cs file so that we initialize the `MainViewModel` with the `this.GetThemeService()`.

```cs
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

**[Previous](xref:Workshop.SimpleCalc.MVUX.CSharp.Architecture)**