---
uid: Workshop.SimpleCalc.MVUX.XAML.Finishing
---

[!include[MVUX ThemeService](../../Resources/MVUX/ThemeService.md)]

With our model updated we need to update our **MainPage.xaml.cs** file so that we initialize the `BindableMainModel` with the `this.GetThemeService()`.

```cs
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = new BindableMainModel(this.GetThemeService());
    }
}

```
</details>

[!include[ColorPaletteOverride](../../Resources/XAML/Customizing-Palette.md)]

**[Previous](xref:Workshop.SimpleCalc.MVUX.XAML.Architecture)**