module Utils

open Fable.Import.Browser
open Fable.Import.Global

let code = "/2TrzMFxBGuQedl8nYG0Q4wWeP3Rw9pg/pUhqqnyPxQ1wnl/ayPHFQ=="
let serverUrl = "https://bookworm-stats-api.now.sh/api/"


let completeUrl methodName query = serverUrl + methodName + query + (sprintf "&code=%s" code)

let completeUrlWithToken methodName token tokenSecret =
    let query = sprintf "?token=%s&tokenSecret=%s" token tokenSecret
    completeUrl methodName query

let completeUrlWithClientUrl methodName =
    let query = sprintf "?clientSideUrl=%s" location.origin
    completeUrl methodName query

let keyValuePair (var: string) =
    let parts = var.Split '='
    match parts with
    | [| keyPart; valuePart |] -> (decodeURIComponent keyPart, decodeURIComponent valuePart)
    | _ -> ("", "")

let getQueryVariable variable =
    let query = window.location.search.Substring 1

    query.Split '&'
    |> Seq.map keyValuePair
    |> Seq.filter (fun (key, _) -> key = variable)
    |> Seq.map snd
    |> Seq.tryHead

let navigateTo url = location.href <- url

let removeTokenFromLocation() =
    let currentState = history.state
    history.replaceState (currentState, "", location.origin)