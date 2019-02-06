$sydneyTimeZone = [TimeZoneInfo]::FindSystemTimeZoneById("AUS Eastern Standard Time")
$date1 = New-Object System.DateTimeOffset -ArgumentList 2019, 4, 7, 2, 59, 59, 0, $sydneyTimeZone.BaseUtcOffset
$date2 = $date1.ToUniversalTime();

$date1 = $date1.AddSeconds(1)
$date2 = $date2.AddSeconds(1)

Write-Output "Date1`t`t$($date1.ToString("O"))"
Write-Output "Date2`t`t$($date2.ToString("O"))"
Write-Output "Date1 as UTC`t$($date1.ToUniversalTime().ToString("O"))"
