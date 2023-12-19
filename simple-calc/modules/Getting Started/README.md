---
uid: Workshop.SimpleCalc.GettingStarted
---
# Getting Started

Uno Platform provides a multi-platform solution for building native apps for iOS, Android, Windows, macOS, Web, as well as Linux. This module will walk you through the process of getting started with Uno Platform.

## Setting up the Environment

To make sure that you have all the tools that you need to get started with Uno Platform, it's recommended that you run the [Uno Check](https://platform.uno/docs/articles/external/uno.check/doc/using-uno-check.html) tool to ensure that your environment is ready to go. From a command prompt.

```bash
dotnet tool install --global Uno.Check
uno-check
```

> [!NOTE]
> You may need to take additional steps if trying to build the Linux or GTK heads on Windows. Be sure to follow the [Additional setup for Linux or WSL](https://platform.uno/docs/articles/get-started-with-linux.html) docs.

## Getting the Project Templates

Uno Platform provides a set of `dotnet new` templates that allow you to create projects with the features that you need. To get started we will continue from a command prompt and install the Uno Platform `dotnet new` templates.

```bash
dotnet new install Uno.Templates
```

Now that the templates are installed we can list the options for the `unoapp` template with the following command.

```bash
dotnet new unoapp -h
```

## Uno Platform Extensions

The extensions for Visual Studio and Visual Studio Code provide some additional features for the IDEs that help enable code completion and Hot Reload. Before continuing to the next module be sure to take a moment to install the appropriate extension for your IDE. Additionally, the extension for Visual Studio on Windows includes the Uno Platform Template Wizard that makes it easy to pick the template options for your application.

- [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=unoplatform.uno-platform-addin-2022)

- [Visual Studio Code Marketplace](https://marketplace.visualstudio.com/items?itemName=unoplatform.vscode)

## Additional Resources

- [Uno Docs - Getting Started](https://platform.uno/docs/articles/get-started.html)   

# Before continuing...

Before we build our first app, it's important to make a few decisions about how we would like to build our app. The templates that we installed in the first module include the `unoapp` solution template, which gives us a lot of options but we're just going to focus on a few to start with.

## Markup

The first option to consider is the choice of markup technology to use:

### XAML

XAML is an XML-based markup language that is used to define the structure of a user interface. First introduced by Microsoft for WPF applications, XAML has been a proven solution for building user interfaces. XAML is a declarative language, meaning that it describes the structure of the UI, but not how it should be rendered. This is done by the XAML processor, which is the XAML engine in the .NET framework.

Due to its nature, XAML is often preferred by developers coming from a web background as it is similar to HTML. However, XAML is not a replacement for HTML and is not intended to be used for web development. It is important to understand that individual nodes in XAML map to actual .NET objects and that the XAML processor is responsible for creating these objects and setting their properties.

### C# Markup

C# Markup is based on the desire of many developers to leverage better intellisense and strong typing that exists in C# code. With C# Markup we can build our UI entirely in C# using a generated set of fluent extensions that make it easier to build our UI. Additionally, when using [Uno Themes](https://aka.platform.uno/uno-themes) it becomes easier to discover available styles, colors, and brushes.

## Presentation

The next option is the choice between MVVM and MVUX for the presentation logic of the application.

### Model-View-ViewModel (MVVM)

Model-View-ViewModel is a well-established pattern for building applications. It is a pattern that is well suited to the Uno Platform and is a great way to build your apps.

### Model-View-Update (MVUX)

Model-View-Update has become an increasingly popular choice for developers looking to have a more functional approach to building user interfaces. Model-View-Update-eXtended (MVUX) is a pattern that is similar to the MVU pattern and has been specifically designed to work with data binding.


## Next Step

To continue, please select one of the following options:


<div class="row">

<div class="col-md-6 col-xs-12 ">
<a href="..\MVUX-XAML\01-Build your first Project\README.html">
<div class="alert alert-info alert-hover">

#### XAML + MVUX

Use XAML for layout and MVUX for state management.

</div>
</a>
</div>

<div class="col-md-6 col-xs-12 ">
<a href="..\MVVM-XAML\01-Build your first Project\README.html">
<div class="alert alert-info alert-hover">

#### XAML + MVVM

Use XAML for layout and MVVM for state management.

</div>
</a>
</div>

<div class="col-md-6 col-xs-12 ">
<a href="..\MVUX-CSharp\01-Build your first Project\README.html">
<div class="alert alert-info alert-hover">

#### C# Markup + MVUX

Use C# Markup for layout and MVUX for state management.

</div>
</a>
</div>

<div class="col-md-6 col-xs-12 ">
<a href="..\MVVM-CSharp\01-Build your first Project\README.html">
<div class="alert alert-info alert-hover">

#### C# Markup + MVVM

Use C# Markup for layout and MVVM for state management.

</div>
</a>
</div>

</div>

<br/>

***
