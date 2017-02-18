#load "../Model.fsx"
#load "../Fable.Import.Chartjs.fsx"
#load "BasicStatsCalculator.fsx"

open Model
open Fable.Import.Chartjs
open BasicStatsCalculator

let readBooks ((readBooks, details) : ReadBook[] * BookDetail[]) = readBooks

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

let chartData (data: (string * 'b) list)=
        {
            Labels =  data |> Seq.map (fst >> string) |> Seq.toArray
            Datasets = 
                [| 
                    { 
                        Label  = None
                        Data = data |> Seq.map (snd >> unbox) |> Seq.toArray
                    }|]}

let renderChart data canvasId =
    let options = 
        { 
            Scales = Some { YAxes = [| { Ticks = { BeginAtZero = true } } |]; XAxes = [||] }
            Legend = Some { Display  = false}
            Title = None }
    renderChart { CanvasId = canvasId; Type = Bar; Data = data; Options = Some options }

let destroyExistingChart chart =
    match chart with
    | Some chart -> chart.Destroy()
    | None -> ()
