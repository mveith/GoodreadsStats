#load "Model.fsx"
#load "Actions.fsx"
#load "ReadBooksStorage.fsx"

open Model
open Actions
open ReadBooksStorage

let flat key col = 
    col 
    |> Seq.groupBy key
    |> Seq.map (fun (_, group) -> group |> Seq.last)

let merge key = Array.concat >> flat key >> Seq.toArray

let saveReadBooks actualState books =
    let readBooks = merge (fun r -> r.ReviewId) [ actualState.ReadBooks ; books]
    ReadBooksStorage.save readBooks 
    { actualState with ReadBooks = readBooks}

let saveBooksDetails actualState details =
    let mergedDetails = merge (fun d -> d.Id) [ actualState.BooksDetails ; details]
    { actualState with BooksDetails = mergedDetails }

let reducer (state: State) = function
    | Login (token, secret, userName)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }; LoggedUserName = userName}
    | SaveReadBooks books -> saveReadBooks state books
    | SaveBooksDetails details -> saveBooksDetails state details