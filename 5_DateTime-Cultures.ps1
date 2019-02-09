$aDate = New-Object -TypeName DateTime -ArgumentList 2019, 2, 11

$usaCulture = New-Object -TypeName CultureInfo -ArgumentList "en-us"
Write-Output $aDate.ToString($usaCulture)

$auCulture = New-Object -TypeName CultureInfo -ArgumentList "en-au"
Write-Output $aDate.ToString($auCulture)
