// demonstrates different cultures
open System
open System.Globalization

let print (date:DateTime) (culture:CultureInfo) = 
    printfn "%-25s %s" culture.DisplayName (date.ToString("F", culture))

let aDate = DateTime(2019, 8, 10);

printfn "English speaking countries"
print aDate (CultureInfo "en-gb")
print aDate (CultureInfo "en-au")
print aDate (CultureInfo "en-nz")
print aDate (CultureInfo "en-us")
print aDate (CultureInfo "en-ca")


printfn "Non-English speaking countries"
print aDate (CultureInfo "ja-JP")
print aDate (CultureInfo "ar-IQ")
