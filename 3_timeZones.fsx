#load "CommonDate.fs"

open System
open CommonDateFunctions

let samoaTimezone = TimeZoneInfo.FindSystemTimeZoneById("Samoa Standard Time")

let samoanDate =
    let date = DateTime(2011, 12, 31, 23, 59, 59)
    let offset = samoaTimezone.GetUtcOffset date
    DateTimeOffset(date, offset)

print samoanDate;;
addSeconds 1.0 samoanDate
|> print;;

convert TimeZoneInfo.Utc samoanDate
|> addSeconds 1.0
|> convert samoaTimezone
|> print;;

