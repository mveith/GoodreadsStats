module Actions

open Model
open Fable.Core

[<Pojo>]
type Action =
    | Login of string * string * string
    | SaveReadBooks of ReadBooks
    | SaveBooksDetails of BookDetails
    | StartDemo
