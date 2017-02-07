#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "BasicStatsCalculator.fsx"

open Model
module R = Fable.Helpers.React
open BasicStatsCalculator

let getBookContent book=
    [
        R.b [] [unbox book.BookTitle]
        R.br [] []
        R.i [] [ unbox "by" ]
        R.br [] []
        R.span [] [ unbox book.AuthorName ]]

let readBooks ((readBooks, details) : ReadBook[] * BookDetail[]) = readBooks
let details ((readBooks, details) : ReadBook[] * BookDetail[]) = details
let validBooks = readBooks >> validBooks
let booksSpeed = validBooks >> booksSpeed
let booksBySpeed = booksSpeed >> Seq.map (fun b -> (getBookContent b.Book, sprintf "%.2f pages / day" b.Speed)) >> Seq.toList

let booksByLength = 
    readBooks 
    >> Seq.filter (fun b -> b.NumPages > 0) 
    >> Seq.sortByDescending (fun b-> b.NumPages) 
    >> Seq.map (fun b-> (getBookContent b, sprintf "%i pages" b.NumPages)) 
    >> Seq.toList

let booksByAuthors =
    readBooks 
    >> Seq.groupBy (fun b -> b.AuthorName) 
    >> Seq.sortByDescending (fun (key, values)-> values |> Seq.length) 
    >> Seq.map (fun (authorName, books) -> ([ R.span [] [ unbox authorName]], sprintf "%i books" (books |> Seq.length)))
    >> Seq.toList

let booksByGenres = 
    details
    >> Seq.collect (fun d -> d.Genres |> Seq.map (fun s -> (s, d.Id)))
    >> Seq.groupBy (fun (s, id) -> s)
    >> Seq.sortByDescending (fun (shelf, ids) -> ids |> Seq.length)
    >> Seq.map (fun (shelf, ids) -> ([R.span [] [ unbox shelf ]], sprintf "%i books" (ids |> Seq.length)))

let ordinal i=
    match i % 100 with
    | 11 | 12 | 13 -> "th"
    | _ ->
        match i % 10 with
        | 1 -> "st"
        | 2 -> "nd"
        | 3 -> "rd"
        | _ -> "th"

let createCentury i = 
    if i < 0 then 
        let index = abs i
        let min = i * 100
        (sprintf "%i%s century BC" index (ordinal index), min, min + 99)
    else 
        let index = i + 1 
        let min = i * 100 + 1
        (sprintf "%i%s century" index (ordinal index), min, min + 99)

let createDecade i = 
    let min = (1900 + (i * 10))
    let label = sprintf "%is" min
    (label, min, min + 10)

let centuries = [-30..30] |> Seq.map createCentury |> Seq.toList
let decades = [0..100] |> Seq.map createDecade |> Seq.toList
let periods =  centuries @ decades

let yearPeriods year=
    match year with
    | Some year -> 
        periods 
        |> Seq.filter (fun (_, min, max) -> min <= year && year <= max) 
        |> Seq.toList
    | None -> []

let booksByPeriods =
    details 
    >> Seq.collect (fun d -> yearPeriods d.OriginalPublicationYear |> Seq.map (fun p -> (p, d))) 
    >> Seq.groupBy (fun (p, d) -> p)
    >> Seq.sortByDescending (fun (period, details) -> details |> Seq.length)
    >> Seq.map (fun ((label,_,_), details) -> ([R.span [] [ unbox label ]], sprintf "%i books" (details |> Seq.length)))