#load "CommonDate.fs"

open System
open CommonDateFunctions

let print2 date = 
    printf "%s" "hi"

let add seconds (date:DateTimeOffset) = 
    date.AddSeconds(seconds)

let dateUtc  = DateTimeOffset(2019, 4, 6, 15, 59, 59, TimeZoneInfo.Utc.BaseUtcOffset)
let dateLocal = convert TimeZoneInfo.Local dateUtc

(*
print TimeZoneInfo.Local dateUtc;;
add 1.0 dateUtc
|> print TimeZoneInfo.Local;;

print TimeZoneInfo.Local dateLocal;;
add 1.0 dateLocal
|> print TimeZoneInfo.Local;;

print TimeZoneInfo.Local dateLocal;;
dateUtc
|> add 1.0
|> convert TimeZoneInfo.Local
|> print TimeZoneInfo.Local
*)