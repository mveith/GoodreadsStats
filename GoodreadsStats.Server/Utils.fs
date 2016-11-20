module Utils

open Suave
open Suave.Operators
open Suave.Writers
open Suave.Successful
open Newtonsoft.Json

let toOption choice = 
    match choice with
    | Choice1Of2 value -> Option.Some value
    | Choice2Of2 _ -> Option.None

let queryParams (request : HttpRequest) (parameterNames : string list) = 
    parameterNames
    |> Seq.map (request.queryParam >> toOption)
    |> Seq.filter Option.isSome
    |> Seq.map Option.get
    |> Seq.toList
    
let processRequestWithTokenParams f (request : HttpRequest) = 
    let queryValues = queryParams request [ "token"; "tokenSecret" ]
    match queryValues with
    | [ token; tokenSecret ] -> f token tokenSecret
    | _ -> RequestErrors.BAD_REQUEST "Invalid query params"

let setCORSHeaders acceptedUrl = 
    setHeader "Access-Control-Allow-Origin" acceptedUrl >=> setHeader "Access-Control-Allow-Headers" "content-type"

let json a = OK(JsonConvert.SerializeObject a)
