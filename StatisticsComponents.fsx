#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "BasicStatsCalculator.fsx"
#load "TopTables.fsx"

open Model
open Fable.Core.JsInterop
open Fable.Import
module R = Fable.Helpers.React
open R.Props
open BasicStatsCalculator
open Fable.Core
open TopTables

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
type ReadBooksWrapper= { ReadBooks : ReadBook[]; Details : BookDetail[] }

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

[<Pojo>]
type TopTenSectionState = { SelectedKey : string }

type TopDescription = { Key : string; TableFactory : (ReadBook[] * BookDetail[]) -> React.ReactElement; Title : string }

type TopTenSection(props) as this = 
    inherit React.Component<ReadBooksWrapper, TopTenSectionState>(props)
    do base.setInitState ({ SelectedKey =  "Fastest"})

    let table rows=
        let createRow rank rowContent value =
            R.tr [][
                    R.td [][ unbox rank]
                    R.td [] rowContent
                    R.td [][ unbox value]]

        let rows = rows |> Seq.mapi (fun index (rowContent, value)-> createRow (index + 1) rowContent value) |> Seq.toList
        R.table [ClassName "table table-hover"] [ R.tbody [] rows]

    let tops = 
        [
            { Key = "Fastest"; Title = "Fastest books"; TableFactory = booksBySpeed >> Seq.truncate 10 >> table }            
            { Key = "Slowest"; Title = "Slowest books"; TableFactory = booksBySpeed >> List.rev >> Seq.truncate 10 >> table }            
            { Key = "Longest"; Title = "Longest books*"; TableFactory = booksByLength >> Seq.truncate 10 >> table }
            { Key = "Shortest"; Title = "Shortest books*"; TableFactory = booksByLength >> List.rev >> Seq.truncate 10 >> table }
            { Key = "Authors"; Title = "Top authors*"; TableFactory = booksByAuthors >> Seq.truncate 10 >> table }
            { Key = "Genres"; Title = "Top genres*"; TableFactory = booksByGenres >> Seq.truncate 10 >> table }
            { Key = "Shelves"; Title = "Top shelves*"; TableFactory = fun p -> table [] }
            { Key = "Periods"; Title = "Top periods*"; TableFactory = booksByPeriods >> Seq.truncate 10 >> table }
            { Key = "Language"; Title = "Top original language*"; TableFactory = fun p -> table [] }
        ]

    let selectTop t = this.setState({ SelectedKey = t.Key })

    let topMenuItem t= 
        let className = if this.state.SelectedKey = t.Key then "active" else ""
        R.li [ Role "presentation"; OnClick (fun _ -> selectTop t); ClassName className ] [ R.a [] [unbox t.Title] ]

    member x.render() =
        let topMenuItems = tops |> Seq.map topMenuItem |> Seq.toList
        let selectedTop = tops |> Seq.filter (fun t -> t.Key = this.state.SelectedKey) |> Seq.head
        let selectedTopTable = selectedTop.TableFactory(this.props.ReadBooks, this.props.Details)

        R.section [Id "top-ten"] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-lg-12 text-center"] [
                        R.h2 [ClassName "section-heading"] [ unbox "TOP 10"] ] ]
                R.div [ ClassName "col-md-3" ] [            
                    R.ul [ ClassName "nav nav-pills nav-stacked"] topMenuItems
                    R.br [] []
                    R.span [] [ R.i [] [ unbox (sprintf "* From all %i read books " this.props.ReadBooks.Length) ]]]
                R.div [ ClassName "col-md-9" ] [ 
                    R.h4 [ ClassName "service-heading" ] [unbox selectedTop.Title]
                    selectedTopTable]]]
