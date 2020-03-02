---
title: General information
menu_order: 3
---

# General information

Ionide is complex tool with many options, and powerful capabilities, supporting multiple scenarios available to F# developers. As such is crucial to learn some general information about Ionide's requirements, and different configuration options that should be used depending on the different runtime and environments that can be used.

### Getting Requirements

* F# (Windows) - Easiest way to install latest versions of F# on Windows is using [VS Build Tools 2017](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017#build-tools-for-visual-studio-2017). If you use VS 2017, make sure that you've installed workload adding F# support.

* F# (Linux/MacOS) - F# on non-Windows platform is distributed as part of the `mono`. Installation guide and recent version of `mono` can be found on the [project webpage](https://www.mono-project.com/download/stable/) and on the F# Software Foundation ["Use on Linux" page](https://fsharp.org/use/linux/)

* .Net Core SDK - .Net Core is modern, cross platform implementation of .Net Framework. Ionide is requiring it for set of features such as project modifications or debugging. The core part of SDK is `dotnet` CLI tool that provides easy way to create, build and run F# projects. What's important - the `dotnet` tool can be used also to create applications targeting also Full Framewok (like `net461`). For detailed instructions on installing .Net Core visit [official step-by-step installation guide](https://www.microsoft.com/net/core)

* VSCode C# plugin (optional) - Ionide's debugging capabilities relies on the debugger provided by Omnisharp team. To get it install [C# extension from VSCode marketplace](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

* MsBuild 2015 (Windows only, optional) - For old, verbose `.fsproj` files on Windows MsBuild 2015 (14.0) needs to be additionally installed. You can download it [here](https://www.microsoft.com/en-us/download/details.aspx?id=48159). However, we highly recommend using new, SDK-based project files.

### Project files parsing

Ionide supports both old, verbose project files, and new SDK based files. However, we **strongly recommend** using SDK based project files. Plugin is also supporting parsing `.sln` files. When you open VSCode in particular workspace, Ionide will try to find all `.sln` files in this workspace and you will be presented with the option to open particular solution, or ignore solution files and load all projects in the solution.

<img class="gif" src="/static/images/chooseSolution.png" />


When Ionide detects any F# projects it will display them in the `Solution Explorer`. To access it you need to press F# logo button on the activity bar. In there you will see list of F# projects, their status, list of file and references. You can also right-click on different nodes in the tree to access operations that can be performed by the Ionide, such as `Build Project` or `Add file`.

<img class="gif" src="/static/images/projectExplorer.png" />

> NOTE: In case of the problems with project parsing (Projects in status `loading failed`) you can right-click on the project node and use `Show Project Status` to see more details about the problem. We also recommend using `F#: Clear Cache` action and reloading the window, as first step in debugging any problems.

### FsAutoComplete Service Runtime

The Ionide plugin relies on the F# compiler services for processing code in the editor.  The compiler services can run under the full framework (requiring `mono` on non-Windows platforms) or they can run under .NET Core as of Ionide 3.13.0.  This experimental feature can be enabled in the user settings.

`Preferences > Settings` and add a new setting
```json
"FSharp.fsacRuntime": "netcore"
```

There are two options:

* `netcore` (default) .NET Core framework
* `net`  full framework

After updating this setting, execute the `Reload Window` command in VS Code for the setting to take effect.

> NOTE: projects that use functionality incompatible with .NET Core, such as type providers, require this be set to `net` in order for the F# Autocomplete Service to process code using these features.

### MsBuild Host

The Ionide plugin provides deep integration with MsBuild - starting from project parsing (process of getting list of files, references and properties out of `fsproj` file) through project modifications (adding new files, ordering them, adding project-to-project references) to building and running projects. All features provided by Ionide in area of project management are described more in [Project](project) section.

Ionide can use either MsBuild installation provided by Full Framework (installed by VS / VS Build Tools on Windows and by Mono on Linux/MacOS) or the cross platform version of MsBuild provided by .Net Core SDK. In most cases Ionide makes automatic decision which one to use based on the type of project file, but projects that use functionality incompatible with .NET Core, such as type providers not updated to latest TP SDK, require using Full Framework installation of MsBuild.

To control MsBuild Host that's used by Ionide you need to go to the F# Solution Explorer view and use `F#: Pick MsBuild Host` action

<img class="gif" src="/static/images/pickMsBuildHost.png" />