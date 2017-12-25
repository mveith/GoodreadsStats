module Actions

open Model
open Fable.Core

[<Pojo>]
type Action =
    | Login of string * string * string
    | SaveReadBooks of ReadBook[]
    | SaveBooksDetails of BookDetail[]
    | StartDemo
