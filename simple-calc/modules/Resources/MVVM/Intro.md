---
uid: Workshop.SimpleCalc.MVVM.Architecture.Intro
---

# Model-View-ViewModel (MVVM)

Model-View-ViewModel is a well-established pattern for building applications. It is a pattern that is well suited to the Uno Platform and is a great way to build your apps. In this module, we will be looking at how to use the MVVM pattern to build our UI. If you have chosen MVVM as the app architecture, please note that the CommunityToolkit.MVVM package is already installed to assist us in constructing our UI. It is important to note that while we will be using the CommunityToolkit, there are a number of other MVVM Frameworks that you can employ with Uno Platform.

## Getting Started

To start off, we will need to create a new model called `MainViewModel` and add a couple of properties to it. We'll add two properties that we will then bind to in our View. The `IsDark` property will be used to toggle the application between light and dark theme. As such the property needs to be fully implementation to allow for changing the theme when the property is set. However, for our Calculator property we can simply provide the private backing field and let the source generator generate the boilerplate for the public-facing property by marking the private field with the `[ObservableProperty]` attribute.

```cs
public partial class MainViewModel : ObservableObject
{
    private bool _isDark;
    public bool IsDark
    {
        get => _isDark;
        set => SetProperty(ref _isDark, value);
    }

    [ObservableProperty]
    private Calculator _calculator = new();
}
```

## Binding to properties in the UI

With our ViewModel created we will now need to set up our `DataContext` and create some bindings.
