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

let bookItem (book : ReadBook) = R.div [] [ unbox book.Title ]

type BooksList(props) as this = 
    inherit React.Component<BLProps, BLState>(props)
    do this.state <- { books = [||] }
    let saveBooks books = this.setState { books = books }
    
    let updateState = 
        string
        >> JS.JSON.parse
        >> unbox
        >> saveBooks
    
    member x.componentDidMount() = 
        let url = completeUrlWithToken "readed" props.accessToken props.accessTokenSecret
        ajax url updateState |> ignore
    
    member x.render() = 
        let items = x.state.books |> Array.map (fun b -> R.fn bookItem b [])
        R.div [ ClassName "bookList" ] [ R.h1 [] [ unbox "Přečtené knihy" ]
                                         unbox items ]

and BLProps = 
    { accessToken : string
      accessTokenSecret : string }

and BLState = 
    { books : ReadBook [] }
