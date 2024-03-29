---
title: Waypoint
menu_order: 1
---

# Waypoint

**GitHub link:** [https://github.com/ionide/Waypoint](https://github.com/ionide/Waypoint)
**License:** [MIT](https://github.com/ionide/Waypoint/blob/master/LICENSE.md)

Opinionated solution template for building F# OSS libraries and tools.

Sample repository is available here - https://github.com/Krzysztof-Cieslak/SampleWaypoint

Sample generated documentation can be found here - http://kcieslak.io/SampleWaypoint

## What's included in template

* Paket, FAKE, and Fornax added as `dotnet` local tools (`.config/dotnet-tools.json`)
* `build.fsx` file, containing default FAKE script with targets for building, testing, documentation generation, publishing to GitHub, and publishing to NuGet
* `paket.dependencies` with basic set of dependencies
* `src` folder containing 2 projects - one class library (`netstandard2.0`), and CLI tool (`netcoreapp3.1`)
* `test` folder containing UnitTest project using Expecto and FsCheck
* `docs` folder with Fornax documentation template that will generate nice documentation for your project.
* `.devcontainer` folder with definition of [Development Container](https://code.visualstudio.com/docs/remote/containers)
* `.github/workflows` folder with definition for 2 GitHub actions - one for building and testing code as CI, one for deploying documentation when new tag is pushed. To use latter, you need to define `PERSONAL_TOKEN` secret in GitHub repo settings with Personal Access Token.
* `.github/ISSUE_TEMPLATE` folder with 2 different issue templates - one for bug report, other one for feature request

## Documentation Theme

Template includes, out-of-the-box, nice theme for your project documentation, which integrates with FSharp.Formatting to create also API reference

* Sample documentation produced by the template can be found on http://kcieslak.io/SampleWaypoint.
* Created theme is partial port to Fornax of [Hugo Learn theme](https://learn.netlify.com/en/).
* You define content as markdown files
* Support for unlimited multi-level navigation
* Use FSharp.Formatting to create API reference for the project - sample: http://kcieslak.io/SampleWaypoint/Reference/ApiRef.html
* Use [Lunr.js](https://lunrjs.com/) to provide client side search based on generated by Fornax search index - sample: try searching for `Lorem` or `Sample` in search available on http://kcieslak.io/SampleWaypoint
* Use [Mermaid.js](https://mermaid-js.github.io/mermaid/#/) to provide client side render diagrams and graphs - sample: http://kcieslak.io/SampleWaypoint/diagrams.html

## How to use template

1. Install `dotnet new` template with `dotnet new -i Waypoint`
2. Create new folder `mkdir TestApp` and go into it `cd TestApp`
3. Create new project with `dotnet new Waypoint`

## Motivation

Waypoint got created for couple of reasons. Mostly because I (Chris) was unhappy with possible options "on the market" - don't get me wrong, I think projects like MiniScaffold are doing great job, but it was just not hitting my personal sweet spot for what I wanted from project scaffold.
Secondly I strongly believe into having opinionated set of tools working well together, providing great Developer Experience - building such tools is something I've been doing for last couple of years, so providing single "package" seems like a logical next step.
Thirdly, I want Waypoint to be "canonical" example of using Fornax for documentation generation - scaffolded template contains really nice theme for documentation, integration with FSharp.Formatting, built-in search support, and more.


## Inspired by

No project lives in vacuum - good ideas are very often just small improvements on the previous state of art. Waypoint has been heavily inspired by:

* [fsprojects/ProjectScaffold](https://github.com/fsprojects/ProjectScaffold) - original F# OSS project template used by countless projects in F# ecosystem
* [TheAngryByrd/MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold) - great project scaffold created by @TheAngryByrd, having many different options and functionalities
* [SAFE-Stack/SAFE-template](https://github.com/SAFE-Stack/SAFE-template) - SAFE Stack template by @theimowski

## Used projects

* [.NET SDK](https://dotnet.microsoft.com/download) - modern, OSS, cross platform distribution of .NET; `dotnet` - CLI tool for developers
* [Paket](https://fsprojects.github.io/Paket/) - Paket is a dependency manager for .NET projects, popular in F# community.
* [FAKE](https://fake.build/) - F# build DSL and task runner
* [Fornax](https://ionide.io/Tools/fornax.html) - scriptable static site generator using type safe F# DSL to define page layouts
* [Expecto](https://github.com/haf/expecto) - F# test library
* [FsCheck](https://github.com/fscheck/FsCheck) - Random testing library for F#

## FAQ

1. What about `fsprojects/ProjectScaffold` ?

ProjectScaffold is fairly outdated template, and I think everyone, including original creators of ProjectScaffold will welcome modern alternative.

2. What about `TheAngryByrd/MiniScaffold` ?

MiniScaffold is great project, with many options and functionalities - such as code formatting, test coverage, sourcelinks and more. I've decided to create a scaffold feeding my needs and needs of Ionide projects that's bit more opinionated, and provide less functionalities. Please use whichever scaffold you want!

3. Why do we even need solution scaffold? Is `dotnet new console` and `dotnet build` not enough?

No, it's not enough. Real world project, unlike conference demos, requires more structure, testing, documentation - especially OSS projects, if you care for adaption and user happiness. Beacuse of that we need something that will provide nice experience for both users and developers of the OSS projects.
