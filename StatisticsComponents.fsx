#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "BasicStatsCalculator.fsx"

open Model
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
                R.span [] [ R.b [] [unbox book.Book.BookTitle ]]
                R.br [] []
                R.i [] [ unbox "by" ]
                R.br [] []
                R.span [] [ unbox book.Book.AuthorName ]
                R.br [] []
                unbox (sprintf "(%.2f pages / day)" (float book.Book.NumPages / float book.DaysCount)) ] 
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
                statsTable this.props.ReadBooks ]]

type TopTenSection(props) as this = 
    inherit React.Component<ReadBooksWrapper, obj>(props)
    do base.setInitState ([])

    let getBookContent book=
        [
            R.b [] [unbox book.BookTitle]
            R.br [] []
            R.i [] [ unbox "by" ]
            R.br [] []
            R.span [] [ unbox book.AuthorName ]]

    let table rows caption=
        let createRow rank rowContent value =
            R.tr [][
                    R.td [][ unbox rank]
                    R.td [] rowContent
                    R.td [][ unbox value]]

        let rows = rows |> Seq.mapi (fun index (rowContent, value)-> createRow (index + 1) rowContent value) |> Seq.toList
        R.div [ ClassName "col-md-4" ] [            
            R.h4 [ ClassName "service-heading" ] [unbox caption]
            R.table [ClassName "table table-hover"] [ R.tbody [] rows]]

    let topTenTable readBooks=
        match readBooks with
        | [||] -> R.div [ ClassName "row text-center"] [ unbox "Building stats..."]
        | readBooks -> 
            let validBooks = validBooks readBooks
            let booksSpeed = booksSpeed validBooks

            let booksBySpeed= 
                booksSpeed 
                |> Seq.map (fun b -> (getBookContent b.Book, sprintf "%.2f pages / day" b.Speed)) 
                |> Seq.toList

            let booksByLength = 
                readBooks 
                |> Seq.filter (fun b -> b.NumPages > 0)
                |> Seq.sortByDescending (fun b-> b.NumPages) 
                |> Seq.map (fun b-> (getBookContent b, sprintf "%i pages" b.NumPages)) 
                |> Seq.toList

            let booksByAuthors = 
                readBooks 
                |> Seq.groupBy (fun b-> b.AuthorName) 
                |> Seq.sortByDescending (fun (key, values)-> values |> Seq.length) 
                |> Seq.map (fun (authorName, books) -> ([ unbox authorName], sprintf "%i books" (books |> Seq.length)))

            R.div [] [
                R.div [ ClassName "row text-center" ] [
                        table (booksBySpeed |> Seq.take 10) "Fastest books"
                        table (booksBySpeed |> List.rev |> Seq.take 10) "Slowest books"
                        table (booksByLength |> Seq.take 10)  "Longest books*"]
                R.div [ ClassName "row text-center" ] [
                        table (booksByLength |> List.rev |> Seq.take 10)  "Shortest books*"
                        table (booksByAuthors |> Seq.take 10)  "Top authors*"
                        table []  "Top genres*"]
                R.div [ ClassName "row text-center" ] [
                        table []  "Top shelves*"
                        table []  "Top period*"
                        table []  "Top original language*"]
                R.span [] [ R.i [] [ unbox (sprintf "* From all %i read books " readBooks.Length)]]]

    member x.render() =
        R.section [Id "top-ten"] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-lg-12 text-center"] [
                        R.h2 [ClassName "section-heading"] [ unbox "TOP 10"] ] ]
                topTenTable this.props.ReadBooks ] ]
