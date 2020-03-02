#r "../_lib/Fornax.Core.dll"
#r "../packages/documentation/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"

#if !FORNAX
#load "../loaders/contentloader.fsx"
#endif



type Entry = {
    uri: string
    title: string
    content: string
}
let generate (ctx : SiteContents) (projectRoot: string) (page: string) =
    let pages = ctx.TryGetValues<Contentloader.Post> () |> Option.defaultValue Seq.empty

    let entries =
        pages
        |> Seq.map (fun n ->
            {uri = "/" + n.link.Replace("content/", ""); title = n.title; content = n.text}
        )
    [|yield! entries; |]
    |> Newtonsoft.Json.JsonConvert.SerializeObject

