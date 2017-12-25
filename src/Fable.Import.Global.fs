module Fable.Import.Global

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
    [<Global; Emit("Cookies")>]
    static member cookies 
        with get () = failwith "JS only" : CookiesStatic
        and set (v : CookiesStatic) = failwith "JS only" : unit

let setCookie key value expires = 
    let settings = 
        { new CookieSettings with
              member x.expires = option.Some expires }
    Globals.cookies.set (key, value, settings)

let removeCookie key = 
    let settings = 
        { new CookieSettings with member x.expires = option.None }
    Globals.cookies.remove (key, settings)
