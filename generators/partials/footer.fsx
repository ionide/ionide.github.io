#r "../../_lib/Fornax.Core.dll"
#if !FORNAX
#load "../../loaders/contentloader.fsx"
#load "../../loaders/pageloader.fsx"
#load "../../loaders/globalloader.fsx"
#endif

open Html

let footer =
    [
        div [Custom("style", "left: -1000px; overflow: scroll; position: absolute; top: -1000px; border: none; box-sizing: content-box; height: 200px; margin: 0px; padding: 0px; width: 200px;")] [
            div [Custom("style", "border: none; box-sizing: content-box; height: 200px; margin: 0px; padding: 0px; width: 200px;")] []
        ]
        script [Src "/static/js/clipboard.min.js"] []
        script [Src "/static/js/perfect-scrollbar.min.js"] []
        script [Src "/static/js/perfect-scrollbar.jquery.min.js"] []
        script [Src "/static/js/jquery.sticky.js"] []
        script [Src "/static/js/featherlight.min.js"] []

        script [Src "/static/js/modernizr.custom-3.6.0.js"] []
        script [Src "/static/js/learn.js"] []
        script [Src "/static/js/hugo-learn.js"] []
        // link [Rel "stylesheet"; Href "/static/mermaid/mermaid.css"]
        script [Src "https://cdnjs.cloudflare.com/ajax/libs/mermaid/9.3.0/mermaid.min.js"] []
        script [] [!! "mermaid.initialize({ startOnLoad: true });"]
    ]