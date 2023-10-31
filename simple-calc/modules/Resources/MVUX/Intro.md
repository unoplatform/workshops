---
uid: Workshop.SimpleCalc.MVUX.Architecture.Intro
---

# Model-View-Update (MVUX)

Model-View-Update has become an increasingly popular choice for developers looking to have a more functional approach to building user interfaces. In this module, we will be looking at how to use the MVUX pattern to build our UI. MVUX is a pattern that is similar to the MVU pattern but has been specifically designed to work with data binding.

To learn more about MVUX, refer to the [MVUX Overview](https://platform.uno/docs/articles/external/uno.extensions/doc/Overview/Reactive/overview.html).

## Getting Started

Create a new record called `MainModel` using the following code that creates two `IState` properties that represent whether the application is using the dark theme (`IsDark`) and the current `Calculator` instance:

```cs
namespace SimpleCalculator;

public partial record MainModel
{
    public MainModel()
    {
        Calculator = State.Value(this, () => new Calculator());
        IsDark = State<bool>.Value(this, () => false);
    }

    public IState<bool> IsDark { get; }

    public IState<Calculator> Calculator { get; }

    public async ValueTask InputCommand(string key, CancellationToken ct) =>
        await Calculator.Update(c => c?.Input(key), ct);
}
```

## Binding to properties in the UI

With our model created we will now need to set up our DataContext and create some bindings.
