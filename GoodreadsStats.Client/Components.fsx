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
        R.p [ ClassName "text-muted" ] [ 
            R.span [] [ R.b [] [unbox book.Book.Title ]]
            R.br [] []
            R.i [] [ unbox "by" ]
            R.br [] []
            R.span [] [ unbox book.Book.Author ]
            R.br [] []
            unbox (sprintf "(%.2f pages / day)" (float book.PagesCount / float book.DaysCount)) ] 

    member x.render() = 
        let stats = this.state
        R.div [ ClassName "row text-center" ] 
            [ R.div [ ClassName "col-md-2" ] [
                image "book"  
                R.h4 [ ClassName "service-heading" ] [ unbox "Books count" ]
                R.p [ ClassName "text-muted" ] [ unbox stats.BooksCount ] ]
              R.div [ ClassName "col-md-2" ] [ 
                image "database"  
                R.h4 [ ClassName "service-heading" ] [ unbox "Number of pages" ] 
                R.p [ ClassName "text-muted" ] [ unbox stats.PagesCount ] ]
              R.div [ ClassName "col-md-2" ] [
                image "arrows-h"   
                R.h4 [ ClassName "service-heading" ] [ unbox "Average book" ]
                R.p [ ClassName "text-muted" ] [ unbox (sprintf "%.1f pages" stats.AveragePagesCount) ] ]
              R.div [ ClassName "col-md-2" ] [ 
                image "bolt"
                R.h4 [ ClassName "service-heading" ] [ unbox "Average speed" ]
                R.p [ ClassName "text-muted" ] [ unbox (sprintf "%.2f pages / day" stats.AverageSpeed) ] ]
              R.div [ ClassName "col-md-2" ] [
                image "thumbs-up"    
                R.h4 [ ClassName "service-heading" ] [ unbox "Fastest book" ]
                bookDescription stats.FastestBook ]
              R.div [ ClassName "col-md-2" ] [ 
                image "bed"    
                R.h4 [ ClassName "service-heading" ] [ unbox "Slowest book" ]
                bookDescription stats.SlowestBook ] ]

type BasicStatsSection(props) as this = 
    inherit React.Component<AccessTokenData, BasicStatsSectionState>(props)
    do this.state <- { Stats = None }

    let saveStats (books : BasicStats) = this.setState ({ Stats = Some books })
    
    let updateState = 
        string
        >> JS.JSON.parse
        >> unbox
        >> saveStats
 
    member x.componentDidMount() = 
        let url = completeUrlWithToken "basicStats" props.accessToken props.accessTokenSecret
        ajax url updateState |> ignore
    
    member x.render() =
        let stats = this.state.Stats 
        match stats with
        | Some stats -> R.com<BasicStatsTable, _, _> stats []
        | None -> R.div [ ClassName "row text-center"] [ unbox "Building stats..."]

and BasicStatsSectionState = { Stats : BasicStats option;  }