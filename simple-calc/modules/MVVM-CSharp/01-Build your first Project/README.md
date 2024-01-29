---
uid: Workshop.SimpleCalc.MVVM.CSharp.FirstProject
---
# Building your first project

## Creating your project

To create a new Uno app, there are two options available to developers. The first is to use Uno.Templates by invoking the `dotnet new` command, which provides a quick and straightforward way to get started with an Uno project. The second option is to use the Uno Platform Template Wizard, which provides a more guided approach to creating an Uno app.

In the following sections, we will cover both methods for creating a new Uno app, providing step-by-step instructions for each.

# [**Uno.Templates**](#tab/templates)

[!include[getting-help](uno-templates.md)]

# [**Wizard**](#tab/wizard)

[!include[getting-help](uno-wizard.md)]

***

> [!NOTE]
> After creating the SimpleCalculator application, open the Solution File (Visual Studio) or Solution Folder (Visual Studio Code) and ensure you can build and run the application.


## Prepare the Project

Before we continue to the next section, add the Calculator class by adding a new file called Calculator.cs into the SimpleCalculator project. Replace the default `Calculator` class with the following source code.

<details>
    <summary><i>Calculator.cs</i> code contents (collapsed for brevity)</summary>

[!code-csharp[Calculator.cs](../../../resources/Calculator.cs)]
</details>

## Additional Resources

- [C# Markup Docs](https://aka.platform.uno/csharp-markup)

## Next Steps

Next, we'll add the design to our Simple Calculator. You can choose to bring in the UI from the Uno Figma Plugin and import it, or you can directly add the code to the project without exporting it.

**[Previous](xref:Workshop.SimpleCalc.GettingStarted) | [Import UI from Figma](xref:Workshop.SimpleCalc.MVVM.CSharp.Figma) or [Creating the Layout](xref:Workshop.SimpleCalc.MVVM.CSharp.CreatingLayout)**
