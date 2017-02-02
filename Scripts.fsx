#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-powerpack/Fable.PowerPack.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "Model.fsx"
#load "Actions.fsx"
#load "Fable.Import.Global.fsx"
#load "Utils.fsx"
#load "Components.fsx"
#load "ReadBooksStorage.fsx"
#load "Reducer.fsx"
#load "ReadBooksDownloader.fsx"

open Fable.Import
open Fable.Import.Global
open Components
open Utils
open Model
open ReadBooksStorage
open Actions
open Reducer
open ReadBooksDownloader

module R = Fable.Helpers.React

let saveAccessToken (userData:LoggedUserData) = 
    setCookie "accessToken" userData.AccessToken 7
    setCookie "accessTokenSecret" userData.AccessTokenSecret 7
    setCookie "userName" userData.UserName 7
    userData

let loadSavedBooks() = 
    let savedBooks = ReadBooksStorage.load() 
    match savedBooks with
    | Some savedBooks -> savedBooks
    | None -> [||]

let store = Redux.createStore reducer {Logged = false; ReadBooks = loadSavedBooks(); AccessData = None; LoggedUserName = "" }

ReactDom.render(
    R.com<App,_,_> { Store=store } [],
    Browser.document.getElementById "content"
) |> ignore

let saveBooks = SaveReadBooks >> Redux.dispatch store

let login accessToken accessTokenSecret userName =
    startDownloadReadBooks accessToken accessTokenSecret saveBooks
    Redux.dispatch store (Login (accessToken, accessTokenSecret, userName))

let token = getQueryVariable "oauth_token"
let secret = Globals.cookies.get ("authorizationTokenSecret")
match token with
| Some token -> 
    let url = completeUrlWithToken "authenticate" token secret.Value
    ajax url (string
                >> Fable.Core.JsInterop.ofJson
                >> saveAccessToken
                >> (fun userData -> login userData.AccessToken userData.AccessTokenSecret userData.UserName)
                >> removeTokenFromLocation)
| None -> 
    let token = Globals.cookies.get ("accessToken")
    match token with
    | Some token -> 
        let secret = Globals.cookies.get ("accessTokenSecret")
        let userName = Globals.cookies.get ("userName")
        login token secret.Value userName.Value
    | None -> ()