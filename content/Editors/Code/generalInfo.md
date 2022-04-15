---
title: General information
menu_order: 3
---

# General information

Ionide is complex tool with many options, and powerful capabilities, supporting multiple scenarios available to F# developers. As such is crucial to learn some general information about Ionide's requirements, and different configuration options that should be used depending on the different runtime and environments that can be used.

### Project files parsing

Ionide supports SDK-based project files and solutions only. When you open VSCode in particular workspace, Ionide will try to find all `.sln` files in this workspace, and you will be presented with the option to open particular solution or ignore solution files and load all projects in the solution.

<img class="gif" src="/static/images/chooseSolution.png" />

When Ionide detects any F# projects it will display them in the `Solution Explorer`. To access it you need to press F# logo button on the activity bar. In there you will see list of F# projects, their status, list of file and references. You can also right-click on different nodes in the tree to access operations that can be performed by the Ionide, such as `Build Project` or `Add file`.

<img class="gif" src="/static/images/projectExplorer.png" />

> NOTE: In case of the problems with project parsing (Projects in status `loading failed`) you can right-click on the project node and use `Show Project Status` to see more details about the problem. We also recommend using `F#: Clear Cache` action and reloading the window, as first step in debugging any problems.

### FsAutoComplete Service Runtime

The Ionide plugin relies on the F# compiler services for processing code in the editor. This requires the .NET SDK version 6.0.100 or greater to be installed on your machine.

### MsBuild Host

The Ionide plugin provides deep integration with MSBuild - starting from project parsing (process of getting list of files, references and properties out of `fsproj` file) through project modifications (adding new files, ordering them, adding project-to-project references) to building and running projects. All features provided by Ionide in area of project management are described more in the [Project](project) section.

Ionide uses the cross platform version of MsBuild provided by the installed .NET SDK.
