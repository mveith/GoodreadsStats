open GoodreadsApi
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open System.Runtime.Serialization
open FSharp.Configuration
open Suave.Writers

[<DataContract>]
type ReadBook = 
    { [<field:DataMember(Name = "Title")>]
      Title : string
      [<field:DataMember(Name = "Author")>]
      Author : string }

type Settings = AppSettings< "app.config" >

let clientKey = Settings.ClientKey
let clientSecret = Settings.ClientSecret
let clientSideUrl = "http://localhost:1234"

let setCORSHeaders = 
    setHeader "Access-Control-Allow-Origin" clientSideUrl >=> setHeader "Access-Control-Allow-Headers" "content-type"
    
let authorized (request : HttpRequest) = 
    let tokenParam = request.queryParam "oauth_token"
    let tokenSecret = request.queryParam "oauth_token_secret"
    match tokenParam with
    | Choice1Of2 token -> 
        match tokenSecret with
        | Choice1Of2 tokenSecret -> 
            let (token, tokenSecret) = getAccessToken clientKey clientSecret token tokenSecret
            let result = sprintf "%s|%s" token tokenSecret
            OK result
        | Choice2Of2 msg -> RequestErrors.BAD_REQUEST msg
    | Choice2Of2 msg -> RequestErrors.BAD_REQUEST msg

let readBooks (request : HttpRequest) = 
    let tokenParam = request.queryParam "token"
    let tokenSecret = request.queryParam "tokenSecret"
    match tokenParam with
    | Choice1Of2 token -> 
        match tokenSecret with
        | Choice1Of2 tokenSecret -> 
            let accessData = getAccessData clientKey clientSecret token tokenSecret
            let userId = getUserId accessData
            let reviews = getAllReviews accessData userId "read" "date_read" |> Seq.toArray
            
            let books = 
                reviews
                |> Seq.map (fun r -> 
                       { Title = r.Book.Title
                         Author = r.Book.Author.Name })
                |> Seq.toArray
            ok (Suave.Json.toJson books)
        | Choice2Of2 msg -> RequestErrors.BAD_REQUEST msg
    | Choice2Of2 msg -> RequestErrors.BAD_REQUEST msg

let getAuthorizationUrl (request : HttpRequest) = 
    let callbackUrl = clientSideUrl
    let (authorizationUrl, token, tokenSecret) = getAuthorizationData clientKey clientSecret callbackUrl        
    OK (sprintf "%s|%s|%s" token tokenSecret authorizationUrl)

let webPart = 
    choose [ GET >=> choose [ path "/authorizationUrl" >=> setCORSHeaders >=> request getAuthorizationUrl
                              pathStarts "/authorized" >=> setCORSHeaders >=> request authorized
                              pathStarts "/readed" >=> setCORSHeaders >=> request readBooks ] ]

startWebServer defaultConfig webPart
