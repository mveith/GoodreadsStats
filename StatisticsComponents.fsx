#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "BasicStatsCalculator.fsx"

open GoodreadsStats.Model
open Fable.Core.JsInterop
open Fable.Import
module R = Fable.Helpers.React
open R.Props
open BasicStatsCalculator
open Fable.Core

[<Pojo>]
type BasicStatsTableProps = { BasicStats :BasicStats }

type BasicStatsTable(props) as this = 
    inherit React.Component<BasicStatsTableProps, obj>(props)
    do base.setInitState([])


    let image icon =
        let iconStyle = sprintf "fa fa-%s fa-stack-1x fa-inverse" icon 
        R.span [ ClassName "fa-stack fa-4x"] [
            R.i [ ClassName "fa fa-circle fa-stack-2x text-primary"] []
            R.i [ ClassName iconStyle] []]

    let bookDescription (book : BookStatsData option) =
        match book with
        | Some book ->
            [ 
                R.span [] [ R.b [] [unbox book.Book.Title ]]
                R.br [] []
                R.i [] [ unbox "by" ]
                R.br [] []
                R.span [] [ unbox book.Book.Author ]
                R.br [] []
                unbox (sprintf "(%.2f pages / day)" (float book.PagesCount / float book.DaysCount)) ] 
        | None -> []

    let valueBox label icon content=
        R.div [ ClassName "col-md-2" ] [ 
                image icon  
                R.h4 [ ClassName "service-heading" ] [ unbox label ] 
                R.p [ ClassName "text-muted" ] content ]
        
    member x.render() = 
        let stats = this.props.BasicStats
        R.div [ ClassName "row text-center" ] [
                valueBox  "Books count" "book" [ unbox stats.BooksCount ]
                valueBox  "Number of pages" "database" [ unbox stats.PagesCount ]
                valueBox  "Average book" "arrows-h" [ unbox (sprintf "%.1f pages" stats.AveragePagesCount) ]
                valueBox  "Average speed" "bolt" [ unbox (sprintf "%.2f pages / day" stats.AverageSpeed) ]
                valueBox  "Fastest book" "thumbs-up" (bookDescription stats.FastestBook)
                valueBox  "Slowest book" "bed" (bookDescription stats.SlowestBook) ]

[<Pojo>]
type ReadBooksWrapper= { ReadBooks : ReadBook[] }

type BasicStatsSection(props) as this = 
    inherit React.Component<ReadBooksWrapper, obj>(props)
    do base.setInitState ([])

    let statsTable readBooks=
        match readBooks with
        | [||] -> R.div [ ClassName "row text-center"] [ unbox "Building stats..."]
        | readBooks -> 
            let stats = basicStats readBooks
            R.com<BasicStatsTable, _, _> {BasicStats = stats} []

    member x.render() =
        R.section [Id "basic-stats"] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-lg-12 text-center"] [
                        R.h2 [ClassName "section-heading"] [ unbox "Basic statistics"]
                        R.h3 [ClassName "section-subheading text-muted"] [ unbox "Basic statistics for read books."] ] ]
                statsTable this.props.ReadBooks
                ] ]

type TopTenSection(props) as this = 
    inherit React.Component<ReadBooksWrapper, obj>(props)
    do base.setInitState ([])

    let getBookContent title author=
        [
            R.b [] [unbox title]
            R.br [] []
            R.i [] [ unbox "by" ]
            R.br [] []
            R.span [] [ unbox author ]]

    let table rows caption units getElementContent=
        let createRow rank element value =
            R.tr [][
                    R.td [][ unbox rank]
                    R.td [] (getElementContent element)
                    R.td [][ unbox (sprintf "%.2f %s" value units)]]

        let rows = rows |> Seq.mapi (fun index (element, value)-> createRow (index + 1) element value) |> Seq.toList
        R.div [ ClassName (sprintf "col-md-%i" 4) ] [            
            R.h4 [ ClassName "service-heading" ] [unbox caption]
            R.table [ClassName "table table-hover"] [ R.tbody [] rows]]

    let topTenTable readBooks=
        match readBooks with
        | [||] -> R.div [ ClassName "row text-center"] [ unbox "Building stats..."]
        | readBooks -> 
            let validBooks = validBooks readBooks
            let booksSpeed = booksSpeed validBooks

            R.div [] [
                R.div [ ClassName "row text-center" ] [
                        table (booksSpeed |> Seq.take 10 |> Seq.map (fun b -> (b.Book, b.Speed))) "Fastest books" "pages / day" (fun b-> getBookContent b.Title b.Author)
                        table (booksSpeed |> Seq.toList |> List.rev |> Seq.take 10 |> Seq.map (fun b -> (b.Book, b.Speed))) "Slowest books" "pages / day" (fun b-> getBookContent b.Title b.Author)
                        table (validBooks |> Seq.sortByDescending (fun b-> b.NumPages) |> Seq.take 10 |> Seq.map (fun b-> (b, float b.NumPages)))  "Longest books" "Pages" (fun b-> getBookContent b.BookTitle b.AuthorName)]
                R.div [ ClassName "row text-center" ] [
                        table (validBooks |> Seq.sortBy (fun b-> b.NumPages) |> Seq.take 10 |> Seq.map (fun b-> (b, float b.NumPages)))  "Shortest books" "" (fun b-> getBookContent b.BookTitle b.AuthorName)
                        table []  "Top authors" "" (fun _-> [])
                        table []  "Top genres" "" (fun _-> [])]
                R.div [ ClassName "row text-center" ] [
                        table []  "Top shelves" "" (fun _-> [])
                        table []  "Top period" "" (fun _-> [])
                        table []  "Top original language" "" (fun _-> [])]]

    member x.render() =
        R.section [Id "top-ten"] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-lg-12 text-center"] [
                        R.h2 [ClassName "section-heading"] [ unbox "TOP 10"] ] ]
                topTenTable this.props.ReadBooks ] ]
