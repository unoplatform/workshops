---
uid: Workshop.SimpleCalc.MVUX.XAML.Architecture
---

[!include[Introduction](../../Resources/MVUX/Intro.md)]

To start let's set the DataContext in the MainPage.xaml.cs (code behind).

```cs
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = new MainModel();
    }
}
```

You'll notice that we didn't create an instance of `MainModel` but rather we created a `MainViewModel`. This is the `X` in `MVUX`, it is a generated class that provides the glue between what XAML data bindings expect and the properties exposed by `MainModel`.

[!include[Feeds and Commands](../../Resources/MVUX/Feeds-and-Commands.md)]

**[Import UI from Figma](xref:Workshop.SimpleCalc.MVUX.XAML.Figma) or [Creating the Layout](xref:Workshop.SimpleCalc.MVUX.XAML.CreatingLayout) | [Next](xref:Workshop.SimpleCalc.MVUX.XAML.Finishing)**
