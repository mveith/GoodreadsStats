#r "node_modules/fable-core/Fable.Core.dll"
#load "Fable.Import.Global.fsx"

open Fable.Import
open Fable.Import.Browser
open Fable.Import.Global

let serverUrl = "http://localhost:8083/"
let completeUrl methodName = serverUrl + methodName

let completeUrlWithToken methodName token tokenSecret = 
    let query = sprintf "?token=%s&tokenSecret=%s" token tokenSecret
    (completeUrl methodName) + query

let keyValuePair (var : string) = 
    let parts = var.Split '='
    let keyPart = Seq.item 0 parts
    let valuePart = Seq.item 1 parts
    (decodeURIComponent keyPart, decodeURIComponent valuePart)

let getQueryVariable variable = 
    let query = window.location.search.Substring 1
    query.Split '&'
    |> Seq.map keyValuePair
    |> Seq.filter (fun (key, _) -> key = variable)
    |> Seq.map (fun (_, value) -> value)
    |> Seq.tryHead

let navigateTo url = window.location.href <- url
