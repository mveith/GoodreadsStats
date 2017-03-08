#load "../Model.fsx"
#load "../Fable.Import.Chartjs.fsx"
#load "BasicStatsCalculator.fsx"
#load "../Colors.fsx"
#load "../Periods.fsx"

open Model
open Fable.Import.Chartjs
open BasicStatsCalculator
open Colors

let readBooks ((readBooks, details) : ReadBook[] * BookDetail[]) = readBooks
let details ((readBooks, details) : ReadBook[] * BookDetail[]) = details

let booksByYearOfRead = 
    readBooks
    >> Seq.filter (fun b -> Option.isSome b.ReadData)
    >> Seq.groupBy (fun b -> (Option.get b.ReadData).ReadAt.Year)
    >> Seq.map (fun (year, books) -> (string year, books |> Seq.length))
    >> Seq.sortBy fst
    >> Seq.toList
    
let pagesCountByYearOfRead = 
    readBooks
    >> Seq.filter (fun b -> Option.isSome b.ReadData)
    >> Seq.groupBy (fun b -> (Option.get b.ReadData).ReadAt.Year)
    >> Seq.map (fun (year, books) -> (string year, books |> Seq.sumBy (fun b->b.NumPages)))
    >> Seq.sortBy fst
    >> Seq.toList

let newAuthorsByYears =
    readBooks 
    >> Seq.filter (fun b -> Option.isSome b.ReadData)
    >> Seq.groupBy (fun b -> b.AuthorName) 
    >> Seq.map (fun (authorName, books) -> (authorName, books |> Seq.map (fun b -> b.ReadData.Value.ReadAt.Year) |> Seq.sort |> Seq.head))
    >> Seq.groupBy snd
    >> Seq.map (fun (y, authors) -> (string y, authors |> Seq.length))
    >> Seq.sortBy fst
    >> Seq.toList

let averageSpeedByYears =
    readBooks 
    >> validBooks
    >> Seq.groupBy (fun b -> (Option.get b.ReadData).ReadAt.Year)
    >> Seq.map (fun (year, books) -> (string year, System.Math.Round(averageSpeed books, 2)))
    >> Seq.sortBy fst
    >> Seq.toList

let booksByShelves =
    let shelveBookPairs book =
        match book.Shelves with
        | [||] -> Seq.singleton ("no shelf", book)
        | shelves -> shelves |> Seq.map (fun s -> (s, book))
    readBooks 
    >> Seq.collect shelveBookPairs 
    >> Seq.groupBy fst 
    >> Seq.sortByDescending (snd >> Seq.length) 
    >> Seq.map (fun (shelf, books) -> (shelf, (books |> Seq.length)))
    >> Seq.toList

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
    >> Seq.groupBy fst
    >> Seq.sortByDescending (snd >> Seq.length)
    >> Seq.map (fun ((year,_,_), details) -> (string year, details |> Seq.length))
    >> Seq.toList


let random()= 
    let random = new System.Random()
    random.Next()

let randomColors length=
    Colors.colors |> Seq.sortBy (fun _ -> random()) |> Seq.take length

let barChartData (data: (string * 'b) list)=
    let colors = randomColors (data |> Seq.length) |> Seq.toArray
    Bar {
        Labels =  data |> Seq.map (fst >> string) |> Seq.toArray
        Datasets = 
            [| 
                { 
                    Label  = None
                    Data = data |> Seq.map (snd >> unbox) |> Seq.toArray
                    BackgroundColor = colors |> Seq.map (fun c -> { c with A = 0.5 }) |> Seq.toArray |> Some
                    BorderColor = colors |> Seq.toArray |> Some
                    BorderWidth = Some 1
                }|]}

let lineChartData (data: (string * 'b) list)=
        Line {
            Labels =  data |> Seq.map (fst >> string) |> Seq.toArray
            Datasets = 
                [| 
                    { 
                        Label  = None
                        Data = data |> Seq.map (snd >> unbox) |> Seq.toArray
                        Fill = false
                        InterpolationMode = Monotone
                    }|]}

let pieChartData (data: (string * 'b) list)=
    let colors = randomColors (data |> Seq.length) |> Seq.toArray
    Pie {
        Labels =  data |> Seq.map (fst >> string) |> Seq.toArray
        Datasets = 
            [| 
                { 
                    Label  = None
                    Data = data |> Seq.map (snd >> unbox) |> Seq.toArray
                    BackgroundColor = colors |> Seq.map (fun c -> { c with A = 0.5 }) |> Seq.toArray |> Some
                    BorderColor = colors |> Seq.toArray |> Some
                    BorderWidth = Some 1
                }|]}

let scales = function
    | Line _ -> Some { XAxes = [||]; YAxes = [| {Ticks = { BeginAtZero = false }} |]}
    | Bar _ -> Some { XAxes = [||]; YAxes = [| {Ticks = { BeginAtZero = true }} |]}
    | _ -> None

let renderChart data canvasId legend =
    let options = 
        { 
            Scales = scales data
            Legend = legend
            Title = None }
    renderChart { CanvasId = canvasId; Data = data; Options = Some options }

let destroyExistingChart chart =
    match chart with
    | Some chart -> chart.Destroy()
    | None -> ()
