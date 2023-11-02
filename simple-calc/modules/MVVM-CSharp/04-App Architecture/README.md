---
uid: Workshop.SimpleCalc.MVVM.CSharp.Architecture
---

[!include[Introduction](../../Resources/MVVM/Intro.md)]

To start, we need to replace the temporary DataContext class we created earlier. For this we will use the `MainViewModel` class that we just created. You can do a Find/Replace to replace `TempDataContext` with `MainViewModel`.

```cs
public MainPage()
{
    this.DataContext(new MainViewModel(), (page, dataContext) => page
      .Content(...));
}
```

> [!NOTE]
> Binding expressions must be stateless and the model property in our lambda expression will *ALWAYS* have a null value. Attempting to access instance values from the model will result in a NullReferenceException.

[!include[Commands](../../Resources/MVVM/Commands.md)]

**[Import UI from Figma](xref:Workshop.SimpleCalc.MVVM.CSharp.Figma) or [Creating the Layout](xref:Workshop.SimpleCalc.MVVM.CSharp.CreatingLayout) | [Next](xref:Workshop.SimpleCalc.MVVM.CSharp.Finishing)**