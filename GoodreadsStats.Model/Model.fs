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
      SlowestBook : BookData
      FastestBook : BookData
      AverageSpeed : double
      AveragePagesCount : double }
      
type AuthorizationUserData = 
    { Token : string
      TokenSecret : string
      Url : string }

type LoggedUserData = 
    { AccessToken : string
      AccessTokenSecret : string }
