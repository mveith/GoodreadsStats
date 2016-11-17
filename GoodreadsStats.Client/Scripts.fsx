#r "node_modules/fable-core/Fable.Core.dll"
#load "Fable.Import.Global.fsx"
#load "node_modules/fable-import-react/Fable.Import.React.fs"
#load "node_modules/fable-import-react/Fable.Helpers.React.fs"
#load "Components.fsx"

open Fable.Import
open Fable.Import.Browser
open Fable.Import.Global

module R = Fable.Helpers.React

open Components

let parseTokenAndSecret (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1])

let parseTokenAndSecretAndUrl (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1], parts.[2])

let saveAndReturnAuthorizationUrl result = 
    let (token, secret, url) = parseTokenAndSecretAndUrl result
    setCookie "authorizationToken" token 1
    setCookie "authorizationTokenSecret" secret 1
    url

let navigateTo url = window.location.href <- url

let login() = 
    ajax """http://localhost:8083/authorizationUrl""" (string
                              >> saveAndReturnAuthorizationUrl
                              >> navigateTo)

let getQueryVariable variable = 
    let query = window.location.search.Substring 1
    let vars = query.Split '&'
    
    let var = 
        vars
        |> Seq.map ((fun var -> var.Split '=')
                    >> Seq.map decodeURIComponent
                    >> (fun parts -> (Seq.item 0 parts, Seq.item 1 parts)))
        |> Seq.filter (fun (key, _) -> key = variable)
        |> Seq.map (fun (_, value) -> value)
        |> Seq.tryHead
    var

let getAccessToken() = 
    let token = Globals.cookies.get ("accessToken")
    let secret = Globals.cookies.get ("accessTokenSecret")
    match token with
    | Some token -> option.Some(token, secret.Value)
    | None -> option.None

let saveAccessToken (accessToken, accessTokenSecret) = 
    let accessToken = string accessToken
    window.alert "cookie získána"
    setCookie "accessToken" accessToken 7
    setCookie "accessTokenSecret" accessTokenSecret 7

let tryAuthorize (onSuccess : (string * string) option -> unit) = 
    let token = getQueryVariable "oauth_token"
    let secret = Globals.cookies.get ("authorizationTokenSecret")
    match token with
    | Some token -> 
        let url = sprintf """http://localhost:8083/authorized?oauth_token=%s&oauth_token_secret=%s""" token secret.Value
        ajax url (string
                  >> parseTokenAndSecret
                  >> saveAccessToken
                  >> getAccessToken
                  >> onSuccess)
    | None -> ()

let start accessToken accessTokenSecret = 
    ReactDom.render (R.com<BooksList, _, _> { accessToken = accessToken; accessTokenSecret  = accessTokenSecret  } [], Browser.document.getElementById "content") 
    |> ignore

let onPageLoad() = 
    let accessToken = getAccessToken()
    match accessToken with
    | Some(accessToken, accessTokenSecret) -> start accessToken accessTokenSecret
    | None -> 
        let start (tokenPair : (string * string) option) = 
            let (token, secret) = tokenPair.Value
            start token secret
        tryAuthorize start

Globals.jQuery.Invoke("#loginButton").click(fun _ -> login())
onPageLoad()
