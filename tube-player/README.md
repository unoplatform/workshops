---
uid: Workshop.TubePlayer.Overview
---

# Tube Player workshop

The objective of the Tube Player workshop is to create a simple Uno Platform application that enables the user to search for, and stream, YouTube videos. 

The application will be made up of a starting search page, that will accept user input in a search box and display matched results from YouTube, and a player page, which will contain a media player, that will stream the video selected on the search page.

This workshop will help guide you through setting up your developer environment for developing Uno Platform applications. By the end of the workshop, you'll have built a multi-platform Uno Platform application using C# Markup and MVUX. You'll have the option to import the UI from Figma or follow along with the workshop material, to build the UI for the application. You'll also learn about the tools, libraries, and patterns available in the Uno Platform, that are there to help you rapidly build high-quality applications.
 
This app is created using Uno Platform and inspired from the work by [Naweed Akram](https://twitter.com/xgeno "@xgeno") on [MAUI](https://github.com/naweed/MauiTubePlayer) and [Flutter](https://github.com/naweed/FlutterTubePlayer)

## What you will learn 

- How to prepare your environment to build cross-platform apps with Uno Platform whether you're using Visual Studio (Windows) or Visual Studio Code (Windows or Mac). 
- How to create a new solution using the Uno Platform dotnet new template or the Uno Platform Template Wizard.
- How to use the Uno Platform Figma plugin to generate your UI in C# Markup.
- How to build your app's presentation layer using C# Markup and Model-View-Update-eXtended (MVUX). 
- How to customize your app theme and override its theme colors by using either C# code imported from Figma, or by importing a custom DSP color theme.
- How to use remote APIs in your app using the Uno Platform Refit extension.
- How to customize the app icon and its splash-screen.

This workshop has been set up to provide you with optional content to allow you to tailor the experience to your needs. You can choose to skip the Uno Figma Plugin module and obtain the UI code directly in the workshop.
 
## Prerequisites 
 
- A working understanding of C# & .NET.
- A working understanding of Visual Studio 2022 (Windows) or Visual Studio Code (Windows or Mac)
 
 ## Techniques and controls used in this workshop

The workshop utilizes the latest Uno Platform features, including:

- C# Markup
- Extensions
  - MVUX
    - Pagination
    - FeedView
        - NoneTemplate
        - ErrorTemplate
    - Refit
    - Region navigation
    - Serialization
- Material design theme
- Figma plugin
    - C# Markup
    - Color overrides
- Color overrides
- DSP import
- Themes
- Toolkit 
    - CardControl
    - ElevatedView 
    - Media player
    - Navigation bar
- Resizetizer
    - Splash screen
    - App icon 
<!-- TODO: Other notable controls or features? https://github.com/unoplatform/workshops-private/issues/9 -->          

## Modules

- [01 - Getting started](xref:Workshop.TubePlayer.GetStarted)  
    Get started with Uno Platform - set up the environment, and create a project using the template wizard or the dotnet new template.  
- [02 - Creating basic UI layout with C# Markup](xref:Workshop.TubePlayer.BasicLayout)  
    Use C# Markup to create the basic UI for the search page. This will comprise a `Grid` containing a `TextBox` which will be used to search for YouTube videos, as well as an `ListView` which will display results. 
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