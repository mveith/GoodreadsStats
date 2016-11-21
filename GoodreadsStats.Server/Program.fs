open GoodreadsApi
open Utils
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open FSharp.Configuration
open BasicStatsCalculator

type Settings = AppSettings< "app.config" >

let clientKey = Settings.ClientKey
let clientSecret = Settings.ClientSecret
let clientSideUrl = "http://localhost:1234"

let authorized token tokenSecret = 
    let (token, tokenSecret) = getAccessToken clientKey clientSecret token tokenSecret
    let result = sprintf "%s|%s" token tokenSecret
    OK result

let basicStats token tokenSecret = 
    let accessData = getAccessData clientKey clientSecret token tokenSecret
    json (basicStats accessData)

let setCORSHeaders = setCORSHeaders clientSideUrl
let requestWithTokenParams f = request (processRequestWithTokenParams f)

let authorizationUrlRequest request = 
    let (authorizationUrl, token, tokenSecret) = getAuthorizationData clientKey clientSecret clientSideUrl
    OK(sprintf "%s|%s|%s" token tokenSecret authorizationUrl)

let webPart = 
    choose [ GET >=> choose [ path "/authorizationUrl" >=> setCORSHeaders >=> request authorizationUrlRequest
                              pathStarts "/authorized" >=> setCORSHeaders >=> requestWithTokenParams authorized
                              pathStarts "/basicStats" >=> setCORSHeaders >=> requestWithTokenParams basicStats ] ]

startWebServer defaultConfig webPart
