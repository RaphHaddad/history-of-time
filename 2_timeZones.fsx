// Where it makes sense to use UTC for calculation
#load "CommonDate.fs"

open System
open CommonDateFunctions

let dateUtc  = DateTimeOffset(2019, 4, 6, 15, 59, 59, TimeZoneInfo.Utc.BaseUtcOffset)
let dateLocal = convert TimeZoneInfo.Local dateUtc

print dateLocal;;
addSeconds 1.0 dateLocal
|> print;;

print dateUtc;;
addSeconds 1.0 dateUtc
|> convert TimeZoneInfo.Local
|> print ;;
