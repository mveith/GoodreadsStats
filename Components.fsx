#r "node_modules/fable-react/Fable.React.dll"
#load "Utils.fsx"
#load "Fable.Import.Redux.fsx"
#load "Statistics/StatisticsComponents.fsx"
#load "Actions.fsx"
#load "ReadBooksStorage.fsx"
#load "Filtering.fsx"

open Fable.Import.Global
open Actions
open Utils
open Model
open Fable.Core
open Fable.Import
module R = Fable.Helpers.React
open R.Props
open StatisticsComponents
open ReadBooksStorage
open Filtering

[<KeyValueList>]
type HtmlPropExtensions=
        | [<CompiledName("data-target")>] DataTarget of string            
        interface IHTMLProp

type Footer(props) as this = 
    inherit React.Component<obj, obj>(props)
    do base.setInitState []

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
[<Pojo>]
type HeaderProps = {OnLogin : unit -> unit; Logged:bool }

type Header(props) as this = 
    inherit React.Component<HeaderProps, obj>(props)
    do base.setInitState ([])

    let login event =
        this.props.OnLogin()

    member x.render() =            
        let loginButton =
            if not this.props.Logged then 
                R.button [ Id "login-button"; ClassName "page-scroll btn btn-xl"; OnClick login ] [unbox "Login"] 
                else unbox " " 
        
        let showStatsButton =
            if this.props.Logged then 
                R.a [ Href "#basic-stats"; ClassName "page-scroll btn btn-xl"] [unbox "Show"]
                else unbox " " 

        R.header [] [
            R.div [ClassName "container" ] [
                R.div [ClassName "intro-text"] [
                    R.div [ClassName "intro-lead-in"][ unbox "Welcome To Goodreads Statistics!"]
                    R.div [ClassName "intro-heading"] [ unbox "Discover bookworm in you."]
                    loginButton
                    unbox " "
                    showStatsButton]]]

[<Pojo>]
type NavigationProps = {Logged:bool; LoggedUserName:string; OnLogout : unit -> unit;}

type Navigation(props) as this = 
    inherit React.Component<NavigationProps, obj>(props)
    do base.setInitState([])

    let logout event =
        this.props.OnLogout()

    member x.render() =
        let menuItems()=
            let menuItemsForLoggedUser = 
                if this.props.Logged then                
                    [ R.li [] [ R.a [ClassName "page-scroll"; Href "#basic-stats"] [unbox "Basic statistics"]]
                      R.li [] [ R.a [ClassName "page-scroll"; Href "#top-ten"] [unbox "Top ten"]]
                      R.li [] [ R.a [ClassName "page-scroll"; Href "#charts"] [unbox "Charts"]]
                      R.li [] [ R.a [ClassName "page-scroll"; Href "#books"] [unbox "Books"]]
                      R.li [] [ R.a [ ClassName "logout-button"; Href "#logout"; OnClick logout] [unbox (this.props.LoggedUserName + " (Logout)")]]]
                else []

            let topButton = R.li [ClassName "hidden"] [ R.a [Href "#page-top"] []]
            topButton :: menuItemsForLoggedUser

        R.nav [Id "mainNav" ; ClassName "navbar navbar-default navbar-custom navbar-fixed-top affix-top"] [
            R.div [ClassName "container"] [
                R.div [ClassName "navbar-header page-scroll"] [
                    R.button [ClassName "navbar-toggle"; DataToggle "collapse"; DataTarget "#bs-navbar-collapse"] [
                        R.span [ClassName "sr-only"] [ unbox "Toggle navigation"]
                        R.i [ClassName "fa fa-bars"] []]
                    R.a [ClassName "navbar-brand page-scroll"; Href "#page-top"] [unbox "Goodreads Statistics"]]
                R.div [ClassName "collapse navbar-collapse"; Id "bs-navbar-collapse"] [
                    R.ul [ClassName "nav navbar-nav navbar-right"] (menuItems())]]]

[<Pojo>]
type BookFiltersState = { SelectedFilters : Filter list }

type AllBooksSection(props) as this=
    inherit React.Component<ReadBooksWrapper, BookFiltersState>(props)
    
    do this.setInitState({ SelectedFilters = [] })

    let filterSection (values: (string * Filter) list) title = 
        let props = 
            {
                ActualFilters  = fun _ -> this.state.SelectedFilters
                OnFilterSelected = fun f -> this.setState({this.state with SelectedFilters = f :: this.state.SelectedFilters})
                OnFilterUnselected = fun f -> this.setState({this.state with SelectedFilters = List.except [ f ] this.state.SelectedFilters})
                ReadBooks = this.props.ReadBooks
                Values = values 
                Title  = title
            }

        R.com<FilterSection, _, _> props []

    let bookImage filteredBooks book= 
        let className = if not (Set.contains book.BookId filteredBooks) then "book-image disabled" else "book-image"
        R.img [
            Src book.SmallImageUrl
            Alt book.BookTitle
            Title book.BookTitle
            ClassName className ] [] 

    let readDate book = 
        match book.ReadData with
        | Some read -> read.ReadAt
        | None -> System.DateTime.MinValue

    let images books =
        let filteredBooks = filterBooks books this.state.SelectedFilters
        books
        |> Seq.sortByDescending readDate
        |> Seq.map (bookImage filteredBooks)
        |> Seq.toList

    member x.render()= 
        R.section [Id "books"] [
                R.div [ClassName "container"] [
                    R.div [ClassName "row"] [
                        R.div [ClassName "col-lg-12 text-center"] [
                            R.h2 [ClassName "section-heading"] [ unbox "Books"] ] ]
                    R.div [ ClassName "col-md-3  hidden-xs  hidden-sm" ] [
                        R.div [] [
                                R.h4 [] [ unbox "Filters"]
                                filterSection (yearFilters this.props.ReadBooks) "Year"
                                filterSection (languageFilters this.props.Details) "Language"
                                filterSection (periodFilters this.props.Details) "Period"
                                filterSection (genreFilters this.props.Details) "Genre" ]]
                    R.div [ ClassName "col-md-9" ] [
                        R.div [] (images this.props.ReadBooks)]]]

[<Pojo>]
type AppState = {State : State; Dispatch : Action -> unit }
[<Pojo>]
type AppProps = { Store: Redux.IStore<State, Action> }

type App(props) as this =
    inherit React.Component<AppProps, AppState>(props)
    let dispatch = Redux.dispatch this.props.Store

    let getState() = { State=Redux.getState this.props.Store; Dispatch=dispatch }

    do base.setInitState(getState())
    do Redux.subscribe this.props.Store (getState >> this.setState)

    let saveAndReturnAuthorizationUrl (authData: AuthorizationUserData) =
        setCookie "authorizationToken" authData.Token 1
        setCookie "authorizationTokenSecret" authData.TokenSecret 1
        authData.Url

    let clearData()=
        removeCookie "accessToken"
        removeCookie "accessTokenSecret"
        removeCookie "userName"
        clearReadBooks()
        clearDetails()

    let login() = 
        clearData()
        let url = completeUrlWithClientUrl "authorizationUrl"
        fetchAsJson url (JsInterop.ofJson >> saveAndReturnAuthorizationUrl >> navigateTo)

    let logout() =
        clearData()
        navigateTo "/"
            
    member x.render() =
        let state = getState().State
        let statsComponents =
            if state.Logged then 
                let readBooksWrapper = {ReadBooksWrapper.ReadBooks = state.ReadBooks; Details = state.BooksDetails}
                [
                    R.com<BasicStatsSection, _, _> readBooksWrapper []
                    R.com<TopTenSection, _, _> readBooksWrapper []
                    R.com<ChartsSection, _, _> readBooksWrapper []
                    R.com<AllBooksSection, _, _> readBooksWrapper []
                ]
            else []
        R.div [] [
            R.com<Navigation, _, _> {Logged = state.Logged; LoggedUserName = state.LoggedUserName; OnLogout = logout} []
            R.com<Header, _, _> { OnLogin = login; Logged = state.Logged } []
            R.div [] statsComponents
            R.com<Footer, _, _> [] []
        ]