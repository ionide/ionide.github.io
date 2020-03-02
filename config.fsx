#r "_lib/Fornax.Core.dll"

open Config

let customRename (page: string) =
    System.IO.Path.ChangeExtension(page.Replace ("content/", ""), ".html")


GeneratorTrigger.OnFilePredicate

let trigger (projecRoot, path: string) =
    not (path.Contains "packages") &&  System.IO.Path.GetExtension path = ".md" && path <> "README.md"

let config = {
    Generators = [
        {Script = "post.fsx"; Trigger = OnFilePredicate trigger; OutputFile = Custom customRename }
        // {Script = "apiref.fsx"; Trigger = Once; OutputFile = MultipleFiles (sprintf "Reference/%s.html") }

        {Script = "lunr.fsx"; Trigger = Once; OutputFile = NewFileName "index.json" }
    ]
}
