#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-powerpack/Fable.PowerPack.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "Model.fsx"
#load "Fable.Import.Global.fsx"
#load "Utils.fsx"
#load "Components.fsx"

open Fable.Import
open Fable.Import.Global
open Components
open Utils
open GoodreadsStats.Model

module R = Fable.Helpers.React

let reducer (state: State) = function
    | Login (token, secret, userName)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }; LoggedUserName = userName}
    | SaveBasicStats stats -> { state with BasicStats = Some stats}

let saveAccessToken (userData:LoggedUserData) = 
    setCookie "accessToken" userData.AccessToken 7
    setCookie "accessTokenSecret" userData.AccessTokenSecret 7
    setCookie "userName" userData.UserName 7
    userData

let store = Redux.createStore reducer {Logged = false; BasicStats = None; AccessData = None; LoggedUserName = "" }

ReactDom.render(
    R.com<App,_,_> { Store=store } [],
    Browser.document.getElementById "content"
) |> ignore

let downloadBasicStats accessToken accessTokenSecret =
    let saveStats stats= Redux.dispatch store (SaveBasicStats stats) 
    let url = completeUrlWithToken "basicStats" accessToken accessTokenSecret
    ajax url (string >> JS.JSON.parse >> unbox >> saveStats) |> ignore

let login accessToken accessTokenSecret userName=
    downloadBasicStats accessToken accessTokenSecret
    Redux.dispatch store (Login (accessToken, accessTokenSecret, userName))
let token = getQueryVariable "oauth_token"
let secret = Globals.cookies.get ("authorizationTokenSecret")
match token with
| Some token -> 
    let url = completeUrlWithToken "authorized" token secret.Value
    ajax url (string
                >> JS.JSON.parse 
                >> unbox
                >> saveAccessToken
                >> (fun userData -> login userData.AccessToken userData.AccessTokenSecret userData.UserName))
| None -> 
    let token = Globals.cookies.get ("accessToken")
    match token with
    | Some token -> 
        let secret = Globals.cookies.get ("accessTokenSecret")
        let userName = Globals.cookies.get ("userName")
        login token secret.Value userName.Value
    | None -> ()