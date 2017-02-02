#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-powerpack/Fable.PowerPack.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "Model.fsx"
#load "Fable.Import.Global.fsx"
#load "Utils.fsx"
#load "Components.fsx"
#load "ReadBooksStorage.fsx"

open Fable.Import
open Fable.Import.Global
open Components
open Utils
open Model
open ReadBooksStorage

module R = Fable.Helpers.React

let saveReadBooks actualState books =
    let readBooks = Array.concat [ actualState.ReadBooks ; books] |> Seq.groupBy (fun b -> b.ReviewId) |> Seq.map (fun (key, group)-> group |> Seq.last) |> Seq.toArray
    ReadBooksStorage.save readBooks 
    { actualState with ReadBooks = readBooks}

let reducer (state: State) = function
    | Login (token, secret, userName)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }; LoggedUserName = userName}
    | SaveReadBooks books -> saveReadBooks state books

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

let getReadBooks accessToken accessTokenSecret =
    let getReadBooks booksCount =
        let booksPerPage = 10.0
        let pagesCount = booksCount / booksPerPage |> System.Math.Ceiling |> int

        for i in 1..pagesCount do
            let saveBooks books= 
                Redux.dispatch store (SaveReadBooks books) 
            let url = completeUrl (sprintf "readBooks?token=%s&tokenSecret=%s&perPage=%i&page=%i" accessToken accessTokenSecret (int booksPerPage) i)
            ajax url (string >> Fable.Core.JsInterop.ofJson >> saveBooks) |> ignore

    let readBooksCountUrl = completeUrlWithToken "readBooksCount" accessToken accessTokenSecret
    ajax readBooksCountUrl (string >> float >> getReadBooks)

let login accessToken accessTokenSecret userName =
    getReadBooks accessToken accessTokenSecret
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