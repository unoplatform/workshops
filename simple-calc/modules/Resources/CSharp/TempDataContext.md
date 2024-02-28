Now let's create a temporary class to serve as a placeholder for the DataContext. We'll discuss this further in the Architecture module. Add the following `TempDataContext` class:

```csharp
public class TempDataContext
{
    public bool IsDark { get; set; }
    public ICommand? InputCommand { get; set; }
    public Calculator Calculator { get; } = new Calculator();
}
```