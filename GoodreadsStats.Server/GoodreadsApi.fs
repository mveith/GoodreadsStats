module GoodreadsApi

open FSharp.Data
open OAuth

type User = XmlProvider< "userSample.xml" >

type Reviews = XmlProvider< "reviewsSample.xml" >

let requestTokenUrl = "http://www.goodreads.com/oauth/request_token"
let accessTokenUrl = "http://www.goodreads.com/oauth/access_token"
let authorizeUrl = sprintf "https://www.goodreads.com/oauth/authorize?oauth_token=%s&oauth_callback=%s"

let getAuthorizationData clientKey clientSecret callbackUrl =
    let (token, tokenSecret) = getAuthorizatonToken clientKey clientSecret requestTokenUrl
    (authorizeUrl token callbackUrl, token, tokenSecret) 

let getAccessToken clientKey clientSecret token tokenSecret =
    getAccessToken clientKey clientSecret accessTokenUrl token tokenSecret

let getAccessData clientKey clientSecret token tokenSecret =
    getAccessData clientKey clientSecret token tokenSecret
        
let getUserId accessData = 
    let userResponse = getUrlContentWithAccessData "https://www.goodreads.com/api/auth_user" accessData
    let user = User.Parse userResponse
    user.User.Id

let getReviewsOnPage accessData userId shelf sort perPage pageNumber = 
    let url = 
        sprintf "https://www.goodreads.com/review/list/%i.xml?key=%s&v=2&shelf=%s&sort=%s&per_page=%i&page=%i" userId accessData.ClientKey 
            shelf sort perPage pageNumber
    let reviewsResponse = getUrlContentWithAccessData url accessData
    let reviews = Reviews.Parse reviewsResponse

    reviews.Reviews

let getAllReviews accessData userId shelf sort = 
    let perPage = 200
    let getReviewsOnPage = getReviewsOnPage accessData userId shelf sort perPage
    let firstPageReviews = getReviewsOnPage 1
    
    let pagesCount = 
        float firstPageReviews.Total / float perPage
        |> ceil
        |> int
    
    let first = seq firstPageReviews.Reviews
    
    let others = 
        [ 2..pagesCount ]
        |> Seq.map getReviewsOnPage
        |> Seq.collect (fun pageReviews -> pageReviews.Reviews)
    Seq.concat [| first; others |]

let goodreadsDataFormat = "ddd MMM dd HH:mm:ss zzz yyyy"

let parseDate s = 
    System.DateTime.ParseExact(s, goodreadsDataFormat, System.Globalization.CultureInfo.InvariantCulture)
    
let parseOptionDate (s:string option) = 
    match s with
    | Some value -> Some (parseDate value)
    | None -> None
    