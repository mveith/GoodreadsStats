#r "node_modules/fable-react/Fable.React.dll"
#load "Utils.fsx"
#load "Fable.Import.Redux.fsx"
#load "StatisticsComponents.fsx"

open Fable.Import.Global
open Utils
open GoodreadsStats.Model
open Fable.Core
open Fable.Import
module R = Fable.Helpers.React
open R.Props
open StatisticsComponents

[<Pojo>]
type AccessTokenData = 
    { accessToken : string
      accessTokenSecret : string }

type Action =
    | Login of string * string * string
    | SaveReadBooks of ReadBook[]

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
            if state.Logged then 
                let readBooksWrapper = {ReadBooksWrapper.ReadBooks =  state.ReadBooks}
                [
                    R.com<BasicStatsSection, _, _> readBooksWrapper []
                    R.com<TopTenSection, _, _> readBooksWrapper []
                ]
            else []
        R.div [] [
            R.com<Navigation, _, _> {Logged = state.Logged; LoggedUserName = state.LoggedUserName; OnLogout = logout} []
            R.com<Header, _, _> { OnLogin = login; Logged = state.Logged } []
            R.div [] statsComponents
            R.com<Footer, _, _> [] []
        ]