---
uid: Workshop.SimpleCalc.MVVM.XAML.Architecture
---

[!include[Introduction](../../Resources/MVVM/Intro.md)]

To start, let's set the `DataContext` in the MainPage.xaml.cs (code behind file for MainPage.xaml).

```cs
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
```

[!include[Commands](../../Resources/MVVM/Commands.md)]

**[Import UI from Figma](xref:Workshop.SimpleCalc.MVVM.XAML.Figma) or [Creating the Layout](xref:Workshop.SimpleCalc.MVVM.XAML.CreatingLayout) | [Next](xref:Workshop.SimpleCalc.MVVM.XAML.Finishing)**