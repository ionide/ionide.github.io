---
title: dotnet-proj-info
menu_order: 3
---

# dotnet-proj-info

**GitHub link:** [https://github.com/ionide/dotnet-proj-info](https://github.com/ionide/dotnet-proj-info)
**License:** [MIT](https://github.com/ionide/dotnet-proj-info/blob/master/LICENSE)

`dotnet-proj-info` is library and command line tool used to parse and evaluate MsBuild files (`.fsproj`). It's used to get out of project files properties, list of files, list of project references, list of .Net references and more. It supports projects targeting both .Net Framework and .Net Core, using either old (verbose) project format or new (SDK-based) one. It's powering project cracking in [FsAutoComplete](/Tools/fsac.html) and solution explorer in [Ionide-VSCode](/Editors/vscode.html)

### How to use

Install with:

```bash
dotnet tool install -g dotnet-proj
```

and

```bash
dotnet proj --help
```

Usage:

```
dotnet-proj.

USAGE: dotnet-proj [--help] [--verbose] [<subcommand> [<options>]]

SUBCOMMANDS:

    prop <options>        get properties
    fsc-args <options>    get fsc arguments
    csc-args <options>    get csc arguments
    p2p <options>         get project references
    net-fw <options>      list the installed .NET Frameworks
    net-fw-ref <options>  get the reference path of given .NET Framework assembly

    Use 'dotnet-proj <subcommand> --help' for additional information.

OPTIONS:

    --verbose, -v         verbose log
    --help                display this list of options.
```

Subcommands support usual arguments of .NET cli (`dotnet`) where it makes sense, for example:

- the target project
- `-c` or `--configuration`
- `-f` or `--framework`
- `-r` or `--runtime`