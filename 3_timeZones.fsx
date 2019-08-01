#load "CommonDate.fs"

open System
open CommonDateFunctions

let samoaTimezone = TimeZoneInfo.FindSystemTimeZoneById("Samoa Standard Time")

let samoanDate =
    let date = DateTime(2011, 12, 29)
    let offset = samoaTimezone.GetUtcOffset date
    DateTimeOffset(date, offset)

addDays 1.0 samoanDate
|> convert samoaTimezone
|> print;;

convert TimeZoneInfo.Utc samoanDate
|> addDays 3.0
|> convert samoaTimezone
|> print;;
