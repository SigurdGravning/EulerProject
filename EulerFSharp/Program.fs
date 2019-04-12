// Learn more about F# at http://fsharp.org

open System.Threading
open EvenFibonacci

[<EntryPoint>]
let main argv =
    let x = evenFib 1 0 0
    let print x = printfn "The result is: %d" x
    print x
    Thread.Sleep 5000
    0