module CommonDateFunctions

open System

let convert (timeZone:TimeZoneInfo) (date:DateTimeOffset)  =
    let offset = timeZone.GetUtcOffset date
    date.ToOffset offset

let print (timeZone:TimeZoneInfo) date = 
    let dateTarget = (convert timeZone date).ToString "o"
    let dateUtc = (convert TimeZoneInfo.Utc date).ToString "o"

    printfn "%-28s%s" timeZone.StandardName dateTarget
    printfn "%-28s%s" "UTC" dateUtc
