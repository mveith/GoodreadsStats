#r "../node_modules/fable-core/Fable.Core.dll"
#r "../node_modules/fable-react/Fable.React.dll"
#load "../Model.fsx"
#load "BasicStatsCalculator.fsx"
#load "Periods.fsx"

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

let yearPeriods year=
    match year with
    | Some year -> 
        Periods.periods 
        |> Seq.filter (fun (_, min, max) -> min <= year && year <= max) 
        |> Seq.toList
    | None -> []

let booksByPeriods =
    details 
    >> Seq.collect (fun d -> yearPeriods d.OriginalPublicationYear |> Seq.map (fun p -> (p, d))) 
    >> Seq.groupBy (fun (p, d) -> p)
    >> Seq.sortByDescending (fun (period, details) -> details |> Seq.length)
    >> Seq.map (fun ((label,_,_), details) -> ([R.span [] [ unbox label ]], sprintf "%i books" (details |> Seq.length)))

let booksByLanguages =
    details 
    >> Seq.filter (fun d -> Option.isSome d.Language)
    >> Seq.groupBy (fun d -> Option.get d.Language)
    >> Seq.sortByDescending (fun (lang, details) -> details |> Seq.length)
    >> Seq.map (fun (lang, details) -> ([R.span [] [ unbox lang ]], sprintf "%i books" (details |> Seq.length)))