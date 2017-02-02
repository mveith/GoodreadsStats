#load "Model.fsx"
#load "Actions.fsx"
#load "Utils.fsx"
#load "Components.fsx"
#load "Reducer.fsx"
#load "Fable.Import.Global.fsx"

open Fable.Import.Global
open Utils
open Model
open Actions

let booksPerPage = 10.0
 
let downloadReadBooksOnPage accessToken accessTokenSecret (callback: ReadBook[] -> unit) page =
    let url = completeUrl (sprintf "readBooks?token=%s&tokenSecret=%s&perPage=%i&page=%i" accessToken accessTokenSecret (int booksPerPage) page)
    ajax url (string >> Fable.Core.JsInterop.ofJson >> callback) |> ignore

let pagesCount booksCount = booksCount / booksPerPage |> System.Math.Ceiling |> int

let startDownloadReadBooks accessToken accessTokenSecret callback =
    let getReadBooks booksCount = [1..(pagesCount booksCount)] |> Seq.iter (downloadReadBooksOnPage accessToken accessTokenSecret callback)
    let readBooksCountUrl = completeUrlWithToken "readBooksCount" accessToken accessTokenSecret
    ajax readBooksCountUrl (string >> float >> getReadBooks)