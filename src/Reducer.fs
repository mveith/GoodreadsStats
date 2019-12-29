module Reducer

open Fable.Import
open Model
open Actions
open ReadBooksStorage

let flat key col = 
    col 
    |> Seq.groupBy key
    |> Seq.map (snd >> Seq.last)

let merge key = Array.concat >> flat key >> Seq.toArray

let saveReadBooks actualState books =
    let readBooks = merge (fun r -> r.ReviewId) [ actualState.ReadBooks ; books]
    ReadBooksStorage.save readBooks 
    { actualState with ReadBooks = readBooks}

let saveBooksDetails actualState details =
    let mergedDetails = merge (fun d -> d.Id) [ actualState.BooksDetails ; details]
    ReadBooksStorage.saveDetails mergedDetails 
    { actualState with BooksDetails = mergedDetails }

let startDemo actualState =
    {
        actualState with 
            Logged = true; 
            LoggedUserName = "Demo user"; 
            ReadBooks = DemoDataBuilder.readBooks(); 
            BooksDetails = DemoDataBuilder.bookDetails(); 
            AccessData = None }

let reducer (state: State) action =
    match action with
    | Login (token, secret, userName)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }; LoggedUserName = userName}
    | SaveReadBooks books -> saveReadBooks state books.Books
    | SaveBooksDetails details -> saveBooksDetails state details.Details
    | StartDemo -> startDemo state