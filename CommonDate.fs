module CommonDateFunctions

open System

let addSeconds seconds (date:DateTimeOffset) = 
    date.AddSeconds seconds

let addDays days (date:DateTimeOffset) =
    date.AddDays days

let convert (timeZone:TimeZoneInfo) (date:DateTimeOffset)  =
    let offset = timeZone.GetUtcOffset date //Offset for this timezone at this particular point in time (aware date)
    date.ToOffset offset

let convertWrong (timeZone:TimeZoneInfo) (date:DateTimeOffset)  =
    let offset = timeZone.BaseUtcOffset //Current offset at current point in time.
    date.ToOffset offset

let print (date:DateTimeOffset) = 
    let dateAsString = date.ToString "o"
    let dateUtc = (convert TimeZoneInfo.Utc date).ToString "o"

    printfn ""
    printfn "Original Date  |  %s" dateAsString
    printfn "UTC            |  %s" dateUtc
