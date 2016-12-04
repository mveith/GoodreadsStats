#r "node_modules/fable-core/Fable.Core.dll"
#load "Fable.Import.Global.fsx"
#load "node_modules/fable-import-react/Fable.Import.React.fs"
#load "node_modules/fable-import-react/Fable.Helpers.React.fs"
#load "Utils.fsx"
#load "Components.fsx"

open Fable.Import
open Fable.Import.Global
open Components
open Utils

module R = Fable.Helpers.React
let parseTokenAndSecret (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1])

let parseTokenAndSecretAndUrl (result : string) = 
    let parts = result.Split([| "|" |], System.StringSplitOptions.RemoveEmptyEntries)
    (parts.[0], parts.[1], parts.[2])

let saveAndReturnAuthorizationUrl result = 
    let (token, secret, url) = parseTokenAndSecretAndUrl result
    setCookie "authorizationToken" token 1
    setCookie "authorizationTokenSecret" secret 1
    url

let login() = 
    ajax (completeUrl "authorizationUrl") (string
                                           >> saveAndReturnAuthorizationUrl
                                           >> navigateTo)

let getAccessToken() = 
    let token = Globals.cookies.get ("accessToken")
    let secret = Globals.cookies.get ("accessTokenSecret")
    match token with
    | Some token -> option.Some(token, secret.Value)
    | None -> option.None

let saveAccessToken (accessToken, accessTokenSecret) = 
    let accessToken = string accessToken
    setCookie "accessToken" accessToken 7
    setCookie "accessTokenSecret" accessTokenSecret 7
    (accessToken, accessTokenSecret)

let tryAuthorize onSuccess = 
    let token = getQueryVariable "oauth_token"
    let secret = Globals.cookies.get ("authorizationTokenSecret")
    match token with
    | Some token -> 
        let url = completeUrlWithToken "authorized" token secret.Value
        ajax url (string
                  >> parseTokenAndSecret
                  >> saveAccessToken
                  >> onSuccess)
    | None -> ()

let showBasicStats (accessToken, accessTokenSecret) = 
    let props = 
        { accessToken = accessToken
          accessTokenSecret = accessTokenSecret }
    
    let rootElement = Browser.document.getElementById "basic-stats-content"
    let reactComponent = R.com<BasicStatsSection, _, _> props []
    ReactDom.render (reactComponent, rootElement) |> ignore

let onPageLoad() = 
    let accessToken = getAccessToken()
    match accessToken with
    | Some(accessToken, accessTokenSecret) -> showBasicStats (accessToken, accessTokenSecret)
    | None -> tryAuthorize showBasicStats

let footerElement = Browser.document.getElementById "footer-content"
let footerComponent = R.com<Footer, _, _> [] []
ReactDom.render (footerComponent, footerElement) |> ignore

let headerElement = Browser.document.getElementById "header-content"
let headerComponent = R.com<Header, _, _> [] []
ReactDom.render (headerComponent, headerElement) |> ignore

let navigationElement = Browser.document.getElementById "navigation-content"
let navigationComponent = R.com<Navigation, _, _> [] []
ReactDom.render (navigationComponent,navigationElement) |> ignore

Globals.jQuery.Invoke("#login-button").click(fun _ -> login())
onPageLoad()
initAgency()