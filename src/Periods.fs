module Periods

let ordinal i =
    if i = 0 then ""
    else 
        match i % 100 with
        | 11 | 12 | 13 -> "th"
        | _ ->
            match i % 10 with
            | 1 -> "st"
            | 2 -> "nd"
            | 3 -> "rd"
            | _ -> "th"

let createCentury i = 
    if i < 0 then 
        let index = abs i
        let min = i * 100
        (sprintf "%i%s century BC" index (ordinal index), min, min + 99)
    else 
        let index = i + 1 
        let min = i * 100 + 1
        (sprintf "%i%s century" index (ordinal index), min, min + 99)

let createDecade i = 
    let min = (1900 + (i * 10))
    let label = sprintf "%is" min
    (label, min, min + 10)

let centuries = [-30..30] |> Seq.map createCentury |> Seq.toList
let decades = [0..100] |> Seq.map createDecade |> Seq.toList
let periods =  centuries @ decades
