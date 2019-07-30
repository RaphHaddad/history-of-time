open System

let convert (timezone:TimeZoneInfo) (date:DateTimeOffset)  =
    let offset = timezone.GetUtcOffset date.DateTime
    date.ToOffset offset

let add seconds (date:DateTimeOffset) = 
    date.AddSeconds(seconds)

let print date = 
    let localDate = (convert TimeZoneInfo.Local date).ToString "o"
    let utcDate   = (convert TimeZoneInfo.Utc date).ToString "o"
 
    printfn """
As Local: %s 
UTC:      %s """ localDate utcDate


let dateUtc  = DateTimeOffset(2019, 4, 6, 15, 59, 59, TimeZoneInfo.Utc.BaseUtcOffset)

let dateLocal = convert TimeZoneInfo.Local dateUtc

print dateUtc;;
// print (add 1.0 dateUtc);;

print dateLocal;;

// dateUtc
// |> add 1.0
// |> convert TimeZoneInfo.Local
// |> print
