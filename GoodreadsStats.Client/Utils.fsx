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
    match parts with
    | [|keyPart; valuePart|] -> (decodeURIComponent keyPart, decodeURIComponent valuePart)
    | _ -> ("", "")

let getQueryVariable variable = 
    let query = window.location.search.Substring 1
    
    query.Split '&'
    |> Seq.map keyValuePair
    |> Seq.filter (fun (key, _) -> key = variable)
    |> Seq.map (fun (_, value) -> value)
    |> Seq.tryHead        

let navigateTo url = window.location.href <- url

let parseTokenAndSecret (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1])
let parseTokenAndSecretAndUrl (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1], parts.[2])
