---
uid: Workshop.TubePlayer.Overview
---

# Tube Player Workshop

The objective of the Tube Player workshop is to create a simple Uno Platform application that enables the user to search for, and stream, YouTube videos.

The resulting application will have two main views:

- **Search page**: To accept the user's queries with a search box. Based on the query, matching results from YouTube will be listed.
- **Player page**: Streams the video selected from the search results into a media player.

This workshop will help you set up your developer environment to develop Uno Platform applications. By the end of this workshop, you'll have built a multi-platform application using Uno Platform features like [C# Markup](https://aka.platform.uno/csharp-markup) and [MVUX](https://aka.platform.uno/mvux). You'll have the option to import a UI from [Figma](https://aka.platform.uno/uno-figma), or continue following the steps from this workshop to build the UI for the application. This workshop will help you learn more about the tools, libraries, and patterns available in the Uno Platform, that are there to help you rapidly build high-quality applications.

On completion of the workshop, you will have a working cross-platform TubePlayer app. Here's a screen recording of it (Android):

![Completed TubePlayer app](modules/11-App-Finalization/ui-output.gif)

This app was developed using Uno Platform and draws inspiration from [Naweed Akram](https://twitter.com/xgeno "@xgeno")'s [MAUI project](https://github.com/naweed/MauiTubePlayer) and [Flutter project](https://github.com/naweed/FlutterTubePlayer).

## What you will learn

- How to prepare your environment to build cross-platform apps with Uno Platform whether you're using Visual Studio (Windows) or Visual Studio Code (Windows or Mac).
- How to create a new solution using the Uno Platform dotnet new template or the Uno Platform Template Wizard.
- How to use the [Uno Platform Figma plugin](https://aka.platform.uno/uno-figma) to generate your UI in C# Markup from [this Figma file](https://aka.platform.uno/uno-figma-tubeplayer-workshop) (optional).
- How to build your app's presentation layer using C# Markup and Model-View-Update-eXtended (MVUX).
- How to customize your app theme and override its theme colors by using either C# code imported from Figma, or by importing a custom DSP ([Design System Package](https://github.com/AdobeXD/design-system-package-dsp)) color theme.
- How to use remote APIs in your app using the Uno Platform Refit extension.
- How to customize the app icon and its splashscreen.

This workshop has been set up to provide you with optional content to allow you to tailor the experience to your needs. You can choose to skip the Uno Figma Plugin module and obtain the UI code directly in the workshop.

## Prerequisites

- A working understanding of C# & .NET.
- A working understanding of Visual Studio 2022 (Windows) or Visual Studio Code.

## Techniques and controls used in this workshop

The workshop utilizes the latest Uno Platform features, including:

### Environment setup & Inner loop

- [Hot Reload](xref:Uno.Features.HotReload)
- [Uno.Check](xref:UnoCheck.UsingUnoCheck)

### Cross-platform development

- [Uno.Resizetizer](xref:Uno.Resizetizer.GettingStarted)
  - [UnoIcon](xref:Uno.Resizetizer.GettingStarted#unoicon)
  - [UnoSplashScreen](xref:Uno.Resizetizer.GettingStarted#unosplashscreen)
- [Template Wizard](xref:Uno.GettingStarted.UsingWizard)

### Battle-tested features for apps
- [Extensions](xref:Uno.Extensions.Overview)
    - [Hosting environments](xref:Uno.Extensions.Hosting.Overview#hosting-environments)
    - [Navigation with regions](xref:Uno.Extensions.Navigation.Advanced.Panel)
    - [Refit endpoints](xref:Uno.Extensions.Http.HowToRefit)
    - [Serialization](xref:Uno.Extensions.Serialization.Overview)
- [C# Markup](xref:Uno.Extensions.Markup.Overview)

### Clean architecture, simplified

- [MVUX](xref:Uno.Extensions.Mvux.Overview)
  - Creating [Feeds](xref:Uno.Extensions.Mvux.Feeds)
  - Consuming feed data using [FeedView](xref:Uno.Extensions.Mvux.FeedView) with a custom [ErrorTemplate](xref:Uno.Extensions.Mvux.FeedView#errortemplate) and [NoneTemplate](xref:Uno.Extensions.Mvux.FeedView#nonetemplate)
  - [Paginating](xref:Uno.Extensions.Mvux.Advanced.Pagination) feed data

### Figma

- [Figma plugin](https://aka.platform.uno/uno-figma)
- [Design to code](xref:Uno.Figma.GetStarted.DesignToCode)
- [Custom colors](xref:Uno.Figma.Learn.Developers.CustomColors)
- [Export as C# Markup](xref:Uno.Figma.Learn.Developers.Tabs.Export#c-markup-export)

### Theming

- [Themes](xref:Uno.Themes.Overview)
    - [Material design theme](xref:Uno.Themes.Material.GetStarted)
    - [Color overrides](xref:Uno.Themes.Material.Colors)
    - [DSP tooling](xref:Uno.Themes.Material.DSP)

### Efficient and reusable UI components

- [Toolkit](xref:Toolkit.GettingStarted)
  - [AutoLayout](xref:Toolkit.Controls.AutoLayoutControl)
  - [CardContentControl](xref:Toolkit.Controls.Card#cardcontentcontrol)
  - [ExtendedSplashScreen](xref:Toolkit.Controls.ExtendedSplashScreen)
  - [NavigationBar](xref:Toolkit.Controls.NavigationBar)

## Modules

- [01 - Getting started](xref:Workshop.TubePlayer.GetStarted)  
    Get started with Uno Platform - set up the environment, and create a project using the template wizard or the dotnet new template.  
- [02 - Creating basic UI layout with C# Markup](xref:Workshop.TubePlayer.BasicLayout)  
    Use C# Markup to create the basic UI for the search page. This will comprise a `Grid` containing a `TextBox` which will be used to search for YouTube videos, as well as a `ListView` which will display results.
- [03 - Connect UI with mock data](xref:Workshop.TubePlayer.MockData)  
    Create models and services that will be used by the presentation layer to retrieve data and display it in the appropriate UI controls. The presentation layer will include mock services that will simulate YouTube search results.
- [04 - Importing UI from Figma (optional)](xref:Workshop.TubePlayer.Figma)  
    Import C# Markup UI from Figma using the Uno Platform Figma plugin.
- [05 - Creating the UI](xref:Workshop.TubePlayer.UI)  
    Create the UI with C# Markup without importing it from Figma.
- [06 - Theme overrides](xref:Workshop.TubePlayer.ThemeOverrides)  
    Import an app theme to override the Tube Player app's visual appearance.
- [07 - Navigation](xref:Workshop.TubePlayer.Navigation)  
    Use [Uno Platform Navigation extension](xref:Overview.Navigation) to navigate and pass data between pages.
- [08 - Add API endpoints](xref:Workshop.TubePlayer.ApiEndpoints)  
    Replace the mock service we created in [module 3](xref:Workshop.TubePlayer.MockData) with a service that interacts with real search results coming from YouTube.
- [09 - FeedView None and Error templates](xref:Workshop.TubePlayer.FeedView)  
    Add None and Error templates to the `FeedView` control to display a message when there are no search results or when an error occurs.
- [10 - Add a media player](xref:Workshop.TubePlayer.MediaPlayer)  
    Stream and play video data from YouTube using a `MediaPlayerElement`.
- [11 - App finalization](xref:Workshop.TubePlayer.Finalization)  
    Finalize the app by adding a splash screen, app icons, and a launch screen.

## Sample Application

You can refer to the fully implemented sample available as a reference application in the [Uno.Samples repository](https://aka.platform.uno/tubeplayer-sampleapp)

## Next Step

- [01 - Getting started](xref:Workshop.TubePlayer.GetStarted)
