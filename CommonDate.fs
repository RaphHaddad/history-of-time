module CommonDateFunctions

open System

let convert (timeZone:TimeZoneInfo) (date:DateTimeOffset)  =
    let offset = timeZone.GetUtcOffset date
    date.ToOffset offset

let print (date:DateTimeOffset) = 
    let dateAsString = date.ToString "o"
    let dateUtc = (convert TimeZoneInfo.Utc date).ToString "o"

    printfn ""
    printfn "Original Date  |  %s" dateAsString
    printfn "UTC            |  %s" dateUtc
