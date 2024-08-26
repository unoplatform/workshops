---
uid: Workshop.SimpleCalc.MVUX.CSharp.Architecture
---

[!include[Introduction](../../Resources/MVUX/Intro.md)]

To start we need to replace the temporary DataContext class we created earlier. It's also important to note here that we will not initialize the MainModel since we need the `X` in `MVUX`. For this, we will use the generated `MainViewModel` class. You can do a Find/Replace to replace all references to `TempDataContext` with `MainViewModel`, and then remove the `TempDataContext` class.

```cs
public MainPage()
{
    this.DataContext(new MainViewModel(), (page, vm) => page
      .Content(...));
}
```

[!include[Feeds and Commands](../../Resources/MVUX/Feeds-and-Commands.md)]

**[Import UI from Figma](xref:Workshop.SimpleCalc.MVUX.CSharp.Figma) or [Creating the Layout](xref:Workshop.SimpleCalc.MVUX.CSharp.CreatingLayout) | [Next](xref:Workshop.SimpleCalc.MVUX.CSharp.Finishing)**