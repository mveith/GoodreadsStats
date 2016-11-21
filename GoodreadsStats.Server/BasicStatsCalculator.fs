module BasicStatsCalculator

open GoodreadsApi
open GoodreadsStats.Model

let reviews accessData = 
    let userId = getUserId accessData
    getAllReviews accessData userId "read" "date_read"

let isValidReview (r:Reviews.Review)=
    r.StartedAt.IsSome && r.ReadAt.IsSome && r.Book.NumPages.IsSome && r.Book.NumPages.Value > 0
    
let bookSpeed (book : Reviews.Review) = 
    let pagesCount = book.Book.NumPages.Value
    let startDate = (parseDate book.StartedAt.Value).Date
    let endDate = (parseDate book.ReadAt.Value).Date
    let daysCount = (endDate - startDate).TotalDays + 1.0
    (float pagesCount) / daysCount
    
let createBookData (book : Reviews.Review, bookSpeed : float) = 
    { Book = 
            { Title = book.Book.Title
              Author = book.Book.Author.Name }
      PagesCount = book.Book.NumPages.Value
      DaysCount = int ((float book.Book.NumPages.Value) * bookSpeed) }
    
let basicStats accessData =     
    let reviews = reviews accessData

    let validReviews = 
        reviews
        |> Seq.filter isValidReview
        |> Seq.toArray
    
    let booksSpeed = 
        validReviews
        |> Seq.map (fun r -> (r, bookSpeed r))
        |> Seq.sortByDescending (fun (_, speed) -> speed)
    
    let fastestBook = booksSpeed |> Seq.head
    let slowestBook = booksSpeed |> Seq.last
    
    { BooksCount = validReviews.Length
      PagesCount = validReviews |> Seq.sumBy (fun p -> p.Book.NumPages.Value)
      SlowestBook = createBookData slowestBook
      FastestBook = createBookData fastestBook
      AverageSpeed = 100.0
      AveragePagesCount = validReviews |> Seq.averageBy (fun p -> double p.Book.NumPages.Value) }