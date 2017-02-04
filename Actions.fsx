#load "Model.fsx"

open Model

type Action =
    | Login of string * string * string
    | SaveReadBooks of ReadBook[]
    | SaveBooksDetails of BookDetail[]
