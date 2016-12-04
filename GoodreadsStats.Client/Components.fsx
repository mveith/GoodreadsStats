#r "node_modules/fable-core/Fable.Core.dll"
#load "Fable.Import.Global.fsx"
#load "node_modules/fable-import-react/Fable.Import.React.fs"
#load "node_modules/fable-import-react/Fable.Helpers.React.fs"
#load "../GoodreadsStats.Model/Model.fs"
#load "Utils.fsx"

module R = Fable.Helpers.React

open Fable.Import
open Fable.Import.Global
open Utils
open R.Props
open GoodreadsStats.Model

type AccessTokenData = 
    { accessToken : string
      accessTokenSecret : string }

type BasicStatsTable(props) as this = 
    inherit React.Component<BasicStats, BasicStats>(props)
    do this.state <- props
    
    let image icon =
        let iconStyle = sprintf "fa fa-%s fa-stack-1x fa-inverse" icon 
        R.span [ ClassName "fa-stack fa-4x"] [
            R.i [ ClassName "fa fa-circle fa-stack-2x text-primary"] []
            R.i [ ClassName iconStyle] []]

    let bookDescription (book : BookData) = 
        [ 
            R.span [] [ R.b [] [unbox book.Book.Title ]]
            R.br [] []
            R.i [] [ unbox "by" ]
            R.br [] []
            R.span [] [ unbox book.Book.Author ]
            R.br [] []
            unbox (sprintf "(%.2f pages / day)" (float book.PagesCount / float book.DaysCount)) ] 

    let valueBox label icon content=
        R.div [ ClassName "col-md-2" ] [ 
                image icon  
                R.h4 [ ClassName "service-heading" ] [ unbox label ] 
                R.p [ ClassName "text-muted" ] content ]

    member x.render() = 
        let stats = this.state
        R.div [ ClassName "row text-center" ] 
            [
                valueBox  "Books count" "book" [ unbox stats.BooksCount ]
                valueBox  "Number of pages" "database" [ unbox stats.PagesCount ]
                valueBox  "Average book" "arrows-h" [ unbox (sprintf "%.1f pages" stats.AveragePagesCount) ]
                valueBox  "Average speed" "bolt" [ unbox (sprintf "%.2f pages / day" stats.AverageSpeed) ]
                valueBox  "Fastest book" "thumbs-up" (bookDescription stats.FastestBook)
                valueBox  "Slowest book" "bed" (bookDescription stats.SlowestBook) ]

type BasicStatsSection(props) as this = 
    inherit React.Component<AccessTokenData, BasicStatsSectionState>(props)
    do this.state <- { Stats = None }

    let saveStats (books : BasicStats) = this.setState ({ Stats = Some books })
    
    let updateState = 
        string
        >> JS.JSON.parse
        >> unbox
        >> saveStats
 
    let statsTable stats=
        match stats with
        | Some stats -> R.com<BasicStatsTable, _, _> stats []
        | None -> R.div [ ClassName "row text-center"] [ unbox "Building stats..."]

    member x.componentDidMount() = 
        let url = completeUrlWithToken "basicStats" props.accessToken props.accessTokenSecret
        ajax url updateState |> ignore
    
    
    member x.render() =
        R.section [Id "basic-stats"] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-lg-12 text-center"] [
                        R.h2 [ClassName "section-heading"] [ unbox "Basic statistics"]
                        R.h3 [ClassName "section-subheading text-muted"] [ unbox "Basic statistics for read books."] ] ]
                statsTable this.state.Stats ] ]

and BasicStatsSectionState = { Stats : BasicStats option;  }

type Footer(props) as this = 
    inherit React.Component<obj, obj>(props)
    do this.state <- []

    member x.render() =
        R.footer [] [
            R.div [ClassName "container"] [
                R.div [ClassName "row"] [
                    R.div [ClassName "col-md-6"][
                        R.span [ClassName "copyright"] [ unbox (sprintf "Copyright © Goodreads Stats %i" System.DateTime.Today.Year)]]
                    R.div [ClassName "col-md-6"] [
                            R.ul [ClassName "list-inline social-buttons"] [
                                R.li [] [
                                    R.a [ Href "#"] [
                                        R.i [ ClassName "fa fa-twitter"] []]]]]]]]

type Header(props) as this = 
    inherit React.Component<obj, obj>(props)
    do this.state <- []

    member x.render() =
        R.header [] [
            R.div [ClassName "container" ] [
                R.div [ClassName "intro-text"] [
                    R.div [ClassName "intro-lead-in"][ unbox "Welcome To Goodreads Statistics!"]
                    R.div [ClassName "intro-heading"] [ unbox "Discover bookworm in you."]
                    R.button [ Id "login-button"; ClassName "page-scroll btn btn-xl"] [unbox "Login"]
                    unbox " "
                    R.a [ Href "#basic-stats"; ClassName "page-scroll btn btn-xl"] [unbox "Show"]]]]


type Navigation(props) as this = 
    inherit React.Component<obj, obj>(props)
    do this.state <- []

    member x.render() =
        R.nav [Id "mainNav" ; ClassName "navbar navbar-default navbar-custom navbar-fixed-top affix-top"] [
            R.div [ClassName "container"] [
                R.div [ClassName "navbar-header page-scroll"] [
                    R.a [ClassName "navbar-brand page-scroll"; Href "#page-top"] [unbox "Goodreads Statistics"]]
                R.div [] [
                    R.ul [ClassName "nav navbar-nav navbar-right"] [
                        R.li [ClassName "hidden"] [ R.a [Href "#page-top"] []]
                        R.li [] [ R.a [ClassName "page-scroll"; Href "#basic-stats"] [unbox "Basic statistics"]]]]]]