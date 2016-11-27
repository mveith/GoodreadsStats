module Common

open BasicStatsCalculator
open GoodreadsStats.Model
open System

let defaultBook = 
    { ReadAt = Some(new DateTime(2016, 11, 27))
      StartedAt = Some(new DateTime(2016, 11, 27))
      NumPages = Some 1
      Book = 
          { Title = "Test Title"
            Author = "Test Author" } }
