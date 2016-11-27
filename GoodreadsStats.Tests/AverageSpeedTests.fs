module AverageSpeedTests

open BasicStatsCalculator
open GoodreadsStats.Model
open System
open NUnit.Framework
open Common

let averageSpeed (books : seq<ReadBook>) = 
    let stats = basicStats books
    stats.AverageSpeed

[<Test>]
let ``For no valid book is average speed 0``() = 
    let averageSpeed = averageSpeed []
    Assert.That (averageSpeed, Is.EqualTo(0))
   
[<Test>]
let ``One book, one day, average speed = book number of pages``() = 
    let start = new DateTime (2016,11,27)
    
    let averageSpeed = 
        averageSpeed [ { defaultBook with StartedAt = Some start
                                          ReadAt = Some start
                                          NumPages = Some 333 } ]

    Assert.That (averageSpeed, Is.EqualTo(333.0))
   
[<Test>]
let ``One book, more days, average speed = book number of pages / number of days``() = 
    let start = new DateTime (2016,11,27)
    
    let averageSpeed = 
        averageSpeed [ { defaultBook with StartedAt = Some start
                                          ReadAt = Some (start.AddDays(2.0))
                                          NumPages = Some 333 } ]

    Assert.That (averageSpeed, Is.EqualTo(111.0))
   
[<Test>]
let ``Two books consecutively, average speed = number of pages sum / number of days sum``() = 
    let book1 = { defaultBook with StartedAt = Some (new DateTime (2016,11,27))
                                   ReadAt = Some (new DateTime (2016,11,28))
                                   NumPages = Some 500 } 
    let book2 = { defaultBook with StartedAt = Some (new DateTime (2016,11,29))
                                   ReadAt = Some (new DateTime (2016,11,30))
                                   NumPages = Some 300 } 

    let averageSpeed = averageSpeed [ book1; book2]

    Assert.That (averageSpeed, Is.EqualTo(200.0))
   
[<Test>]
let ``Two books with one day, average speed = number of pages sum / number of days sum``() = 
    let book1 = { defaultBook with StartedAt = Some (new DateTime (2016,11,27))
                                   ReadAt = Some (new DateTime (2016,11,28))
                                   NumPages = Some 500 } 
    let book2 = { defaultBook with StartedAt = Some (new DateTime (2016,12,1))
                                   ReadAt = Some (new DateTime (2016,12,2))
                                   NumPages = Some 300 } 

    let averageSpeed = averageSpeed [ book1; book2]

    Assert.That (averageSpeed, Is.EqualTo(200.0))
    
[<Test>]
let ``Two books in one day, average speed = number of pages sum``() = 
    let book1 = { defaultBook with StartedAt = Some (new DateTime (2016,11,27))
                                   ReadAt = Some (new DateTime (2016,11,27))
                                   NumPages = Some 500 } 
    let book2 = { defaultBook with StartedAt = Some (new DateTime (2016,11,27))
                                   ReadAt = Some (new DateTime (2016,11,27))
                                   NumPages = Some 300 } 

    let averageSpeed = averageSpeed [ book1; book2]

    Assert.That (averageSpeed, Is.EqualTo(800.0))