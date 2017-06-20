module Program

open System
open System.IO

open Models
open TlProcessor
open EntitiesGenerator

[<EntryPoint>]
let main argv = 
    File.ReadLines("scheme.tl")
    |> parseTlSchema 
    |> generateEntities

    0
        