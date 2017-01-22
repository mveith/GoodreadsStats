namespace GoodreadsStats.Model

open System

type Book = 
    { Title : string
      Author : string }

type BookStatsData = 
    { Book : Book
      PagesCount : int
      DaysCount : int 
      Speed : float}

type BasicStats = 
    { BooksCount : int
      PagesCount : int
      SlowestBook : BookStatsData option
      FastestBook : BookStatsData option
      AverageSpeed : double
      AveragePagesCount : double }
      
type AuthorizationUserData = 
    { Token : string
      TokenSecret : string
      Url : string }

type LoggedUserData = 
    { AccessToken : string
      AccessTokenSecret : string
      UserName : string}

type ReadData=
    { ReadAt : DateTime
      StartedAt : DateTime}

type ReadBook = 
    { ReadData : ReadData option
      NumPages : int
      BookTitle : string
      AuthorName : string}
