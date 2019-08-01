// difference between naive date (representation) and aware date (point in time)
open System

let createDiaryEntry text (date:DateTime) = 
    printfn """-----
Date: %s
-----
%s""" (date.ToString "o") text

let createTransaction amount (date:DateTime) = 
    printfn "Bob sent Alice $%d on %s" amount (date.ToString "o") 

let naiveDate = DateTime(2019, 7, 10)
createDiaryEntry "DDD Melbourne was great!" naiveDate

let awareDate = DateTime(2019, 7, 10, 14, 35, 0, DateTimeKind.Utc)
createTransaction 5 awareDate
