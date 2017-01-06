module Utils

open System    
open System.Text.RegularExpressions
open System.Globalization

let unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~"

let (|ParseRegex|_|) regex str = 
    let m = Regex(regex).Match(str)
    if m.Success then 
        Some(List.tail [ for x in m.Groups -> x.Value ])
    else None

let timeStamp() = 
    let ts = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))
    let timeStamp = ts.TotalSeconds.ToString(CultureInfo.InvariantCulture)
    let timeStamp = timeStamp.Substring(0, timeStamp.IndexOf("."))
    timeStamp

let encodeChar unencodedChar = 
    if (unreservedChars.Contains(string unencodedChar)) then [ unencodedChar ]
    else '%' :: (String.Format("{0:X2}", int unencodedChar) |> Seq.toList)

let urlEncode unencodedString = 
    let encodedChars = 
        unencodedString
        |> Seq.collect encodeChar
        |> Seq.toArray
    
    let encodedString = new String(encodedChars)
    encodedString

let normalize parameters = 
    let parts = parameters |> Seq.map (fun (key, value) -> key + "=" + value)
    String.Join("&", parts)