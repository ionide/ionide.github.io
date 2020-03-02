#r "../../_lib/Fornax.Core.dll"
#if !FORNAX
#load "../../loaders/contentloader.fsx"
#load "../../loaders/pageloader.fsx"
#load "../../loaders/globalloader.fsx"
#endif

open Html

let header (ctx : SiteContents) =
    let siteInfo = ctx.TryGetValue<Globalloader.SiteInfo>().Value

    head [] [
        meta [CharSet "utf-8"]
        meta [Name "viewport"; Content "width=device-width, initial-scale=1"]
        title [] [!! siteInfo.title]
        link [Rel "icon"; Type "image/png"; Sizes "32x32"; Href "/static/images/favicon.png"]
        link [Rel "stylesheet"; Href "/static/css/nucleus.css"]
        link [Rel "stylesheet"; Href "/static/css/fontawesome-all.min.css"]
        link [Rel "stylesheet"; Href "/static/css/hybrid.css"]
        link [Rel "stylesheet"; Href "/static/css/featherlight.min.css"]
        link [Rel "stylesheet"; Href "/static/css/perfect-scrollbar.min.css"]
        link [Rel "stylesheet"; Href "/static/css/auto-complete.css"]
        link [Rel "stylesheet"; Href "/static/css/atom-one-dark-reasonable.css"]
        link [Rel "stylesheet"; Href "/static/css/theme.css"]
        if siteInfo.theme_variant.IsSome then
            link [Rel "stylesheet"; Href (sprintf "/static/css/theme-%s.css" siteInfo.theme_variant.Value)]
        script [Src "/static/js/jquery-3.3.1.min.js"] []
    ]