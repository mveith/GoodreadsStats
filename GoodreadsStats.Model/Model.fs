namespace GoodreadsStats.Model

type Book = 
    { Title : string
      Author : string }
      
type BookData = 
    { Book : Book
      PagesCount : int
      DaysCount : int }

type BasicStats = 
    { BooksCount : int
      PagesCount : int
      SlowestBook : BookData option
      FastestBook : BookData option
      AverageSpeed : double
      AveragePagesCount : double }
