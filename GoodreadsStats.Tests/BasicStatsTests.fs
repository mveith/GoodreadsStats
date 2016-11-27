module Tests

open BasicStatsCalculator
open GoodreadsStats.Model
open System
open NUnit.Framework
open Common

[<Test>]
let ``For no valid book return empty stats``() = 
    let stats = basicStats []
    Assert.That (stats.BooksCount, Is.EqualTo(0))
    Assert.That (stats.PagesCount, Is.EqualTo(0))
   
[<Test>]
let ``Books count is count of valid books``() = 
    let books = [ defaultBook;defaultBook;defaultBook;]
    let stats = basicStats books
    Assert.That (stats.BooksCount, Is.EqualTo(3))
    
[<Test>]
let ``Book without start is not valid``() = 
    let book = { defaultBook with StartedAt = None}
    let stats = basicStats [book]
    Assert.That (stats.BooksCount, Is.EqualTo(0))

[<Test>]
let ``Book without end is not valid``() = 
    let book = { defaultBook with ReadAt = None}
    let stats = basicStats [book]
    Assert.That (stats.BooksCount, Is.EqualTo(0))
    
[<Test>]
let ``Book without pages count is not valid``() = 
    let book = { defaultBook with NumPages = None}
    let stats = basicStats [book]
    Assert.That (stats.BooksCount, Is.EqualTo(0))

[<Test>]
let ``Pages count is sum of valid books pages count``() = 
    let stats = basicStats [
                    { defaultBook with NumPages = Some 200 }
                    { defaultBook with NumPages = Some 100 }
                    { defaultBook with NumPages = Some 100; ReadAt = None}]
    Assert.That (stats.PagesCount, Is.EqualTo(300))
    
[<Test>]
let ``Average pages count is average of valid books pages count``() = 
    let stats = basicStats [
                    { defaultBook with NumPages = Some 200 }
                    { defaultBook with NumPages = Some 100 }
                    { defaultBook with NumPages = Some 100; ReadAt = None}]
    Assert.That (stats.AveragePagesCount, Is.EqualTo(150))

[<Test>]
let ``Fastest book is book with greatest pages by day ratio``() = 
    let startDate = new DateTime (2016,11,27)
    let book1 = { defaultBook with NumPages = Some 200; StartedAt = Some (startDate); ReadAt = Some (startDate.AddDays(2.0)) }
    let book2 = { defaultBook with NumPages = Some 150; StartedAt = Some (startDate); ReadAt = Some (startDate.AddDays(1.0)) }
    let stats = basicStats [ book1; book2 ]
    Assert.That (stats.FastestBook.IsSome)
    Assert.That (stats.FastestBook.Value.DaysCount, Is.EqualTo(2))
    Assert.That (stats.FastestBook.Value.PagesCount, Is.EqualTo(150))

[<Test>]
let ``Slowest book is book with smallest pages by day ratio``() = 
    let startDate = new DateTime (2016,11,27)
    let book1 = { defaultBook with NumPages = Some 200; StartedAt = Some (startDate); ReadAt = Some (startDate.AddDays(2.0)) }
    let book2 = { defaultBook with NumPages = Some 150; StartedAt = Some (startDate); ReadAt = Some (startDate.AddDays(1.0)) }
    let stats = basicStats [ book1; book2 ]
    Assert.That (stats.SlowestBook.IsSome)
    Assert.That (stats.SlowestBook.Value.DaysCount, Is.EqualTo(3))
    Assert.That (stats.SlowestBook.Value.PagesCount, Is.EqualTo(200))