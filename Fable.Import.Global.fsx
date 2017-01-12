#r "node_modules/fable-core/Fable.Core.dll"
#load "Fable.Import.JQuery.fsx"

open Fable.Import.JQuery
open Fable.Core

[<AllowNullLiteral>]
type CookieSettings = 
    abstract expires : int option

type CookiesStatic = 
    abstract get : key:string -> string option
    abstract set : key:string * value:string * settings:CookieSettings -> unit
    abstract remove : key:string * settings:CookieSettings -> unit

[<Global>]
let decodeURIComponent : string -> string = failwith "JS only"

[<Global; Emit("initAgency()")>]
let initAgency () = failwith "JS only" 

type Globals = 
    
    [<Global; Emit("jQuery")>]
    static member jQuery 
        with get () = failwith "JS only" : JQueryStatic
        and set (v : JQueryStatic) = failwith "JS only" : unit
    
    [<Global; Emit("Cookies")>]
    static member cookies 
        with get () = failwith "JS only" : CookiesStatic
        and set (v : CookiesStatic) = failwith "JS only" : unit

let getAjaxSettings url ``method`` = 
    { new JQueryAjaxSettings with
          member x.``method`` = option.Some ``method``
          member x.url = option.Some url }

let ajax url callback = 
    let settings = getAjaxSettings url "GET"
    let xhr = Globals.jQuery.ajax (settings)
    xhr.``done`` callback |> ignore

let setCookie key value expires = 
    let settings = 
        { new CookieSettings with
              member x.expires = option.Some expires }
    Globals.cookies.set (key, value, settings)

let removeCookie key = 
    let settings = 
        { new CookieSettings with member x.expires = option.None }
    Globals.cookies.remove (key, settings)
