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

let genreAndBookTuples detail=
    match detail.Genres with
    | [||] -> [ (None, detail.Id) ]
    | genres -> genres |> Seq.map (fun g -> (Some g, detail.Id)) |> Seq.toList

let genreFilters details= 
    details
    |> Seq.collect genreAndBookTuples
    |> Seq.groupBy fst
    |> Seq.sortByDescending (snd >> Seq.length)
    |> Seq.map (fun (genre, books) -> optionLabel genre, { Books = books |> Seq.map snd |> Seq.toList; Category = "Genres"})
    |> Seq.toList

let filterBooks books filters =
    let books = books |> Seq.map (fun b-> b.BookId) |> Set.ofSeq
    match filters with
    | [] -> books 
    | filters -> 
        let groupedFilters = filters |> Seq.groupBy (fun f-> f.Category)
        let availableBooksByCategories = groupedFilters |> Seq.map (fun (_, fs) -> fs |> Seq.collect (fun f-> f.Books) |> Set.ofSeq)
        availableBooksByCategories |> Seq.fold Set.intersect books

[<Pojo>]
type FilterItemProps = 
    {
        Title : string
        OnSelected : unit -> unit
        OnUnselected : unit -> unit
        WithFilterBooksCount : int
        WithoutFilterBooksCount : int
        IsSelected : bool
    }

type FilterItem(props) as this=
    inherit React.Component<FilterItemProps, obj>(props)
    
    do this.setInitState([])

    let onChange e =
        if this.props.IsSelected then
            this.props.OnUnselected()
        else 
            this.props.OnSelected()

    member x.render()=
        let id = System.Guid.NewGuid().ToString()
        let badgeLabel =
            if this.props.WithFilterBooksCount > this.props.WithoutFilterBooksCount then
                 sprintf "+%i" (this.props.WithFilterBooksCount - this.props.WithoutFilterBooksCount)
            else this.props.WithFilterBooksCount.ToString()

        let badge = if this.props.IsSelected then [] else [unbox badgeLabel]
        R.li [ ClassName "list-group-item"] [ 
            R.input [
                Id id
                Type "checkbox"
                OnChange onChange 
                Checked this.props.IsSelected] []
            R.label [ HtmlFor id; ClassName "filter-label"] [ unbox this.props.Title ]
            R.span [ClassName "badge"] badge]

[<Pojo>]
type FilterSectionState = { AllItemsVisible : bool }

[<Pojo>]
type FilterSectionProps = 
    {
        ActualFilters : unit -> Filter list
        OnFilterSelected : Filter -> unit
        OnFilterUnselected : Filter -> unit
        ReadBooks : seq<ReadBook>
        Values : (string * Filter) list
        Title : string
    }

type FilterSection(props) as this=
    inherit React.Component<FilterSectionProps, FilterSectionState>(props)
    
    do this.setInitState({ AllItemsVisible = false })

    let maxVisibleFilterItems = 5

    let filter title f = 
        let actualFilters = this.props.ActualFilters()

        let props = 
            {
                Title = title
                OnSelected =  fun _ -> this.props.OnFilterSelected f
                OnUnselected = fun _ -> this.props.OnFilterUnselected f
                WithFilterBooksCount = filterBooks this.props.ReadBooks (f::actualFilters) |> Seq.length
                WithoutFilterBooksCount = filterBooks this.props.ReadBooks actualFilters |> Seq.length
                IsSelected = List.contains f actualFilters
            }
        R.com<FilterItem, _, _> props []

    let visibleItems values actualFilters allItemsVisible=
        let items = 
            values
            |> Seq.map (fun (t, f)-> (f, filter t f)) 
            |> Seq.toList

        if allItemsVisible then items |> List.map snd
        else 
            let selectedItems = items |> List.filter (fun (f, e) -> List.contains f actualFilters) |> List.map snd
            let notSelectedItems = items |> List.filter (fun (f, e) -> not (List.contains f actualFilters)) |> List.map snd
            let notSelectedItemsToShow = notSelectedItems |> Seq.truncate (maxVisibleFilterItems - selectedItems.Length) |> Seq.toList
            items |> List.map snd |> List.filter (fun el -> (List.contains el selectedItems) || (List.contains el notSelectedItemsToShow))

    member x.render()=
        let items = visibleItems this.props.Values (this.props.ActualFilters()) this.state.AllItemsVisible

        let changeItemsVisibility _ =
            this.setState ({ this.state with AllItemsVisible = not this.state.AllItemsVisible})

        let changeItemsVisibilityLink = 
            let label = if this.state.AllItemsVisible then "Show less" else "Show all"
            R.li [ ClassName "list-group-item change-visibility-link"; OnClick changeItemsVisibility] [ 
                R.a [ ] [unbox label]]

        let items = 
            if this.props.Values.Length > maxVisibleFilterItems then items @ [ changeItemsVisibilityLink ]
            else items

        R.div [] [
            R.h5 [][unbox this.props.Title]
            R.ul [ClassName "list-group"] items]
