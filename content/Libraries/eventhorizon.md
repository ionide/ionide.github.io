---
title: Ionide.EventHorizon
menu_order: 2
---

# Ionide.EventHorizon

**GitHub link:** [https://github.com/ionide/FSharp.EventHorizon](https://github.com/ionide/FSharp.EventHorizon)
**License:** [MIT](https://github.com/ionide/FSharp.EventHorizon/blob/master/LICENSE.md)

An **experiment** attempting to implement `type holes` and `type-directed search`/`valid hole fits` using F# analyzers. Long story short, it's an attempt at suggesting replacements for  unknown functions using type inference, as well as finding other entities that have matching type signatures.

- Read more about `type holes`: [https://downloads.haskell.org/~ghc/7.10.1/docs/html/users_guide/typed-holes.html](https://downloads.haskell.org/~ghc/7.10.1/docs/html/users_guide/typed-holes.html)
- Read more about `type-directed search` in PureScript: [https://github.com/paf31/24-days-of-purescript-2016/blob/master/23.markdown](https://github.com/paf31/24-days-of-purescript-2016/blob/master/23.markdown)
- Read more about `valid hole fits` in GHC: [https://mpg.is/papers/gissurarson2018suggesting.pdf](https://mpg.is/papers/gissurarson2018suggesting.pdf)

Unlike some of the solutions for other FP languages, this is not a feature implemented directly in compiler, nor is it a feature of any particular IDE; rather it's using F# Analyzers.

Read more about F# Analyzers:
  - Intro blog post - [https://medium.com/lambda-factory/introducing-f-analyzers-772487889429](https://medium.com/lambda-factory/introducing-f-analyzers-772487889429)
  - FSharp.Analyzers.SDK repo - [https://github.com/ionide/FSharp.Analyzers.SDK](https://github.com/ionide/FSharp.Analyzers.SDK)
  - Sample analyzer implementation - [https://github.com/Krzysztof-Cieslak/FSharp.Analyzers.Sample](https://github.com/Krzysztof-Cieslak/FSharp.Analyzers.Sample)
  - Sample repo showing how to use analyzers - [https://github.com/Krzysztof-Cieslak/AnalyzersShowcase](https://github.com/Krzysztof-Cieslak/AnalyzersShowcase)

<img class="gif" src="/static/images/EventHorizon.png" />

## Limitations

F# Compiler Service does not expose any API for `subsumption of types`. I've implemented a really naive algorithm to check if an entity can fit a given type hole... but well, it's definitely not following the rules of the F# compiler 100%, so not every suggestion is found.

I think that this limitation is acceptable given that the project is in an experimental phase - if it were productized, we would need to expose those missing APIs from F# Compiler Services, so investing more into a custom algorithm here would be a waste of time.
