# Working with Uno

## 📖 Overview

The Uno Platform is an open source project that is released under the permissive [Apache 2.0 license][apache2-license]. The source code is provided to you and you can do whatever you like with it, provided [you comply with the license terms][apache2-license] - eg. preservation of copyright and license notices, release of liability and warranty.

If you choose to use the Uno Platform (and we sincerely hope you do) it's important that you know how to work with the internals of the Uno Platform as, without [a commercial support agreement in place][commercial-support], the Uno Platform is provided to you under a "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND basis. This is true for all open-source projects. Unfortunately, [too many organizations forget this][billion-dollar-problem] and inadvertently [damage open-source software projects][support-your-supply-chain].

If your organization requires a deeper level of support beyond our community support, please [contact us][commercial-support]. Our professional support is more than a contract – it is a shared responsibility for your project success. Our engineering team will collaborate with you to ensure the success of your projects, and our custom application development team at nventive is also available to lend its expertise.

This module will introduce to the internals of the Uno Platform code-base. The team has built in plenty of escape hatches that enables you to be autonomous without being dependant on pull-requests being merged. We hope that that this knowledge will enable you to become self-reliant, to not [push your pull-requests][dont-push-your-pull-requests] if you are ever caught in a jam and ultimately become a regular contributor to the open-source project. A growing open-source project is a healthy open-source project. 💖

## 💡 Walk through the code base

### What's implemented

1. 🎯 Visit [uno/src/Uno.UI/Generated][src-unoui-generated] to learn what features are implemented and consumed by the program that generates the Uno Platform's documentation.
1. 📚 What is `Uno.NotImplemented`? Note that you can make not implemented APIs fatal exceptions by setting `ApiInformation.IsFailWhenNotImplemented = true`.
1. 📚 What is the UWP Sync Generator?
1. 📚 What is the purpose of the Generated folder?

### UI implementations

1. 🎯 Visit the source code of where XAML controls can be found - [uno/src/Uno.UI/UI/Xaml][src-unoui-ui-xaml]. 
2. 🎯 Note usage of partial classes and the naming the convention of `MyControl.cs`, `MyControl.iOS.cs`, `MyControl.Droid.cs`, `MyControl.wasm.cs`.

### Source code generation

1. 🎯 Visit the source code at [uno/src/SourceGenerators][src-sourcegenerators]
1. 🎯 Read https://github.com/unoplatform/uno/pull/1241/files

### Integration Tests

1. 🎯 Visit [the samples app][samples-app-wasm] which is deployed from `master` after every commit.
1. 🎯 Visit source code at [uno/src/SamplesApp][src-samples-app]
1. 📚 If you contribute a pull-request, then we [expect tests][src-content-dialog-tests] to be included. This is our north star golden example of automated integration test w/droid, ios, wasm heads and screenshot targeting

### Visual Studio Solution Filters

Visual Studio 2019 introduced a new feature called [solution filtering][solution-filters] which allows developers to load a subset of projects in a solution. The Uno Platform has solution filters for each one of the target framework monikers (also referred by the team as heads):

* `Uno.UI-Android-only.slnf`
* `Uno.UI-UnitTests-only.slnf`
* `Uno.UI-Wasm-only.slnf`
* `Uno.UI-Windows-only.slnf`
* `Uno.UI-iOS-only.slnf`

When contributing to the Uno Platform or changing Uno's internals we highly recommend that you load just the subset that you need instead of loading the full `Uno.UI.sln` solution. Loading a subset of projects in a solution dramatically decreases solution load, build, and test run time, and enables you to be more productive. The team also recommend enabling the cross targeting override (see below) if appropriate.

### Cross Targeting Override

One of the biggest productivity improvements, apart from using Visual Studio Solution Filters, is usage of the [cross targeting override][src-crosstargeting-override] escape hatch. It can be enabled by renaming `crosstargeting_override.props.sample` to `crosstargeting_override.props`.

There are two key knobs in the cross-targeting override:

1. Controlling which platforms are built by Visual Studio.
2. Overriding your local NuGet cache.

#### Controlling which platforms are built by Visual Studio

Unfortunately, Visual Studio for Windows does not support incremental builds on a per target framework moniker (TFM) basis and builds all target framework monikers referenced in an project if build is required. Which means, if you load the Uno Platform via the `Uno.UI-Android-only.slnf` solution filter with the intention of only making changes to the Android platform and make a change to a project that defines multiple target framework monikers defined, such as `Uno.UI` Visual Studio for Windows will compile the `iOS`, `WebAssembly` and `UWP` heads.

Inside of the [cross targeting override file][src-crosstargeting-override], you'll find a property called `UnoTargetFrameworkOverride` which provides you with a way to selectively choose which target framework monikers are compiled by Visual Studio for Windows.  It's really important that you close Visual Studio for Windows before making changes to `UnoTargetFrameworkOverride`. Ensure that you do or Visual Studio for Windows may become unresponsive.

```xml
<!--
    This property controls the platform built by Visual Studio.
    
    Available build targets:
                            uap10.0.17763 (Windows)
                            xamarinios10 (iOS)
                            MonoAndroid90 (Android 9.0)
                            netstandard2.0 (WebAssembly)
                            net461 (Tests)

    Only one target can be built, and the corresponding solution filter must
    be loaded in Visual Studio (see next to Uno.UI.sln).

    *** WARNING ***
    Note that changing that property while the solution is opened leads to
    unstable nuget restore operations, and Visual Studio instabilities such
    as caching issues or crashes.

    Always unload the solution before changing or activating this property.
    *** WARNING ***
-->
<!--<UnoTargetFrameworkOverride>netstandard2.0</UnoTargetFrameworkOverride>-->
```

Thus, if you wanted to hack on the internals of the Uno Platform for Android:

* Close Visual Studio for Windows.
* Enable the  [cross targeting override][src-crosstargeting-override] escape hatch.
* Change `<UnoTargetFrameworkOverride>` to `<UnoTargetFrameworkOverride>MonoAndroid90</UnoTargetFrameworkOverride>`.
* Open the `Uno.UI-Android-only.slnf` solution filter in Visual Studio for Windows.

#### Overriding your local NuGet cache

Inside of the [cross targeting override file][src-crosstargeting-override] you'll find a property called `UnoNugetOverrideVersion` which provides you with a way to generate a NuGet package at a specific version. If this version is found in your local NuGet cache then it will be overridden. This escape hatch is extremely useful and we wish that this feature existed in NuGet, Visual Studio and .NET.

Imagine you have an application that references `Uno.UI` at version `v1.45.0` and there's something in that particular version of the Uno Platform that needs to change because it's blocking you from shipping your application to your customers.

By enabling `<UnoNugetOverrideVersion>1.45.0</UnoNugetOverrideVersion>` and building from source you'll never be in a situation where you are blocked waiting for pull-requests to be merged and a release to be cut. Here's how you do it:

* Clone Uno and checkout the appropriate commit (or from `master` if adding new functionality) of the source code.
* Enable the escape hatch using the version defined in your application.
* Make the changes you need locally and build the Uno Platform.
* `UnoNugetOverrideVersion` will override the version in your local NuGet cache.
* Your application can then consume the changes without needing to update the application.

```xml
<!-- 
This property allows the override of the nuget local cache.
Set it to the version you want to override, used in another app.
You will see the override path in the build output.
The packages are located under this directory: "%USERPROFILE%\.nuget\packages".
-->
<!--<UnoNugetOverrideVersion>1.45.0</UnoNugetOverrideVersion>-->
```

## 🎯 Vendoring Uno

1. Fork the Uno Platform source code from GitHub.
1. Configure the nuget package override to use same version used in the Todo app.
1. Make the required changes to the Uno Platform source code.
1. Commit your changes to your fork of the Uno Platform.
1. Build the Uno Platform in Visual Studio for Windows.
1. Load the Todo application in Visual Studio for Windows.

## 🎯 Source level step debugging

1. Clone the Uno Platform source code from GitHub.
1. Configure the nuget package override to use same version used in the Todo app.
1. Build the Uno Platform in Visual Studio for Windows.
1. Load the Todo application in Visual Studio for Windows.
1. Set debug points, step in and out.


### 🎯 Debugging the source generator

1. Create a side app and note which version of `Uno.UI` is used as a `PackageReference`
1. [Override](https://github.com/unoplatform/uno/blob/7f003e13f34f899a4b9ac04552317920f961247a/src/crosstargeting_override.props.sample#L45) the nuget package cache and use the same version for `Uno.UI` as is used in the side app.
1. Build the side application which will start an initial `Uno.SourceGenerationHost.exe` process
1. Attach to all the `Uno.SourceGenerationHost.exe` processes (there may be many) from the `Uno.UI` solution
1. Rebuild the side app
1. Your breakpoints in the source generators will hit
1. Output from the generator is stored at `obj\Debug\netstandard2.0\g\XamlCodeGenerator`
1. If you need to restart debugging after making significant code changes to the source generator then make sure you terminate all existing processes (`taskkill /fi "imagename eq Uno.SourceGeneration.Host.exe" /f /t`) in between development iterations.

## 📚 Additional Reading Material

**Commercial Support**:

If your organization requires a deeper level of support beyond our community support, please [contact us][commercial-support]. Our professional support is more than a contract – it is a shared responsibility for your project success. Our engineering team will collaborate with you to ensure the success of your projects, and our custom application development team at nventive is also available to lend its expertise.

**Key areas of the Uno Platform source-code**:

* What's implemented: [uno/src/Uno.UI/Generated][src-unoui-generated]
* UI implementations: [uno/src/Uno.UI/UI/Xaml][src-unoui-ui-xaml]
* Source code generation: [uno/src/SourceGenerators][src-sourcegenerators]
* Integration Tests: [uno/src/SamplesApp][src-samples-app]
* Visual Studio Solution Filters: [uno/src/*.slnf][src-solution-filters]
* Productivity tricks, vendoring and monkey patching: [uno/src/crosstargeting_override.props.sample][src-crosstargeting-override]

**Visual Studio Features and Extensions**:

* [Filtered solutions in Visual Studio][solution-filters].
* [MSBuild Binary and Structured Log Viewer](http://msbuildlog.com/).
* [Microsoft Child Process Debugging Power Tool](https://marketplace.visualstudio.com/items?itemName=vsdbgplat.MicrosoftChildProcessDebuggingPowerTool).

**Open-Source Sustainability**:

* Report: [Roads and Bridges: The Unseen Labor Behind Our Digital Infrastructure][roads-and-bridges-report]
* Conference Talk: [If you haven’t secured your supply chain, you're negligent][support-your-supply-chain]
* Conference Talk: [Rebuilding the Cathedral][rebuilding-the-cathedral]
* Conference Talk: [Open-Source Maintainers are Jerks!][open-source-maintainers-are-jerks]

<!-- ## ⏭️ What's next -->

<!-- in-line links -->
[previous-module]: ../06-Performance-is-a-feature/README.md
[next-module]: ../04-Create-rich-responsive-UIs/README.md

[commercial-support]: https://platform.uno/contact/
[apache2-license]: https://choosealicense.com/licenses/apache-2.0/
[billion-dollar-problem]: https://github.com/Fody/PropertyChanged/issues/270#issuecomment-320150972
[dont-push-your-pull-requests]: https://www.igvita.com/2011/12/19/dont-push-your-pull-requests/

[src-solution-filters]: https://github.com/unoplatform/uno/blob/master/src/Uno.UI-Wasm-only.slnf
[src-crosstargeting-override]: https://github.com/unoplatform/uno/blob/master/src/crosstargeting_override.props.sample
[src-samples-app]: https://github.com/unoplatform/uno/tree/master/src/SamplesApp
[src-sourcegenerators]: https://github.com/unoplatform/uno/tree/master/src/SourceGenerators
[src-unoui-generated]: https://github.com/unoplatform/uno/tree/master/src/Uno.UI/Generated/3.0.0.0
[src-unoui-ui-xaml]: https://github.com/unoplatform/uno/tree/master/src/Uno.UI/UI/Xaml
[src-content-dialog-tests]: https://github.com/unoplatform/uno/blob/master/src/SamplesApp/SamplesApp.UITests/Windows_UI_Xaml_Controls/ContentDialog/UnoSamples_Tests.ContentDialog.cs

[samples-app-wasm]: https://unoui-sampleapp-unoui-sampleapp-staging.azurewebsites.net/

[solution-filters]: https://docs.microsoft.com/en-us/visualstudio/ide/filtered-solutions?view=vs-2019

[roads-and-bridges-report]: https://www.fordfoundation.org/about/library/reports-and-studies/roads-and-bridges-the-unseen-labor-behind-our-digital-infrastructure/
[support-your-supply-chain]: https://www.youtube.com/watch?v=0t85TyH-h04
[open-source-maintainers-are-jerks]: https://www.youtube.com/watch?v=Mm_RuObpeGo
[rebuilding-the-cathedral]: https://www.youtube.com/watch?v=VS6IpvTWwkQ
