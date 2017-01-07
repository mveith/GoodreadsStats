#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-powerpack/Fable.PowerPack.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "Fable.Import.Global.fsx"
#load "Utils.fsx"
#load "Components.fsx"

open Fable.Import
open Fable.Import.Global
open Components
open Utils

module R = Fable.Helpers.React

let reducer (state: State) = function
    | Login (token, secret)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }}
    | SaveBasicStats stats -> { state with BasicStats = Some stats}
    | SaveLoggedUserName name -> { state with LoggedUserName = name}

let saveAccessToken (accessToken, accessTokenSecret) = 
    let accessToken = string accessToken
    setCookie "accessToken" accessToken 7
    setCookie "accessTokenSecret" accessTokenSecret 7
    (accessToken, accessTokenSecret)

let store = Redux.createStore reducer {Logged = false; BasicStats = None; AccessData = None; LoggedUserName = "" }

ReactDom.render(
    R.com<App,_,_> { Store=store } [],
    Browser.document.getElementById "content"
) |> ignore

let downloadBasicStats accessToken accessTokenSecret =
    let saveStats stats= Redux.dispatch store (SaveBasicStats stats) 
    let url = completeUrlWithToken "basicStats" accessToken accessTokenSecret
    ajax url (string >> JS.JSON.parse >> unbox >> saveStats) |> ignore

let getLoggedUserName accessToken accessTokenSecret =
    let saveUserName name= Redux.dispatch store (SaveLoggedUserName name) 
    let url = completeUrlWithToken "userName" accessToken accessTokenSecret
    ajax url (string >> saveUserName) |> ignore

let login accessToken accessTokenSecret=
    downloadBasicStats accessToken accessTokenSecret
    getLoggedUserName accessToken accessTokenSecret
    Redux.dispatch store (Login (accessToken, accessTokenSecret))
let token = getQueryVariable "oauth_token"
let secret = Globals.cookies.get ("authorizationTokenSecret")
match token with
| Some token -> 
    let url = completeUrlWithToken "authorized" token secret.Value
    ajax url (string
                >> parseTokenAndSecret
                >> saveAccessToken
                >> (fun (accessToken, accessTokenSecret) ->
                    downloadBasicStats accessToken accessTokenSecret
                    Redux.dispatch store (Login (accessToken, accessTokenSecret)) ))
| None -> 
    let token = Globals.cookies.get ("accessToken")
    match token with
    | Some token -> 
        let secret = Globals.cookies.get ("accessTokenSecret")
        login token secret.Value
    | None -> ()