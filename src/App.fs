module GoodreadsStats

open Fable.Import
open Fable.Import.Global
open Components
open Utils
open Model
open Actions
open Reducer
open ReadBooksDownloader
open Fable.Core
open Fable.PowerPack.Fetch
open Fable.PowerPack

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
    
let loadDetails() = 
    let savedDetails = ReadBooksStorage.loadDetails() 
    match savedDetails with
    | Some savedDetails -> savedDetails
    | None -> [||]

let store = Redux.createStore reducer {Logged = false; ReadBooks = loadSavedBooks(); AccessData = None; LoggedUserName = ""; BooksDetails = loadDetails() }

ReactDom.render(
    R.com<App,_,_> { Store=store } [],
    Browser.document.getElementById "content"
) |> ignore

let saveBooks = SaveReadBooks >> store.dispatch
let saveBookDetails = SaveBooksDetails >> store.dispatch

let login accessToken accessTokenSecret userName =
    startDownloadReadBooks accessToken accessTokenSecret saveBooks saveBookDetails
    store.dispatch (Login (accessToken, accessTokenSecret, userName))

let token = getQueryVariable "oauth_token"
let secret = Globals.cookies.get ("authorizationTokenSecret")
match token with
| Some token -> 
    let url = completeUrlWithToken "authenticate" token secret.Value
    fetchAs<LoggedUserData> url [] |> Promise.map (
        saveAccessToken 
        >> (fun userData -> login userData.AccessToken userData.AccessTokenSecret userData.UserName) 
        >> removeTokenFromLocation) 
    |> ignore
| None -> 
    let token = Globals.cookies.get ("accessToken")
    match token with
    | Some token -> 
        let secret = Globals.cookies.get ("accessTokenSecret")
        let userName = Globals.cookies.get ("userName")
        login token secret.Value userName.Value
    | None -> ()