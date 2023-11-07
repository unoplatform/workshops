---
uid: Workshop.TubePlayer.GetStarted.TemplatesCli
---

If you're not using Visual Studio, you can use the `unoapp` dotnet new template to create a new project. This is the recommended approach for developers using Visual Studio Code or other IDEs.

The `unoapp` templates include a number of options that can be used to customize the generated project. These options can be listed by running the following command:

```
dotnet new unoapp -?
```

There are two preset configurations (specified using the `-preset` parameter), `blank` and `recommended`, that set default values for a number of options. The `recommended` preset includes a number of features that are commonly used in Uno Platform applications, such as C# Markup, MVUX, Material theme, Dependency Injection. The `blank` preset only includes the minimum features required for an Uno Platform application.

In this workshop, we will be starting with the blank preset, and configuring the following features (the `unoapp` parameter appears in parentheses):
- Net 8 (`-tfm net8.0`)
- C# Markup (`-markup csharp`)
- MVUX framework (`-presentation mvux`)
- Material theme (`-theme material`)
- DSP import for Material theme color overrides (`-dsp`)
- Dependency injection (`-di`)
- Configuration (`-config`)
- Region based navigation (`-nav regions`) 
- Uno Toolkit (`-toolkit`)

To generate the project with the above preferences run the following command:

```
dotnet new unoapp -preset blank -tfm net8.0 -markup csharp -presentation mvux -theme material -dsp -di -config -nav regions -toolkit -o TubePlayer
```

The parameter `-o` tells the template generator what name to use for the project.