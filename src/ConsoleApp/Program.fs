// Learn more about F# at http://fsharp.org

open System
open ConsoleLib

[<EntryPoint>]
let main argv =
    //printfn "Hello World from F#!"
    Say.hello argv.[0]
    0 // return an integer exit code
