---
title: Editing evolved
menu_order: 4
---
# Editing evolved

Ionide provides a variety of language features known from larger IDEs such as VS, and a set of innovative features that makes you more productive then ever when writing F# code like CodeLenses, integration with FSharpLint and Quick Fixes.

## Basic features

Following documentation is basic overview of features from Ionide's point of view. If you want to learn more about capabilities of VSCode visit [official documentation](https://code.visualstudio.com/docs/editor/codebasics). We strongly recommend exploring detailed VSCode documentation, especially if you've never worked with similar (Atom, ST3) editor before.

### IntelliSense

If Ionide knows possible completions, the IntelliSense suggestions will pop up as you type. If you continue typing characters, the list of members (variables, methods, etc.) is filtered to include only members containing your typed characters. Pressing `Tab` or `Enter` will insert the selected member.

You can trigger IntelliSense in any editor window by typing `Ctrl+Space` or by typing a trigger character (such as the dot character (`.`)).

> Tip: The suggestions widget supports CamelCase filtering meaning you can type the letters which are upper cased in a method name to limit the suggestions. For example, "cra" will quickly bring up "createApplication".

Additionally, Ionide provides autocompletion for symbols not defined in currently opened modules and namespaces. If you accept such completion with `Tab` or `Enter` it will automatically insert appropriate `open` statement. This behavior is controlled by `FSharp.externalAutocomplete` setting (default value is `true`).

---

Additionally, you can see quick info for each method by either pressing `Ctrl+Space` or clicking the info icon. The accompanying documentation for the method will now expand to the side. The expanded documentation will stay so and will update as you navigate the list. You can close this by pressing `Ctrl+Space` again or by clicking on the close icon.

<img class="gif" src="/static/images/autocomplete.gif" />

### Tooltips

Ionide provides rich information about the symbols you hover on - structured signature and nicely formatted documentation text supporting markdown inside of the comments and transforming standard XML comment tags into markdown representation.

> Tip: If you press `Ctrl` while hovering Ionide will also put the body of the symbol in the tooltip.

<img class="gif" src="/static/images/tooltips.gif" />


### Error highlighting

Ionide provides fast error highlighting for local changes, changes in current project and cross project changes without any need to build projects. Error highlighting for current projects works as you edit code, it supports files not saved to disk. For cross project error reporting you need to save the file - it will queue background project type checking which will provide errors asynchronously without blocking any editor operations.

Errors in VSCode are shown in multiple places:

* In the status bar, there is a summary of all errors and warnings counts.
* You can click on the summary or press `Ctrl+Shift+M` to display the `PROBLEMS` panel with a list of all current errors.
* If you open a file that has errors or warnings, they will be rendered inline with the text and in the overview ruler.

> Tip: To loop through errors or warnings in the current file, you can press `F8` or `Shift+F8` which will show an inline zone detailing the problem and possible code actions (if available).

<img class="gif" src="/static/images/errors.gif" />


### CodeLens and LineLens

Ionide displays type signatures of the symbols either as information over the symbol (inserting virtual line) or as inlined information next to symbol. The behavior is customizable with `editor.codeLens`, `FSharp.lineLens.enabled` and `FSharp.lineLens.*` settings.

### Inlay hints

Ionide provides Inlay Hints that call out the types of let-bindings, as well as the parameter names of method parameters.

### Quick Info panel

You can check the type of symbol on which cursor currently is in the left part of VSCode Status Bar (bottom bar with different additional information about current position and file)

### Generate record stubs

You can generate record stubs by using the `Quick Fix` feature (Default keyboard shortcut is `Ctrl+.`). The feature is activated in two ways:

* Using a type hint ```let p : Person = { }``` with the cursor over `Person`
* Starting to type the fields of the record

<img class="gif" src="/static/images/generateRecordStubs.gif" />

### Generate pattern matching stubs

You can generate pattern matching stubs by using the `Quick Fix` feature (Default keyboard shortcut is `Ctrl+.`).

### Generate object expression implementation stub

You can generate object expression implementation stub by using the `Quick Fix` feature (Default keyboard shortcut is `Ctrl+.`).

### Smart debug configurations

Ionide generates Debugging Launch Configurations for runnable projects in your workspace. These can be extracted at any time to be a good starting point for any customizations you'd like to make. In addition, if your projects support [launchSettings.json](https://docs.microsoft.com/aspnet/core/fundamentals/environments?view=aspnetcore-6.0#development-and-launchsettingsjson), Ionide will generate a launch configuration for each launch profile with `"commandName"` of `'Project'` that you have configured.  This allows you to share launch configurations across VS Code, Visual Studio, JetBrains Rider, and the dotnet CLI via the `dotnet run` command.

## Code navigation

Visual Studio Code has a high productivity code editor which, when combined with programming language services, gives you the power of an IDE and the speed of a text editor. In this part we will show different ways of navigating around the code.

### Go to definition

Ionide provides going to symbol definition. You can do that by pressing `F12`, pressing right click on symbol and choosing `Go to definition` or by using `Ctrl+Click` or running `Go to definition` from Command Palette.

> Tip: You can use `Ctrl+Alt+Click` or open the definition to the side in additional editor panel.

### Go to type definition

Ionide provides going to definition of the type of current symbol if the type was defined in local workspace. You can do that by running the `Go to Type Definition` command from either the editor context menu or the Command Palette.

> Tip: The command `editor.action.goToTypeDefinition` is not bound to a keyboard shortcut by default but you can add your own custom keybinding.

### Go to symbol in file

You can navigate symbols inside a file with `Ctrl+Shift+O`. Just press `Up` or `Down` and navigate to the place you want.

> Tip: By typing `:` the symbols will be grouped by category.

### Go to symbol in workspace

Ionide support jumping to a symbol across files with `Ctrl+T`. Just type the first letter of a symbol you want to navigate to, regardless of which file contains it, and press `Enter`.

<img class="gif" src="/static/images/goToSymbol.gif" />

### Find all references & Peek definition

Ionide also implements providers for finding all references (`Shift+F12`) of the symbol in currently open solution and peeking definition of the symbol (`Alt+F12`). VSCode provides peeked editors which enables you to see the source code of the other file inlined without switching context. You can navigate between different references in the peeked editor and make quick edits right there. Clicking on the peeked editor filename or double-clicking in the result list will open the reference in the outer editor.

<img class="gif" src="/static/images/peek.gif" />

### Bracket matching

Matching brackets will be highlighted as soon as the cursor is near one of them.

> Tip: You can jump to the matching bracket with `Ctrl+Shift+\`

### Go to next symbol usage

Usages of symbol in current file will be highlighted as soon as the cursor is on the symbol.

> Tip: You can jump to the next/previous usage with `F7` and `Shift+F7`

### Go to MSDN help

Ionide provides command for opening MSDN documentation for given symbol. It works only for symbols from F# standard library, and .Net standard library. You can execute command with `Shift+F1` or from Command Palette (`F#: Get Help`).

### CodeOutline panel

Ionide provides live updated panel showing symbols in current file. It's available as a additional tree view (`F# Code Outline`) in VSCode Explorer panel. On the panel you can notice 2 buttons - right one collapse (`Click`) or extends (`Alt+Click`) all elements in the tree, left one refreshes default collapsing (only modules and namespaces extended, types collapsed).

> Tip: Clicking on any node in the tree will move you to the place in file where symbol is defined. It's really useful for navigating around huge files.

<img class="gif" src="/static/images/codeOutline.gif" />

## Advanced analyzers

### FSharpLint integration

Ionide incorporates the [FSharpLint](https://fsprojects.github.io/FSharpLint/) project, which allows you to run linting rules against your code and see the results in your editor.

### Unused value analyzer

Ionide will detect unused values in your code and suggest that you remove them.

### Unnecessary open statement analyzer

Ionide will detect namespaces and modules that you've `open`ed in your code that aren't being used, and suggest that you remove them.

### Simplify name analyzer

If you've over-qualified a name, for example if you've typed `System.IO.FileInfo` when you already had `System.IO` open, Ionide will suggest a codefix that removes the unnecessary portion of the name.

## Refactoring

### Rename symbol

Ionide supports renaming of bindings, parameters, and so on.

### Code Fixes

Ionide supports a host of code fixes. They can all be invoked by using the light bulb icon that appears when they are available.

* Add an explicit type to a function parameter
* Add a `fun` keyword to a lambda that was written without one
* Add a missing 'self' identifier parameter to a method that needs one
* Add a missing `rec` keyworkd to a recursive function that doesn't have one
* Add an explicit type annotation to a parameter that throws an indeterminate type error (errors 72 or 3245)
* Change C#-style use of `=` for assignment to `<-` instead
* Change C#-style use of `=>` for a lambda to `->` instead
* Change uses of `typeof<'t>.Name` to use `nameof('t)` instead
* Change use of `=` in record field declarations to `:`
* Change C#-style use of `!=` to `<>` instead
* Change a record creation of an unknown type to use an anonymous record instead
* Change a positionally-matched DU to a named-match DU instead
* Change C#-style use of `==` for equality to `=` instead
* Change the declaration of a let-binding to `mutable` when a user attempts to mutate it later
* Add a missing `=` when you start a type declaration and rush past the name to the fields/union cases
* Convert negation of a value to subtraction instead when negation was not intended
* Suggest the use of `new` for disposable types
* Wrap an expression in parentheses when it is necessary to resolve parameter ambiguity
* Remove redundant qualifiers
* Change C#-style use of `!` for negation to use `not` instead
* Remove explicit `return` or `yield` commands inside a CE when the compiler thinks they are not necessary
* Change use of the `!` operator on ref cells to use `.Value` instead
* Offer to open modules/namespaces or use fully-qualified names when a type is used but the full name cannot be resolved
* Replace a potentially-typo'ed identifier name with one from a compiler-suggested list of possibilities
* Replace the use of unsafe downcast operations with safe casts operations when it is correct to do so

### Generate XML documentation comments

Ionide can generate XML documentation comments that scaffold out the relevant XML structures for your current function, member or value.