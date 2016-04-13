module Tools

open FSharp.Charting
open FParsec
open System.IO

let ReadFromFile (reader : StreamReader) =
    match reader.ReadLine() with
    | null -> printfn "\n"; false
    | line -> printfn "%s" line; true


let test p str = 
    match run p str with
    | Success(result, z, y) -> printfn "Success: %A - %A - %A" result z y
    | Failure(errorMsg, z, y) -> printf "Failure %A - %A - %A" errorMsg z y 
