---
uid: Workshop.TubePlayer.GetStarted.TemplatesCli
---

The Uno Platform command line interface (CLI) solution templates include two preset configurations, `blank` and `recommended`, and a large number of other options that can be used to customize the structure of the app to be created by the template.

In this workshop, we will be using the blank preset, which only includes the minimum features required for an Uno Platform application.  

The rest of the features will be added manually (the `unoapp` parameter appears in parentheses):
- C# Markup (`markup`)
- MVUX framework (`presentation`)
- Material theme (`theme`)
- DSP import for theme color overrides (`dsp`)
- Dependency Injection (`di`), Configuration (`config`), and Navigation (`nav`) extensions 
- Uno Toolkit (`toolkit`)

The HTTP and Refit extension will be added manually at [a later stage](xref:Workshop.TubePlayer.ApiEndpoints).

To generate the project with the above preferences run the following command:

```bash
dotnet new unoapp -preset blank -markup csharp -presentation mvux -theme material -dsp -di -config -nav regions -toolkit -o TubePlayer
```

The parameter `-o` tells the template generator what name to use for the project.