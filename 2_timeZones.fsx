#load "CommonDate.fs"

open System
open CommonDateFunctions

let add seconds (date:DateTimeOffset) = 
    date.AddSeconds(seconds)

let dateUtc  = DateTimeOffset(2019, 4, 6, 15, 59, 59, TimeZoneInfo.Utc.BaseUtcOffset)
let dateLocal = convert TimeZoneInfo.Local dateUtc

(*
print dateLocal;;
add 1.0 dateLocal
|> print;;

print dateUtc;;
add 1.0 dateUtc
|> convert TimeZoneInfo.Local
|> print ;;
*)