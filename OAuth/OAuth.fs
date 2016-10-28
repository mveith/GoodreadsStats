module OAuth

open System
open System.Text
open System.Security.Cryptography
open System.Net
open System.IO
open Utils

type AccessData = 
    { ClientKey : String
      ClientSecret : String
      AccessToken : String
      AccessTokenSecret : String }
      
let parseTokenFromResponse (response : String) = 
    let (token, tokenSecret) = 
        match response with
        | ParseRegex "oauth_token=(.+)&oauth_token_secret=(.+)" [ token; tokenSecret ] -> (token, tokenSecret)
        | _ -> ("", "")
    (token, tokenSecret)

let parseQueryParameter queryPart =
    let (key, value) = 
        match queryPart with
        | ParseRegex "(.+)=(.+)" [ key; value] -> (key, value)
        | _ -> ("", "")
    (key, value)
    
let parseUrlParameters (urlQuery:String)= 
    let query = urlQuery.Substring 1

    let urlParameters = query.Split ('&') |> Seq.map parseQueryParameter |> Seq.toList
    urlParameters
    
let baseString (url : Uri) nonce timeStamp clientKey oauthToken = 
    let parameters = 
        [ ("oauth_consumer_key", clientKey)
          ("oauth_signature_method", "HMAC-SHA1")
          ("oauth_timestamp", timeStamp)
          ("oauth_nonce", nonce)
          ("oauth_version", "1.0")
          ("oauth_callback", "oob") ]

    let parameters = 
          if not (String.IsNullOrEmpty(oauthToken)) then ("oauth_token", oauthToken) :: parameters
          else parameters

    let query = url.Query
    let parameters = if query.Length > 0 then (parseUrlParameters query) @ parameters else parameters
    let absoluteUri = url.AbsoluteUri
    let url =  if query.Length > 0 then absoluteUri.Replace(query, String.Empty) else absoluteUri
    
    let escapedUrl = Uri.EscapeDataString(url)
    let parameters = parameters |> Seq.sortBy (fun (key, _) -> key)
    let escapedParameters = Uri.EscapeDataString(normalize (parameters))
    let baseString = sprintf "GET&%s&%s" escapedUrl escapedParameters
    baseString
    
let signature nonce timeStamp url clientKey clientSecret oauthToken tokenSecret = 
    let signatureBase = baseString url nonce timeStamp clientKey oauthToken
    let signatureKey = sprintf "%s&%s" clientSecret tokenSecret
    let keyBytes = Encoding.ASCII.GetBytes(signatureKey)
    let hmac = new HMACSHA1(keyBytes)
    let asciiEncoding = new ASCIIEncoding()
    let signatureBaseBytes = asciiEncoding.GetBytes signatureBase
    Convert.ToBase64String(hmac.ComputeHash(signatureBaseBytes))
    
let authorizationHeader url clientKey clientSecret token tokenSecret = 
    let nonce = Guid.NewGuid().ToString()
    let timeStamp = timeStamp()
    let signature = signature nonce timeStamp (new Uri(url)) clientKey clientSecret token tokenSecret
    
    let parameters = 
        [ ("oauth_consumer_key", clientKey)
          ("oauth_nonce", nonce)
          ("oauth_timestamp", timeStamp)
          ("oauth_signature_method", "HMAC-SHA1")
          ("oauth_version", "1.0")
          ("oauth_signature", signature)
          ("oauth_callback", "oob") ]

    let parameters = 
        if not (String.IsNullOrEmpty(token)) then ("oauth_token", token) :: parameters
        else parameters

    let join (values : seq<String>) = String.Join(",", values)
    
    let authorizationHeaderValue = 
        parameters
        |> Seq.map (fun (key, value) -> sprintf "%s=\"%s\"" (Uri.EscapeDataString(key)) (Uri.EscapeDataString(value)))
        |> join
    
    let authorizationHeaderValue = "OAuth " + authorizationHeaderValue
    ("Authorization", authorizationHeaderValue)

let createRequest (url : String) clientKey clientSecret token tokenSecret = 
    let request = WebRequest.Create(url)
    let (key, value) = authorizationHeader url clientKey clientSecret token tokenSecret
    request.Headers.Add(key, value)
    request

let getResponse (requestTokenUrl : WebRequest) = 
    let resp = requestTokenUrl.GetResponse()
    let stream = resp.GetResponseStream()
    let responseText = (new StreamReader(stream)).ReadToEnd()
    responseText

let getUrlContent  (url : String) clientKey clientSecret token tokenSecret = 
    let request = createRequest url clientKey clientSecret token tokenSecret
    getResponse request

let getAuthorizatonToken clientKey clientSecret requestTokenUrl =  
    let requestToken = getUrlContent requestTokenUrl clientKey clientSecret "" ""
    let (token, tokenSecret) = parseTokenFromResponse requestToken
    (token, tokenSecret)
    
let getAccessToken clientKey clientSecret accessTokenUrl authorizationToken authorizationTokenSecret = 
    let accessToken = getUrlContent accessTokenUrl clientKey clientSecret authorizationToken authorizationTokenSecret
    parseTokenFromResponse accessToken
        
let getAccessData clientKey clientSecret acessToken acessTokenSecret = 
    { ClientKey = clientKey
      ClientSecret = clientSecret
      AccessToken = acessToken
      AccessTokenSecret = acessTokenSecret }

let getUrlContentWithAccessData  (url : String) (accessData:AccessData) = 
    getUrlContent url accessData.ClientKey accessData.ClientSecret accessData.AccessToken accessData.AccessTokenSecret
    