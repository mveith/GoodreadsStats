module ReadBooksDownloader

open Utils
open Model
open Fable.PowerPack
open Fable.PowerPack.Fetch

let booksPerPage = 50.0

let downloadReadBooksOnPage accessToken accessTokenSecret (callback: ReadBooks -> unit) page =
    let url = completeUrl "readBooks" (sprintf "?token=%s&tokenSecret=%s&perPage=%i&page=%i" accessToken accessTokenSecret (int booksPerPage) page)
    fetchAs<ReadBooks> url [] |> Promise.map callback |> ignore

let downloadBooksDetailsOnPage accessToken accessTokenSecret (callback: BookDetails -> unit) page =
    let url = completeUrl "readBookDetails" (sprintf "?token=%s&tokenSecret=%s&perPage=%i&page=%i" accessToken accessTokenSecret (int booksPerPage) page)
    fetchAs<BookDetails> url [] |> Promise.map callback |> ignore
 
let pagesCount booksCount = (float booksCount) / booksPerPage |> System.Math.Ceiling |> int

let startDownloadReadBooks accessToken accessTokenSecret callback detailsCallback=
    let getReadBooks booksCount = 
        let booksCount = booksCount.Count
        [1..(pagesCount booksCount)] |> Seq.iter (downloadReadBooksOnPage accessToken accessTokenSecret callback)
    let readBooksCountUrl = completeUrlWithToken "readBooksCount" accessToken accessTokenSecret
    fetchAs<BooksCount> readBooksCountUrl [] |> Promise.map getReadBooks |> ignore