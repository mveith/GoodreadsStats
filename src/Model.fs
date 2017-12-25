module Model

open System

type ReadData=
    { ReadAt : DateTime
      StartedAt : DateTime}

type ReadBook = 
    { ReadData : ReadData option
      NumPages : int
      BookTitle : string
      AuthorName : string
      ReviewId : int
      Shelves : string[]
      SmallImageUrl : string
      BookId : int }

type BookDetail =
    { Id : int
      Genres : string[]
      OriginalPublicationYear : int option 
      Language : string option }

type BookStatsData = 
    { Book : ReadBook
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

type AccessTokenData = 
    { accessToken : string
      accessTokenSecret : string }

type State =
    { Logged : bool
      ReadBooks : ReadBook[] 
      AccessData : AccessTokenData option
      LoggedUserName:string 
      BooksDetails : BookDetail[] }