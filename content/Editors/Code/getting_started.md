---
title: Getting started
menu_order: 2
---

# Getting started

## Requirements

* Visual Studio Code - it is a lightweight but powerful source code editor which runs on your desktop and is available for Windows, macOS and Linux created by Microsoft. For detailed documentation of editor, getting-started guides and more visit [official documentation](https://code.visualstudio.com/docs).

* F# - it is a mature, open source, cross-platform, functional-first programming language. It empowers users and organizations to tackle complex computing problems with simple, maintainable and robust code. Ionide supports F# version 6.0. Detailed installation instructions can be found of F# Software foundation webpage - for [Windows](http://fsharp.org/use/windows/), [MacOS](http://fsharp.org/use/mac/), and [Linux](http://fsharp.org/use/linux/)

* .NET SDK - .NET is lightweight, cross platform, modern implementation of .NET Framework. We strongly recommend installing it since some advanced Ionide features such as debugging and project scaffolding depends on SDK and `dotnet` CLI tooling even if your application is targetting Full Framework. For detailed instructions on installing .NET visit [official step-by-step installation guide](https://dotnet.microsoft.com/download)

* VSCode C# plugin (optional) - Ionide's debugging capabilities relies on the debugger provided by Omnisharp team. To get it install [C# extension from VSCode marketplace](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

* MsBuild 2015 (Windows only, optional) - For old, verbose `.fsproj` files on Windows MsBuild 2015 (14.0) needs to be additionally installed. You can download it [here](https://www.microsoft.com/en-us/download/details.aspx?id=48159). However, we highly recommend using new, SDK-based project files.

## Plugin installation

Any VSCode extension can be installed using UI just inside VSCode. Bring up the Extensions view by clicking on the Extensions icon in the Activity Bar on the side of VS Code or the `View: Extensions` command (`Ctrl+Shift+X`). Then in search box type `Ionide` to find all 3 extensions we provide. Click the `Install` button and after a successful install, you'll see an `Reload` button which will prompt you to restart VS Code to enable the new extension. For more detailed information about plugin installation visit [VSCode documentation](https://code.visualstudio.com/docs/editor/extension-gallery)

## Plugin activation

VSCode plugins are running in external processes (which means they should never impact editor performance) and are activated lazily, when certain activation events happens. This means that plugins are not loaded unnecesserly, for example when you don't work on project using given programming language.

Ionide plugins are activated when:

* Opened workspace contains any `.fsproj`, `.fs`, or `.fsx` file

* New `.fsproj`, `.fs`, or `.fsx` file is created in workspace that was not containing those files before.
