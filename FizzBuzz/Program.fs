// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module FizzBuzzApp

open SimpleFizzBuzz
open System

[<EntryPoint>]
let main argv = 
    let result = [1..100] |> List.map fizzbuzz |> List.reduce (sprintf "%s\r\n%s")
    Console.Write result
    Console.ReadLine ()
    0