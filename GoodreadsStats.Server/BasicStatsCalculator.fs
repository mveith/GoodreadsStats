module BasicStatsCalculator

open GoodreadsStats.Model
open System

type ReadBook = 
    { ReadAt : DateTime option
      StartedAt : DateTime option
      NumPages : int option
      Book : Book }

let isValidReadBook book = 
    book.StartedAt.IsSome && book.ReadAt.IsSome && book.NumPages.IsSome && book.NumPages.Value > 0

let bookSpeed book = 
    let pagesCount = book.NumPages.Value
    let startDate = book.StartedAt.Value.Date
    let endDate = book.ReadAt.Value.Date
    let daysCount = (endDate - startDate).TotalDays + 1.0
    (float pagesCount) / daysCount
    
let createBookData bookWithSpeed = 
    match bookWithSpeed with
    | Some(book, bookSpeed) -> 
        Some { Book = book.Book
               PagesCount = book.NumPages.Value
               DaysCount = int ((float book.NumPages.Value) / bookSpeed) }
    | None -> None
    
let basicStats readBooks = 
    let validBooks = 
        readBooks
        |> Seq.filter isValidReadBook
        |> Seq.toArray
    
    let booksSpeed = 
        validBooks
        |> Seq.map (fun r -> (r, bookSpeed r))
        |> Seq.sortByDescending (fun (_, speed) -> speed)
    
    let fastestBook = booksSpeed |> Seq.tryHead
    let slowestBook = booksSpeed |> Seq.tryLast
    
    let averagePagesCount = 
        if (validBooks |> Seq.isEmpty) then 0.0
        else validBooks |> Seq.averageBy (fun p -> double p.NumPages.Value)
    { BooksCount = validBooks.Length
      PagesCount = validBooks |> Seq.sumBy (fun p -> p.NumPages.Value)
      SlowestBook = createBookData slowestBook
      FastestBook = createBookData fastestBook
      AverageSpeed = 100.0
      AveragePagesCount = averagePagesCount }
