#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-react/Fable.React.dll"
#load "Periods.fsx"
#load "Model.fsx"

open Model
open Fable.Core
open Fable.Import
module R = Fable.Helpers.React
open R.Props

type Filter = { Books : int list; Category : string }

[<Pojo>]
type FilterItemState = { IsSelected : bool }

[<Pojo>]
type FilterItemProps = { Title : string; OnSelected : unit -> unit; OnUnselected : unit -> unit;  }

type FilterItem(props) as this=
    inherit React.Component<FilterItemProps, FilterItemState>(props)
    
    do this.setInitState({ IsSelected = false })

    let onChange e =
        if this.state.IsSelected then
            this.setState { this.state with IsSelected = false}
            this.props.OnUnselected()
        else 
            this.setState { this.state with IsSelected = true}
            this.props.OnSelected()

    member x.render()=
        let id = System.Guid.NewGuid().ToString()
        R.li [ ClassName "list-group-item"] [ 
            R.input [
                Id id
                Type "checkbox"
                OnChange onChange ] []
            R.label [ HtmlFor id; ClassName "filter-label"] [ unbox (sprintf "%s" this.props.Title) ]]

let optionLabel = function 
    | Some value -> sprintf "%O" value
    | None -> "Empty"

let year book = book.ReadData |> Option.map (fun rd -> rd.ReadAt.Year)

let yearFilters books = 
    books
    |> Seq.groupBy year
    |> Seq.map (fun (year, books) -> optionLabel year,{ Books = books |> Seq.map (fun b -> b.BookId) |> Seq.toList; Category = "Years"})
    |> Seq.toList

let languageFilters details= 
    details
    |> Seq.groupBy (fun d -> d.Language)
    |> Seq.sortByDescending (snd >> Seq.length)
    |> Seq.map (fun (language, books) -> optionLabel language, { Books =books |> Seq.map (fun d -> d.Id) |> Seq.toList; Category = "Languages"})
    |> Seq.toList

let bookInPeriod book (periodLabel, min, max) = 
    match book.OriginalPublicationYear with
    | Some year ->min <= year && year <= max
    | None -> false

let periodBooks allBooks period=
    match period with
    | Some p -> 
        allBooks |> Seq.filter (fun b-> bookInPeriod b p) |> Seq.toList
    | None -> allBooks |> Seq.filter (fun b-> Option.isNone b.OriginalPublicationYear) |> Seq.toList

let periodFilters details=
    let periodLabel = function
        | Some (label, _, _) -> label
        | None -> "Empty"
    None :: (Periods.periods |> List.map Some) 
    |> Seq.rev
    |> Seq.map (fun p -> periodLabel p, { Books = periodBooks details p |> Seq.map(fun b-> b.Id)  |> Seq.toList; Category = "Periods"})
    |> Seq.filter (fun (l, f) -> f.Books |> Seq.isEmpty |> not)
    |> Seq.toList

let isBookEnabled book actualFilters =
    match actualFilters with
    | [] -> true
    | actualFilters -> 
        let groupedFilters = actualFilters |> Seq.groupBy (fun f-> f.Category)
        let availableBooksByCategories = groupedFilters |> Seq.map (fun (_, fs) -> fs |> Seq.collect (fun f-> f.Books) |> Set.ofSeq)
        let availableBooks = availableBooksByCategories |> Seq.skip 1 |> Seq.fold Set.intersect (Seq.head availableBooksByCategories)
        Set.contains book.BookId availableBooks
