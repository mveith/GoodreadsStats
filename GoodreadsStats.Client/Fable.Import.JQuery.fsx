#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Import
open Fable.Core
open Fable.Import.Browser

[<AllowNullLiteral>]
type JQueryAjaxSettings = 
    abstract ``method`` : string option
    abstract url : string option

[<AllowNullLiteral>]
type JQueryXHR = 
    abstract ``done`` : callback:(obj -> unit) -> int

[<AllowNullLiteral>]
type JQueryEventObject = 
    inherit Event

[<AllowNullLiteral>]
type JQuery = 
    abstract click : handler:(JQueryEventObject -> unit) -> JQuery
    abstract load : handler:(JQueryEventObject -> unit) -> JQuery

[<AllowNullLiteral; Import("jQuery", "jquery")>]
type JQueryStatic = 
    abstract ajax : settings:JQueryAjaxSettings -> JQueryXHR
    [<Emit("$0($1...)")>]
    abstract Invoke : selector:string * ?context:U2<Element, JQuery> -> JQuery
