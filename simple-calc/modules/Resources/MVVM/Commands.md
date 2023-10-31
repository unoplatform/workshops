---
uid: Workshop.SimpleCalc.MVVM.Architecture.Commands
---

## Commands

In addition to properties, sometimes we may need to create and execute commands. For this we will add a private Input method to our `MainViewModel` and mark it with the `RelayCommand` attribute. This will create a `RelayCommand` property named `InputCommand` that we can bind to in our UI.

```cs
public partial class MainViewModel : ObservableObject
{
    // Other properties left out for simplification

    [RelayCommand]
    private void Input(string key) =>
        Calculator = Calculator.Input(key);
}
```

With our UI updated we can run the app again and press the buttons. We should now have a fully functional Calculator.
