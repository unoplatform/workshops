---
uid: Workshop.SimpleCalc.MVUX.Architecture.Feeds
---

## Feeds &amp; Commands

In addition to the `IState`, sometimes we may need to create composite properties and execute commands. MVUX makes this simple with the `IFeed` and automatically detects public methods for commands. SimpleCalc will not make use of `IFeed` as it is not needed, for more information on this topic, be sure to check out the documentation: [Using a FeedView](xref:Uno.Extensions.Mvux.HowToSimpleFeed).

The button inputs from the Calculator are handled via the `Input` method, which is exposed as an `ICommand` by MVUX.

With our UI updated, we can run the app again and press the buttons, resulting in a calculated output - We now have a functioning calculator.
