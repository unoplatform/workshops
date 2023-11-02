---
uid: Workshop.SimpleCalc.Figma.CSharp
---

[!include[Setting up Figma Plugin](../../../Import-UI-from-Figma/Intro.md)]

2. Open the Export tab, select C#, then click Refresh (the circled arrow button on the bottom).

![Figma menu plugin](../../../../art/figma-plugin-export-csharp.png)

3. Select all contents starting from the line following `this` and ending at the semicolon (;).

![Figma Export](../../../../art/figma-export-csharp.png)

You can access the page content by [clicking here.](MainPage.cs)

<details>
    <summary><i>MainPage.cs</i> code contents (collapsed for brevity)</summary>

[!code-csharp[MainPage.cs](MainPage.cs)]
</details>

4. Copy the selected code to the clipboard (<kbd>Ctrl</kbd>+<kbd>C</kbd> on Windows).

5. Open MainPage.cs and replace all the Page contents with the copied code.

6. To set the appropriate font size for all buttons, access the MaterialFontsOverride.cs file in the Style folder. Go to the Figma Plugin, in the Export tab, and select Fonts Override File from the dropdown menu. Copy the content in the ResourceDictionary and replace it in your MaterialFontsOverride.cs.

![Figma Export](../../../../art/figma-export-fonts-csharp.png)

You can access the FontOverride file by [clicking here.](MaterialFontsOverride.cs)

7. Now we need to prepare our UI with the Binding expressions that we will need in the App Architecture module. First let's add the `DataContext` to the page. To do so add `.DataContext(new TempDataContext(), (page, vm) => page` before the `.Content` definition. Ensure to properly terminate the DataContext with a closing `)` preceding the semicolon at the end of the page's code.

```csharp
this
    .Background(Theme.Brushes.Background.Default)
    .StatusBar(foreground: StatusBarForegroundTheme.Light)
    .Resources
    (
        r => r
            ...
    )
    .DataContext(new TempDataContext(), (page, vm) => page
    .Content
    (
        ...
    )
    );
```

For all buttons we need to add `Command(() => vm.InputCommand)` and `CommandParameter` that will receive the same content as the `Content` attribute. For example, the first button would then be:

```csharp
new Button()
    .Background(Theme.Brushes.OnSurface.Inverse.Default)
    .Content("C")
    .Height(72)
    .CornerRadius(24)
    .Style(Theme.Button.Styles.FilledTonal)
    .AutoLayout
    (
        counterAlignment: AutoLayoutAlignment.Start,
        primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
    )
    .CommandParameter("C")
    .Command(() => vm.InputCommand),
```

Apply these instructions to all the buttons on our page, except for the delete (back) button, which should display "⌫". Remember that for this specific button, set the `CommandParameter` as the text "back".

Last we need to update our `ToggleButton` with the Binding expression `IsChecked(x => x.Bind(() => vm.IsDark).TwoWay())"` for the theme switching (Light and Dark).

```csharp
new ToggleButton()
    .Background(Theme.Brushes.Surface.Default)
    .Margin(10,24)
    .CornerRadius(20)
    .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
    .IsChecked(x => x.Bind(() => vm.IsDark).TwoWay())
    .Content
    (
        ...
    )
    .ControlExtensions
    (
        ...
    ),
```

[!include[Conclude Figma Plugin](../../../Import-UI-from-Figma/Conclusion.md)]