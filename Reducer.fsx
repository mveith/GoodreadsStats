#load "Model.fsx"
#load "Actions.fsx"
#load "ReadBooksStorage.fsx"

open Model
open Actions
open ReadBooksStorage

let flat col = 
    col 
    |> Seq.groupBy (fun b -> b.ReviewId)
    |> Seq.map (fun (_, group) -> group |> Seq.last)

let merge = Array.concat >> flat >> Seq.toArray

let saveReadBooks actualState books =
    let readBooks = merge [ actualState.ReadBooks ; books]
    ReadBooksStorage.save readBooks 
    { actualState with ReadBooks = readBooks}

let reducer (state: State) = function
    | Login (token, secret, userName)-> { state with Logged = true; AccessData = Some { accessToken = token; accessTokenSecret = secret  }; LoggedUserName = userName}
    | SaveReadBooks books -> saveReadBooks state books
