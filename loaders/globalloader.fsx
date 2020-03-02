#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    description: string
    theme_variant: string option
    numbers_in_menu: bool
}

let config = {
    title = "Ionide"
    description = "We're building cross platform, F# developer tooling"
    theme_variant = Some "blue"
    numbers_in_menu = true
}

let loader (projectRoot: string) (siteContet: SiteContents) =
    siteContet.Add(config)

    siteContet