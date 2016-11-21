namespace GoodreadsStats.Model

type ReadBook = 
    { Title : string
      Author : string }
      
type BookData = 
    { Book : ReadBook
      PagesCount : int
      DaysCount : int }

type BasicStats = 
    { BooksCount : int
      PagesCount : int
      SlowestBook : BookData
      FastestBook : BookData
      AverageSpeed : double
      AveragePagesCount : double }
