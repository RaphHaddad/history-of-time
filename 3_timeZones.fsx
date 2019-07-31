#load "CommonDate.fsx"

open System
open CommonDate.Functions

let samoanDate =
    let samoaTimezone = TimeZoneInfo.FindSystemTimeZoneById("Samoa Standard Time")
    let offset = samoaTimezone.BaseUtcOffset
    DateTimeOffset(2011, 12, 29, 0, 0, 0, 0, offset)

let asUtc = convert TimeZoneInfo.Utc samoanDate
(*
print samoanDate
print (samoanDate.AddDays(1.0));;
*)
