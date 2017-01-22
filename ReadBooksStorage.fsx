#r "node_modules/fable-core/Fable.Core.dll"
#load "Model.fsx"

open Fable.Import
open Model

let key = "readBooks"
let load() : ReadBook[] option =
    Browser.localStorage.getItem(key) |> unbox |> Fable.Core.JsInterop.ofJson
    
let save (data: ReadBook[]) =
    Browser.localStorage.setItem(key, Fable.Core.JsInterop.toJson data)
