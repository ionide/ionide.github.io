---
title: List of options
menu_order: 5
---

# List of options

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

#### `FSharp.fsac.netCoreDllPath`

The path to the `fsautocomplete.dll`, useful for debugging a self-built fsac.

**Type:** `string`

**Default:** ` `

---

#### `FSharp.fsac.netExePath`

The path to the `fsautocomplete.exe`, useful for debugging a self-built fsac.

**Type:** `string`

**Default:** ` `

---

#### `FSharp.fsac.attachDebugger`

Appends the '--attachdebugger' argument to fsac, this will allow you to attach the debugger.

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.fsacRuntime`

Choose the runtime of FsAutocomplete (FSAC). Requires restart.

**Type:** `enum`

**Possible values:**
 * `net`
 * `netcore`

**Default:** `netcore`

---

#### `FSharp.workspaceModePeekDeepLevel`

The deep level of directory hierarchy when searching for sln/projects

**Type:** `int`

**Default:** `4`

---

#### `FSharp.monoPath`

The path to Mono executable

**Type:** `string`

**Default:** `mono`

---

#### `FSharp.fsiFilePath`

The path to the F# Interactive tool used by Ionide-FSharp

**Type:** `string`

**Default:** ` `

---

#### `FSharp.keywordsAutocomplete`

Includes keywords in autocomplete

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.externalAutocomplete`

Includes external (from unopen modules and namespaces) symbols in autocomplete

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.linter`

Enables integration with FSharpLinter (additional warnings)

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.unionCaseStubGeneration`

Enables pattern matching stub generation

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.unionCaseStubGenerationBody`

Generated pattern matching case default body

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.recordStubGeneration`

Enables record stub generation

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.recordStubGenerationBody`

Generated record field default body

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.interfaceStubGeneration`

Enables interface stub generation

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.interfaceStubGenerationMethodBody`

Generated member default body

**Type:** `string`

**Default:** `failwith \"Not Implemented\"`

---

#### `FSharp.interfaceStubGenerationObjectIdentifier`

Generated member default object identifier

**Type:** `string`

**Default:** `this`

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

Enables detection of symbols usages that can be simplified

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.fsiExtraParameters`

Allows to pass extra parameters to FSI process

**Type:** `array`

**Default:** `[]`

---

#### `FSharp.saveOnSendLastSelection`

Save Current file before send LastSelection to FSI

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.msbuildLocation`

Use a specific version of msbuild to build this project.

**Type:** `string`

**Default:** ` `

---

#### `FSharp.msbuildAutoshow`

Automatically shows MsBuild output panel

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.msbuildHost`

MSBuild host

**Type:** `enum`

**Possible values:**
 * `.net`
 * `.net core`
 * `ask at first use`
 * `auto`

**Default:** `auto`

---

#### `FSharp.resolveNamespaces`

Enables `resolve unopened namespaces and modules` code fix.

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.enableTreeView`

Enables solution explorer.

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.excludeProjectDirectories`

Directories in the array are excluded from project file search. Requires restart.

**Type:** `array`

**Default:** `[".git","paket-files",".fable","packages","node_modules"]`

---

#### `FSharp.lineLens.enabled`

Usage mode for LineLens

**Type:** `enum`

**Possible values:**
 * `never`
 * `replaceCodeLens`
 * `always`

**Default:** `replaceCodeLens`

---

#### `FSharp.lineLens.prefix`

The prefix displayed before the signature

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

#### `FSharp.enableReferenceCodeLens`

Enables additional code lenses showing number of references. Requires background services

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.showProjectExplorerIn`

Set the activity (left bar) where the project explorer view will be displayed.Requires restart.

**Type:** `enum`

**Possible values:**
 * `explorer`
 * `fsharp`

**Default:** `fsharp`

---

#### `FSharp.enableAnalyzers`

EXPERIMENTAL. Enables custom analyzers. Requires restart.

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.analyzersPath`

Directories in the array are used as a source of custom analyzers. Requires restart.

**Type:** `array`

**Default:** `["packages/Analyzers", "analyzers"]`

---

#### `FSharp.workspacePath`

Path to the directory or solution file that should be loaded as a workspace

**Type:** `string`

---

#### `FSharp.showExplorerOnStartup`

Automatically shows solution explorer on plugin startup

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.enableTouchBar`

Enables TouchBar integration

**Type:** `bool`

**Default:** `true`

---

#### `FSharp.autoRevealInExplorer`

Set the activity (left bar) where the project explorer view will be displayed.Requires restart.

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

Logs additional information to F# output channel. Requires restart.

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

#### `FSharp.useSdkScripts`

Use `dotnet fsi` instead of `fsi.exe`/`fsharpi`

**Type:** `bool`

**Default:** `false`

---

#### `FSharp.dotNetRoot`

Sets the root path for finding dotnet SDK references. Primarily used for FSX Scripts.

**Type:** `string`

---