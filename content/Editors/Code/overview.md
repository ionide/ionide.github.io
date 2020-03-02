---
title: Overview
menu_order: 1
---

# Ionide-VSCode

**GitHub link:** [https://github.com/ionide/Ionide-vim](https://github.com/ionide/Ionide-vscode-fsharp)
**License:** [MIT](https://github.com/ionide/Ionide-vscode-fsharp/blob/master/LICENSE.md)

Ionide is a [Visual Studio Code](https://code.visualstudio.com/) package suite for cross platform F# development.

<img class="gif" src="/static/images/fsharp.gif" />

## Overview

Ionide for VSCode is set of 3 plugins avaliable in VSCode marketplace.

* [Ionide-fsharp](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp) - provides F# specific features including advanced editor features (autocomplete, go-to definition, tooltips, rename, various refactorings and quick fix suggestions), integration with .Net project system, project explorer for project file visualization and manipulation, integration with MsBuild for building and running applications, debugger integration and more.

<img class="gif" src="/static/images/fsi.gif" />


* [Ionide-Paket](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-Paket) - provides integration with Paket - package dependency manager for .NET with support for NuGet packages and GitHub repositories.

<img class="gif" src="/static/images/paket.gif" />

* [Ionide-FAKE](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fake) - FAKE (F# Make) is popular F# tool and DSL for build orchestration.

<img class="gif" src="/static/images/fake.gif" />

## List of features

#### F# IDE

* Syntax highlighting
* Error highlighting
* Autocomplete
* Tooltips
* Quick Info Toolbar
* Usages highlighting
* F# Interactive (REPL) panel
* Go-to declaration
* Finding symbols in file
* Go-to any symbol in solution
* Rename
* Find usages
* Peek View declaration
* CodeLens feature showing type signatures
* CodeOutline tree view
* Listing all errors in workspace
* Building using msbuild / xbuild
* Integration with .Net Core
* Project explorer tree view
* Debugging
* Record stub generation
* Union pattern case generation
* Integration with F# Interactive

#### F# Project management

* Integration with [Forge](/Tools/forge.html)
* Possibility to create new empty solutions or projects (multiple templates for most popular project types)
* Adding, removing, ordering files in project
* Adding and removing project references

#### Paket integration

* Paket initialization
* Adding, installing, updating packages from solution or current project (allows the choice of package version)
* Removing packages from solution or current project
* Converting from NuGet, simplify dependency graph, turning on auto-restore for solution.
* Listing outdated packages

#### FAKE integration

* Running any build target defined in FAKE build script
* Running default FAKE target

#### MSBuild/XBuild integration

* Build/Clean/Rebuild the current project
* Build/Clean/Rebuild any project in the current workspace
* Works with the most recent version of msbuild/xsbuild on your system, or supply your own

#### And much more...

