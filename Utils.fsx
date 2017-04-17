#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-powerpack/Fable.PowerPack.dll"

#load "Fable.Import.Global.fsx"

open Fable.Import.Browser
open Fable.Import.Global
open Fable.PowerPack
open Fable.PowerPack.Fetch

let code = "/2TrzMFxBGuQedl8nYG0Q4wWeP3Rw9pg/pUhqqnyPxQ1wnl/ayPHFQ=="
let serverUrl = "https://goodreadsstatsbackend.azurewebsites.net/api/"

let completeUrl methodName query = serverUrl + methodName + query + (sprintf "&code=%s" code)
let completeUrlWithToken methodName token tokenSecret = 
    let query = sprintf "?token=%s&tokenSecret=%s" token tokenSecret
    completeUrl methodName query

let completeUrlWithClientUrl methodName =
    let query = sprintf "?clientSideUrl=%s" window.location.origin
    completeUrl methodName query

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
    |> Seq.map snd
    |> Seq.tryHead        

let navigateTo url = window.location.href <- url

let removeTokenFromLocation() =
    let currentState = window.history.state
    window.history.replaceState(currentState, "", window.location.origin)

let fetchAsJson url map = 
    fetchAs<string> url [] |> Promise.map map |> ignore
