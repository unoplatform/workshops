---
uid: Workshop.SimpleCalc.FirstProject.UnoTemplates
---
For this project, we will be using the `unoapp` solution template. This template includes two preset configurations, `blank` and `recommended`, and a large number of other options that can be used to define the structure of the app to be created by the template.

For this project, we're going to select the `blank` preset, which only includes the minimum features required for an Uno Platform application. We're also going to select the Material theme and include the Uno Toolkit for the helper functions to switch themes.

By default, the project will be created with XAML and using the MVVM pattern. As we are using C# Markup we will specify the `-ui csharp` option, and to use the MVUX pattern we will specify the `-presentation mvux` option.

```bash
dotnet new unoapp -preset blank -tfm net8.0 -markup csharp -presentation mvux -toolkit true -theme material -theme-service -o SimpleCalculator
```

