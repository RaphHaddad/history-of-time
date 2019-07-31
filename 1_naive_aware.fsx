open System

let createDiaryEntry text (date:DateTime)= 
    printfn """-----
Date: %s
-----
%s""" (date.ToString("o")) text

let naiveDate = DateTime(2019, 7, 10)
createDiaryEntry "DDD Melbourne was great!" naiveDate

let awareDate = DateTime(2019, 7, 10, 14, 35, 0, DateTimeKind.Local)
createDiaryEntry "DDD Melbourne was great!" awareDate
