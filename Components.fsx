#r "node_modules/fable-react/Fable.React.dll"
#load "Utils.fsx"
#load "BasicStatsCalculator.fsx"
#load "Fable.Import.Redux.fsx"

open Fable.Import.Global
open Utils
open GoodreadsStats.Model
open Fable.Core
open Fable.Import
module R = Fable.Helpers.React
open R.Props
open BasicStatsCalculator
open Fable.Import.Redux

[<Pojo>]
type AccessTokenData = 
    { accessToken : string
      accessTokenSecret : string }

type Action =
    | Login of string * string * string
    | SaveReadBooks of ReadBook[]

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

    let bookDescription (book : BookStatsData) = 
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
        let showBasicStatsButton = 
            if this.props.Logged then 
                R.li [] [ R.a [ClassName "page-scroll"; Href "#basic-stats"] [unbox "Basic statistics"]]
                else unbox " " 

        let showLogoutButton = 
            if this.props.Logged then 
                R.li [] [ R.a [ ClassName "logout-button"; Href "#logout"; OnClick logout] [unbox (this.props.LoggedUserName + " (Logout)")]]
                else unbox " "

        R.nav [Id "mainNav" ; ClassName "navbar navbar-default navbar-custom navbar-fixed-top affix-top"] [
            R.div [ClassName "container"] [
                R.div [ClassName "navbar-header page-scroll"] [
                    R.a [ClassName "navbar-brand page-scroll"; Href "#page-top"] [unbox "Goodreads Statistics"]]
                R.div [] [
                    R.ul [ClassName "nav navbar-nav navbar-right"] [
                        R.li [ClassName "hidden"] [ R.a [Href "#page-top"] []]
                        showBasicStatsButton
                        showLogoutButton ]]]]

type State =  { Logged:bool; ReadBooks: ReadBook[]; AccessData : AccessTokenData option; LoggedUserName:string; }

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

    let login()= 
        ajax (completeUrlWithClientUrl "authorizationUrl") (string
                                           >> Fable.Core.JsInterop.ofJson
                                           >> saveAndReturnAuthorizationUrl
                                           >> navigateTo)
    let logout()= 
        removeCookie "accessToken"
        removeCookie "accessTokenSecret"
        removeCookie "userName"
        Browser.localStorage.removeItem "readBooks"
        navigateTo "/"
        
    member x.render() =
        let state = getState().State
        let statsComponents =
            if state.Logged then [R.com<BasicStatsSection, _, _> {ReadBooks =  state.ReadBooks} []]
            else []
        R.div [] [
            R.com<Navigation, _, _> {Logged = state.Logged; LoggedUserName = state.LoggedUserName; OnLogout = logout} []
            R.com<Header, _, _> { OnLogin = login; Logged = state.Logged } []
            R.div [] statsComponents
            R.com<Footer, _, _> [] []
        ]