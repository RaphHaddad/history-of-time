// a scenario where UTC doesn't make much sense to store or calculate from
open System;

let melbOffset = TimeZoneInfo.Local.BaseUtcOffset;

let totalToRefund (date:DateTimeOffset) monthlyCost = 
    let firstDate =  DateTimeOffset(date.Year, date.Month, 1, 0, 0, 0, melbOffset)
    let lastDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month)
    let lastDate = DateTimeOffset(date.Year, date.Month, lastDayOfMonth, 0, 0, 0, melbOffset)
    
    let daysInMonth = (lastDate - firstDate).Days + 1
    let daysBilled = date.Day

    let costPerDay = monthlyCost / (daysInMonth |> float)
    costPerDay * (daysBilled |> float)

printfn "$%.2f" (totalToRefund (DateTimeOffset(2019, 2, 15, 0, 0, 0, melbOffset)) 50.0)