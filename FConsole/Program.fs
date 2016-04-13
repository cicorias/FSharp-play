// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

module Program


open FParsec
open Tools



[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let p = 
        (stringReturn "2" "two")
        <|> (stringReturn "4" "four")

    test p "2foo"
    //test (many (str "a" <|> str "b")) "abba"
    let fs = System.IO.File.Open("../../Program.fs", System.IO.FileMode.Open)
    let sr = new System.IO.StreamReader(fs)
    while ReadFromFile(sr) = true do ()
    sr.Close()
    0