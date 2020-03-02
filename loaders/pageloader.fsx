#r "../_lib/Fornax.Core.dll"

type ApiReferences = {
    title: string
    link: string
}

type Shortcut = {
    title: string
    link: string
    icon: string
}

let loader (projectRoot: string) (siteContet: SiteContents) =
    siteContet.Add({title = "Home"; link = "/"; icon = "fas fa-home"})
    siteContet.Add({title = "GitHub Organization"; link = "https://github.com/ionide"; icon = "fab fa-github"})
    siteContet.Add({title = "Call To Action"; link = "/callToAction.html"; icon = "far fa-file-alt"})
    siteContet