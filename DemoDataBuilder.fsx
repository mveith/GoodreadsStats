#load "Model.fsx"

open Model

let readBooks()=
    let readBook = 
        {
            ReadData = 
                Some 
                    { 
                        StartedAt = new System.DateTime(2017, 4, 1); 
                        ReadAt = new System.DateTime (2017, 4 ,14) 
                    };
            NumPages = 264
            BookTitle = "Mastering F#"
            AuthorName = "Alfonso Garcia-Caro Nunez"
            ReviewId = 123
            Shelves = [|"programming"|]
            SmallImageUrl = "https://images.gr-assets.com/books/1487429565s/34333594.jpg"
            BookId = 34333594 }
    [|readBook|]

let bookDetails()=
    let bookDetail = 
        {
            Id = 34333594
            Genres = [|"programming"|]
            OriginalPublicationYear = Some 2016
            Language = Some "English"
        }
    [|bookDetail|]