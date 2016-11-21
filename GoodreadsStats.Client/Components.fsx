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

let defaultBasicStats = 
    { BooksCount = 0
      PagesCount = 0
      SlowestBook = 
          { Book = 
                { Title = "???"
                  Author = "???" }
            PagesCount = 0
            DaysCount = 0 }
      FastestBook = 
          { Book = 
                { Title = "???"
                  Author = "???" }
            PagesCount = 0
            DaysCount = 0 }
      AverageSpeed = 0.0
      AveragePagesCount = 0.0 }

type BasicStatsTable(props) as this = 
    inherit React.Component<AccessTokenData, BasicStats>(props)
    do this.state <- defaultBasicStats
    let saveStats (books : BasicStats) = this.setState books
    
    let updateState = 
        string
        >> JS.JSON.parse
        >> unbox
        >> saveStats
    
    let bookDescription (book : BookData) = 
        [ R.span [] [ unbox book.Book.Title ]
          R.span [] [ unbox (sprintf " (%s)" book.Book.Author) ] ]
    
    member x.componentDidMount() = 
        let url = completeUrlWithToken "basicStats" props.accessToken props.accessTokenSecret
        ajax url updateState |> ignore
    
    member x.render() = 
        let stats = this.state
        R.div [ ClassName "basicStatsTable" ] [ R.h1 [] [ unbox "Basic statistics" ]
                                                R.table [] [ R.tr [] [ R.td [] [ unbox "Books count" ]
                                                                       R.td [] [ unbox stats.BooksCount ] ]
                                                             R.tr [] [ R.td [] [ unbox "Number of pages" ]
                                                                       R.td [] [ unbox stats.PagesCount ] ]
                                                             R.tr [] [ R.td [] [ unbox "Average book length" ]
                                                                       R.td [] [ unbox stats.AveragePagesCount ] ]
                                                             R.tr [] [ R.td [] [ unbox "Average speed" ]
                                                                       R.td [] [ unbox stats.AverageSpeed ] ]
                                                             R.tr [] [ R.td [] [ unbox "Fastest book" ]
                                                                       R.td [] (bookDescription stats.FastestBook) ]
                                                             R.tr [] [ R.td [] [ unbox "Slowest book" ]
                                                                       R.td [] (bookDescription stats.SlowestBook) ] ] ]
