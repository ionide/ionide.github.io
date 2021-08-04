---
title: Customization
menu_order: 5
---

# Customizing Ionide

## Table of Contents

* [How to set an option](#how-to-set-an-option)
* [Ionide Settings](#ionide-settings)
* [Theming](#theming)

## How to set an option?

It is easy to configure Visual Studio Code to your liking through its various settings. Nearly every part of VS Code's editor, user interface, and functional behavior has options you can modify.

VS Code provides two different scopes for settings:

* **User Settings** - Settings that apply globally to any instance of VS Code you open.
* **Workspace Settings** - Settings stored inside your workspace and only apply when the workspace is opened.

Workspace settings override user settings. Workspace settings are specific to a project and can be shared across developers on a project.

> Note: A VS Code "workspace" is usually just your project root folder

To open your user and workspace settings, use the following VS Code menu command:

* On Windows/Linux - `File > Preferences > Settings`
* On macOS - `Code > Preferences > Settings`

You can also open the Settings editor from the Command Palette (`Ctrl+Shift+P`) with `Preferences: Open Settings` or use the keyboard shortcut (`Ctrl+,`).

Read more about settings in VSCode in [VSCode documentation](https://code.visualstudio.com/docs/getstarted/settings)

---

## Ionide Settings

#### `FSharp.fsac.dotnetArgs`

Additional CLI arguments that will be provided to the dotnet runtime when running FSAC

**Type:** `string []`

**Default:** `[ ]`

> Note: to enable .Net 6 support for FSAC at the present time, you should set this option to specify the .net 6 runtime specifically:
>
> ```json
>   "FSharp.fsac.dotnetArgs": ["--fx-version", "<dotnet runtime version>"]
> ```
>
> The specific version you should pick can be found by running the `dotnet --list-runtimes` command:
> 
> ```
> Microsoft.AspNetCore.App 5.0.7 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
> Microsoft.NETCore.App 6.0.0-preview.6.21352.12 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]
> ```
>
> Here, you would use the version `6.0.0-preview.6.21352.12`

---

#### `FSharp.fsac.netCoreDllPath`

The path to the `fsautocomplete.dll`, useful for debugging a self-built fsac.

**Type:** `string`

**Default:** ` `

---

#### `FSharp.fsac.attachDebugger`

Appends the '--attachdebugger' argument to fsac, this will allow you to attach a debugger.

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.fsac.silencedLogs`

An array of log categories for FSAC to filter out. These can be found by viewing your log output and noting the text in between the brackets in the log line. For example, in the log line `[16:07:14.626 INF] [Compiler] done compiling foo.fsx`, the category is 'Compiler'.

**Type:** `string []`

**Default:** `[ ]`

---

#### `FSharp.workspaceModePeekDeepLevel`

The deep level of directory hierarchy when searching for sln/projects

**Type:** `int`

**Default:** `4`

---
#### `FSharp.fsiFilePath`

The path to the F# Interactive tool used by Ionide-FSharp (.NET framework only, on .NET Core `FSharp.fsiSdkFilePath` is used)

**Type:** `string`

**Default:** ` `

---
#### `FSharp.fsiSdkFilePath`

The path to the F# Interactive tool used by Ionide-FSharp (when using .NET SDK scripts)

**Type:** `string`

**Default:** ` `

---


#### `FSharp.keywordsAutocomplete`

Includes keywords in autocomplete

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.externalAutocomplete`

Includes external (from unopened modules and namespaces) symbols in autocomplete

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.linter`

Enables integration with [FSharpLint](https://fsprojects.github.io/FSharpLint/) for additional (user-defined) warnings

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.unionCaseStubGeneration`

Enables a codefix that generates missing union cases when in a match expression

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.unionCaseStubGenerationBody`

The expression to fill in the right-hand side of match cases when generating missing cases for a match on a discriminated union

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.recordStubGeneration`

Enables a codefix that will generate missing record fields when inside a record construction expression

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.recordStubGenerationBody`

The expression to fill in the right-hand side of record fields when generating missing fields for a record construction expression

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.interfaceStubGeneration`

Enables a codefix that generates missing interface members when inside of an interface implementation expression

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.interfaceStubGenerationMethodBody`

The expression to fill in the right-hand side of interface members when generating missing members for an interface implementation expression

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.interfaceStubGenerationObjectIdentifier`

The name of the 'self' identifier in an interface member. For example, `this` in the expression `this.Member(x: int) = ()`

**Type:** `string`

**Default:** `this`

---

#### `FSharp.abstractClassStubGeneration`

Enables a codefix that generates missing members for an abstract class when in an type inheriting from that abstract class.

**Type:** `boolean`

**Default:** `true`

---

#### `FSharp.abstractClassStubGenerationObjectIdentifier`

The name of the 'self' identifier in an inherited member. For example, `this` in the expression `this.Member(x: int) = ()`

**Type:** `string`

**Default:** `this`

---

#### `FSharp.abstractClassStubGenerationMethodBody`

The expression to fill in the right-hand side of inherited members when generating missing members for an abstract base class

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.unusedOpensAnalyzer`

Enables detection of unused opens

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.unusedDeclarationsAnalyzer`

Enables detection of unused declarations

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.simplifyNameAnalyzer`

Enables detection of cases when names of functions and values can be simplified

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.fsiExtraParameters`

An array of additional command line parameters to pass to FSI when it is started. See [the documentation](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/fsharp-interactive-options) for an exhaustive list.

**Type:** `array`

**Default:** `[]`

---

#### `FSharp.saveOnSendLastSelection`

If enabled, the current file will be saved before sending the last selection to FSI for evaluation

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.msbuildAutoshow`

Automatically shows the MSBuild output panel when MSBuild functionality is invoked

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.resolveNamespaces`

Enables a codefix that will suggest namespaces or module to open when a name is not recognized

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.enableTreeView`

Enables the solution explorer view of the current workspace, which shows the workspace as MSBuild sees it

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.excludeProjectDirectories`

Directories in the array are excluded from project file search. Requires restart.

**Type:** `array`

**Default:** `[".git","paket-files",".fable","packages","node_modules"]`

---

#### `FSharp.lineLens.enabled`

Usage mode for LineLens. If `never`, LineLens will never be shown.  If `replaceCodeLens`, LineLens will be placed in a decoration on top of the current line.

**Type:** `enum`

**Possible values:**
 * `never`
 * `replaceCodeLens`
 * `always`

**Default:** `replaceCodeLens`

---

#### `FSharp.lineLens.prefix`

The prefix displayed before the signature in a LineLens

**Type:** `string`

**Default:** `//`

---

#### `FSharp.disableFailedProjectNotifications`

Disables popup notifications for failed project loading

**Type:** `bool`

**Default:** `false`

---


#### `FSharp.enableBackgroundServices`

Enables background services responsible for creating symbol cache and typechecking files in the background. Requires restart.

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.enableMSBuildProjectGraph`

EXPERIMENTAL. Enables support for loading workspaces with MsBuild's ProjectGraph. This can improve load times. Requires restart.

**Type:** `boolean`

**Default:** `false`

---

#### `FSharp.enableReferenceCodeLens`

Enables additional code lenses showing number of references of a function or value. Requires background services to be enabled.

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.showProjectExplorerIn`

Set the activity (left bar) where the project explorer view will be displayed. If `explorer`, then the project explorer will be a collapsible tab in the main explorer view, a sibling to the file system explorer. If `fsharp`, a new activity with the F# logo will be added and the project explorer will be rendered in this activity.Requires restart.

**Type:** `enum`

**Possible values:**
 * `explorer`
 * `fsharp`

**Default:** `fsharp`

---

#### `FSharp.enableAnalyzers`

EXPERIMENTAL. Enables F# analyzers for custom code diagnostics. Requires restart.

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.analyzersPath`

Directories in the array are used as a source of custom analyzers. Requires restart.

**Type:** `array`

**Default:** `["packages/Analyzers", "analyzers"]`

---

#### `FSharp.workspacePath`

Path to the directory or solution file that should be loaded as a workspace. If set, no workspace probing or discovery is done by Ionide at all.

**Type:** `string`

---

#### `FSharp.showExplorerOnStartup`

Automatically shows solution explorer on plugin startup

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.enableTouchBar`

Enables TouchBar integration of build/run/debug buttons

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.autoRevealInExplorer`

Controls whether the solution explorer should automatically reveal and select files when opening them. If `sameAsFileExplorer` is set, then the value of the `explorer.autoReveal` setting will be used instead.

**Type:** `enum`

**Possible values:**
 * `sameAsFileExplorer`
 * `enabled`
 * `disabled`

**Default:** `sameAsFileExplorer`

---

#### `FSharp.smartIndent`

Enables smart indent feature

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.infoPanelUpdate`

Controls when the info panel is updated

**Type:** `enum`

**Possible values:**
 * `onCursorMove`
 * `onHover`
 * `both`
 * `none`

**Default:** `onCursorMove`

---

#### `FSharp.infoPanelReplaceHover`

Controls whether the info panel replaces tooltips

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.infoPanelStartLocked`

Controls whether the info panel should be locked at startup

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.infoPanelShowOnStartup`

Controls whether the info panel should be displayed at startup

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.verboseLogging`

Logs additional information to F# output channel. This is equivalent to passing the `--verbose` flag to FSAC. Requires restart.

**Type:** `bool`

**Default:** `false`

---

#### `FAKE.targetsOutline`

Enables the Targets Outline tree view.

**Type:** `bool`

**Default:** `true`

---

#### `FAKE.showTargetsOutlineIn`

Set the activity (left bar) where the FAKE targets outline view will be displayed.Requires restart.

**Type:** `enum`

**Possible values:**
 * `explorer`
 * `fsharp`

**Default:** `explorer`

---

#### `FSharp.suggestGitignore`

Allow Ionide to prompt whenever internal data files aren't included in your project's .gitignore

**Type:** `bool`

**Default:** `true`

---
#### `FSharp.suggestSdkScripts`

Allow Ionide to suggest using .Net SDK FSI for scripting instead of .Net Framework FSI

**Type:** `boolean`

**Default:** `true`

---
#### `FSharp.useSdkScripts`

Use `dotnet fsi` instead of `fsi.exe`/`fsharpi` to start an FSI session

**Type:** `boolean`

**Default:** `true`

---

#### `FSharp.dotNetRoot`

Sets the root path for finding dotnet SDK references. Primarily used for FSX Scripts.

**Type:** `string`

---
#### `FSharp.addFsiWatcher`

Enables a panel for FSI that shows the value of all existing bindings in the FSI session

**Type:** `boolean`

**Default:** `false`

---
#### `FSharp.generateBinLog`

Enables generation of `msbuild.binlog` files for project loading. It works only for fresh, non-cached project loading. Run `F#: Clear Project Cache` and reload window to force fresh loading of all projects. These files can be loaded and inspected using the [MSBuild Structured Logger](https://github.com/KirillOsenkov/MSBuildStructuredLog)

**Type:** `boolean`

**Default:** `false`

---
#### `FSharp.pipelineHints.enabled`

Enables pipeline hints, which are like LineLenses that appear along each step of a chain of piped expressions

**Type:** `boolean`

**Default:** `true`

---
#### `FSharp.pipelineHints.prefix`

The prefix displayed before the signature of a pipeline hint

**Type:** `string`

**Default:** `  // `

---

## Theming

VS Code allows for very deep theming and customization, and Ionide plugs into this system excellently.
The Language Server performs advanced syntax highlighting and annotates the source code with [semantic tokens and modifiers](https://code.visualstudio.com/api/language-extensions/semantic-highlight-guide#standard-token-types-and-modifiers).
These tokens and modifiers can be themed individually in whatever way you want. For a deep dive on semantic tokens, including how
to find out which tokens and modifiers have been applied to source code that you want to theme, please see the [official documentation](https://code.visualstudio.com/docs/getstarted/themes#_editor-semantic-highlighting).

In addition to the standard set of tokens and modifiers shown on that documentation, Ionide provides several custom scopes and modifiers:

#### Scopes

* `member`- used in mutable vars and record fields, as well as exceptions, fields, events, delegates, and named arguments
* `cexpr` - for computation expressions
* `text` - for plaintext strings

#### Modifiers

* `mutable` - for any values that are defined as `let mutable`
* `disposable` - for any values that implement `System.IDisposable`


### Applying custom themes

Like all settings, theme customizations are stored in settings files, which are described at the top of this page in greater detail.

Semantic tokens can be overidden on a theme-by-theme basis in the following way:


```js
{
    "editor.semanticTokenColorCustomizations": {
      "[Default Dark+]": {
            "enabled": true,
            "rules": {
                "*.mutable": {
                    "foreground": "#FF0000",
                    "fontStyle": "underline",
                },
                "*.disposable": {
                    "foreground": "#ff8b2c",
                    "fontStyle": "bold"
                }

            }
        }
    }
}
```

A few things to note about this example:

* the individual theme names are placed into square brackets
* the `rules` are a map of `scope` or `modifier` to the theme settings to be applied to tokens that match
* the key of a `rule` can be
  * a fully-qualified scope (i.e. `<scope>.<modifier>`, for example `member.mutable`)
  * just a scope (i.e. `member`)
  * a wildcard modifier (i.e. `*.mutable` to apply to all mutables, regardless of scope)
