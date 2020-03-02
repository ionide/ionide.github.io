---
title: Fornax
menu_order: 2
---

# Fornax

**GitHub link:** [https://github.com/ionide/Fornax](https://github.com/ionide/Fornax)
**License:** [MIT](https://github.com/ionide/Fornax/blob/master/LICENSE)


Fornax is a **scriptable static site generator** using type safe F# DSL to define page layouts. This documentation has been built using Fornax.

## Installation

Fornax is released as a global .Net Core tool. You can install it with `dotnet tool install fornax -g`

## CLI Application

The main functionality of Fornax comes from CLI applications that lets user scaffold, and generate webpages.

* `fornax new` - scaffolds new blog in current working directory using really simple template
* `fornax build` - builds webpage, puts output to `_public` folder
* `fornax watch` - starts a small webserver that hosts your generated site, and a background process that recompiles the site whenever any changes are detected. This is the recommended way of working with Fornax.
* `fornax clean` - removes output directory and any temp files
* `fornax version` - prints out the currently-installed version of Fornax
* `fornax help` - prints out help

## Getting started

Easiest way to get started with `fornax` is running `fornax new` and than `fornax watch` - this will create fairly minimal blog site template, start `fornax` in watch mode and start webserver. Then you can go to the `localhost:8080` in your browser to see the page, and edit the scaffolded files in editor to make changes.
Additionally, you can take a look at `samples` folder in this repository - it have couple more `loaders` and `generators` that you can potentially use in your website.

## Website definition

Fornax is using normal F# code (F# script files) to define any of it's core concepts: `loaders`, `generators` and `config`.

### SiteContents

`SiteContents` is fairly simple type that provides access to any information available to the Fornax. The information is put into it by using `loaders` and then can be accessed in the `generators`.

`SiteContents` has several functions in it's public API:

```fsharp
type A = {a: string}
type B = {b: int; c: int}

let sc = SiteContents()
sc.Add({a = "test"})
sc.Add({a = "test2"})
sc.Add({a = "test3"})

sc.Add({b = 1; c = 3}) //You can add objects of different types, `Add` method is generic.

let as = sc.TryGetValues<A>() //This will return option of sequence of all added elements for given type - in this case it will be 3 elements
let b = sc.TryGetValue<B>() //This will return option of element for given type
```

### Loaders

`Loader` is an F# script responsible for loading external data into generation context. The data typically includes things like content of `.md` files, some global site configuration, etc. But since those are normal F# functions, you can do whatever you need.
Want to load information from local database, or from internet? Sure, why not. Want to use World Bank TP to include some of the World Bank statistics? That's also possible - you can use in `loader` any dependency as in normal F# script.

`Loaders` are normal F# functions that takes as an input `SiteContents` and absolute path to the page root, and returns `SiteContents`:

```fsharp
#r "../_lib/Fornax.Core.dll"

type Page = {
    title: string
    link: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    siteContent.Add({title = "Home"; link = "/"})
    siteContent.Add({title = "About"; link = "/about.html"})
    siteContent.Add({title = "Contact"; link = "/contact.html"})

    siteContent
```

**Important note**: You can (and probably should) define multiple loaders - they will all be executed before generation of site, and will propagate information into `SiteContents`

### Generators

`Generator` is an F# script responsible for generating output of the Fornax process. This is usually `.html` file, but can be anything else - actually `generator` API just requires to return `string` that will be saved to file. Generators are, again, plain F# functions that as an input takes `SiteContents`, absolute path to the page root, relative path to the file that's currently processed (may be empty for the global generators) and returns `string`:

```fsharp
#r "../_lib/Fornax.Core.dll"
#if !FORNAX
#load "../loaders/postloader.fsx"
#endif

open Html

let generate' (ctx : SiteContents) (_: string) =
    let posts = ctx.TryGetValues<Postloader.Post> () |> Option.defaultValue Seq.empty

    let psts =
        posts
        |> Seq.toList
        |> List.map (fun p -> span [] [!! p.link] )

    html [] [
        div [] psts
    ]

let generate (ctx : SiteContents) (projectRoot: string) (page: string) =
    generate' ctx page
    |> HtmlElement.ToString
```

**Important note**: You can (and probably should) define multiple generators - they will generate different kinds of pages and/or content, such as `post`, `index`, `about`, `rss` etc.

### Configuration

`Configuration` is a F# script file that defines when which analyzers need to be run, and how to save its output. `Config.fsx` file needs to be put in the root of your site project (the place from which you run `fornax` CLI tool)

```fsharp
#r "../_lib/Fornax.Core.dll"

open Config
open System.IO

let postPredicate (projectRoot: string, page: string) =
    let fileName = Path.Combine(projectRoot,page)
    let ext = Path.GetExtension page
    if ext = ".md" then
        let ctn = File.ReadAllText fileName
        ctn.Contains("layout: post")
    else
        false

let staticPredicate (projectRoot: string, page: string) =
    let ext = Path.GetExtension page
    if page.Contains "_public" ||
       page.Contains "_bin" ||
       page.Contains "_lib" ||
       page.Contains "_data" ||
       page.Contains "_settings" ||
       page.Contains "_config.yml" ||
       page.Contains ".sass-cache" ||
       page.Contains ".git" ||
       page.Contains ".ionide" ||
       ext = ".fsx"
    then
        false
    else
        true

let config = {
    Generators = [
        {Script = "less.fsx"; Trigger = OnFileExt ".less"; OutputFile = ChangeExtension "css" }
        {Script = "sass.fsx"; Trigger = OnFileExt ".scss"; OutputFile = ChangeExtension "css" }
        {Script = "post.fsx"; Trigger = OnFilePredicate postPredicate; OutputFile = ChangeExtension "html" }
        {Script = "staticfile.fsx"; Trigger = OnFilePredicate staticPredicate; OutputFile = SameFileName }
        {Script = "index.fsx"; Trigger = Once; OutputFile = NewFileName "index.html" }

    ]
}

```