module ReadBooksStorage

open Fable.Import
open Model

let key = "readBooks"
let load() : ReadBook[] option =
    Browser.localStorage.getItem(key) |> unbox |> Fable.Core.JsInterop.ofJson
    
let save (data: ReadBook[]) =
    Browser.localStorage.setItem(key, Fable.Core.JsInterop.toJson data)
    
let clearReadBooks() =
    Browser.localStorage.removeItem key

let detailsKey = "details"
let loadDetails() : BookDetail[] option =
    Browser.localStorage.getItem(detailsKey) |> unbox |> Fable.Core.JsInterop.ofJson
    
let saveDetails (data: BookDetail[]) =
    Browser.localStorage.setItem(detailsKey, Fable.Core.JsInterop.toJson data)

let clearDetails() =
    Browser.localStorage.removeItem detailsKey
