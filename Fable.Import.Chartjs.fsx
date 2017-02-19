#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop

type ChartDataset =
    { 
        Label :string option
        Data : seq<obj> 
    }
    
type ChartData =
    { 
        Labels : string[]
        Datasets : ChartDataset array
    }

type ChartTicks =
    { BeginAtZero : bool }

type ChartAxis =
    { Ticks : ChartTicks }

type ChartScales =
    { 
        YAxes : ChartAxis array 
        XAxes : ChartAxis array 
    } 

type LegendPosition=
    | Top
    | Left
    | Bottom
    | Right

type ChartLegend=
    { 
        Position : LegendPosition option
        FullWidth : bool option
    }

type ChartOptions =
    { 
        Scales : ChartScales option
        Title : string option
        Legend : ChartLegend option
    }

type ChartType=
    | Bar
    | HorizontalBar
    | Line
    | Radar
    | PolarArea
    | Pie
    | Doughnut
    | Bubble

type ChartInfo =
    { 
        Type : ChartType
        Options : ChartOptions option
        Data : ChartData
        CanvasId : string 
    }
 
let private append (fields: (string*obj) list) key o map =
    match o with
    | Some v -> 
        (key ==> (map v)) :: fields
    | None -> fields
   
let private createDataset (dataset: ChartDataset)=
    createObj [
        "label" ==> dataset.Label
        "data"==> (dataset.Data  |> Seq.toArray) ]

let private createData data =
    createObj [
        "labels" ==> data.Labels
        "datasets"==> (data.Datasets |> Seq.map createDataset |> Seq.toArray)]
        
let private createAxis a = 
    createObj [
        "ticks" ==> 
            createObj [
                "beginAtZero" ==> a.Ticks.BeginAtZero]]

let private createScales scales=
    createObj [
        "yAxes" ==> (scales.YAxes |> Seq.map createAxis |> Seq.toArray)
        "xAxes" ==> (scales.XAxes |> Seq.map createAxis |> Seq.toArray)]

let private createLegendPosition = function
    | Top -> "top"
    | Left -> "left"
    | Bottom -> "bottom"
    | Right -> "right"

let private createLegend legend=
    match legend with
    | Some legend -> 
        let fields = ["display" ==> true]
        let fields = append fields "fullWidth" legend.FullWidth id
        let fields = append fields "position" legend.Position createLegendPosition
        createObj fields
    | None -> createObj ["display" ==> false]

let private createTitle title=
    match title with
    | Some title -> createObj ["display" ==> true; "text" ==> title]
    | None -> createObj ["display" ==> false]

let private createOptions o =
    let fields =  []
    let fields = append fields "scales" o.Scales createScales
    let fields = ("legend"==> createLegend o.Legend) :: fields
    let fields = ("title" ==> createTitle o.Title) :: fields

    createObj fields

let private convertType = function
    | Line -> "line"
    | Bar -> "bar"
    | HorizontalBar -> "horizontalBar"
    | Radar -> "radar"
    | PolarArea -> "polarArea"
    | Pie -> "pie"
    | Doughnut -> "doughnut"
    | Bubble -> "bubble"

[<Global>]
type private Chart(ctx:Browser.HTMLElement, settings:obj) =
    member x.destroy () = failwith "JS only"

type RenderedChart =
    {
        Destroy : unit -> unit
    }

let renderChart chart=
    let ctx = Browser.document.getElementById chart.CanvasId

    let settings = 
        createObj [
            "type" ==> convertType chart.Type
            "data"==> createData chart.Data 
            "options" ==>  (chart.Options |> Option.map createOptions) ]
    let chart = new Chart(ctx, settings)
    { Destroy = chart.destroy }