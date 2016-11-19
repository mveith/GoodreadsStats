open GoodreadsApi
open Utils
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open System.Runtime.Serialization
open FSharp.Configuration

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

let authorized token tokenSecret = 
    let (token, tokenSecret) = getAccessToken clientKey clientSecret token tokenSecret
    let result = sprintf "%s|%s" token tokenSecret
    OK result

let createBook (review : Reviews.Review) = 
    { Title = review.Book.Title
      Author = review.Book.Author.Name }

let readBooks token tokenSecret = 
    let accessData = getAccessData clientKey clientSecret token tokenSecret
    let userId = getUserId accessData
    let reviews = getAllReviews accessData userId "read" "date_read"
    
    let books = 
        reviews
        |> Seq.map createBook
        |> Seq.toArray
    ok (Suave.Json.toJson books)

let setCORSHeaders = setCORSHeaders clientSideUrl
let requestWithTokenParams f = request (processRequestWithTokenParams f)

let authorizationUrlRequest request = 
    let (authorizationUrl, token, tokenSecret) = getAuthorizationData clientKey clientSecret clientSideUrl
    OK(sprintf "%s|%s|%s" token tokenSecret authorizationUrl)

let webPart = 
    choose [ GET >=> choose [ path "/authorizationUrl" >=> setCORSHeaders >=> request authorizationUrlRequest
                              pathStarts "/authorized" >=> setCORSHeaders >=> requestWithTokenParams authorized
                              pathStarts "/readed" >=> setCORSHeaders >=> requestWithTokenParams readBooks ] ]

startWebServer defaultConfig webPart
