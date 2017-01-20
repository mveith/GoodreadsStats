module BasicStatsCalculator

#load "Model.fsx"

open GoodreadsStats.Model
open System

let isValidReadBook book = 
    book.ReadData.IsSome && book.NumPages > 0

let bookSpeed book = 
    let pagesCount = book.NumPages
    let readData = Option.get book.ReadData
    let startDate = readData.StartedAt.Date
    let endDate = readData.ReadAt.Date
    let daysCount = (endDate - startDate).TotalDays + 1.0
    (float pagesCount) / daysCount
    
let createBookData bookWithSpeed = 
    match bookWithSpeed with
    | Some(book, bookSpeed) -> 
        { Book =  
              { Title = book.BookTitle
                Author = book.AuthorName }
          PagesCount = book.NumPages
          DaysCount = int ((float book.NumPages) / bookSpeed) }
    | None -> 
        { Book = 
              { Title = ""
                Author = "" }
          PagesCount = 0
          DaysCount = 0 }

let averageSpeed books =
    if (books |> Seq.isEmpty) then 0.0
    else 
        let getBookDays book = 
            let readData = Option.get book.ReadData
            let daysCount = int ((readData.ReadAt - readData.StartedAt).TotalDays)
            [ 0..daysCount ] |> Seq.map (float >> readData.StartedAt.Date.AddDays)
        
        let days = 
            books
            |> Seq.collect getBookDays
            |> Seq.distinct
        
        let pagesCount = float (books |> Seq.sumBy (fun book -> (book.NumPages)))
        let daysCount = float (days |> Seq.length)
        pagesCount / daysCount

let basicStats (readBooks:ReadBook[]) = 
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
        else validBooks |> Seq.averageBy (fun p -> double p.NumPages)
    { BooksCount = validBooks.Length
      PagesCount = validBooks |> Seq.sumBy (fun p -> p.NumPages)
      SlowestBook = createBookData slowestBook
      FastestBook = createBookData fastestBook
      AverageSpeed = averageSpeed validBooks
      AveragePagesCount = averagePagesCount }
