module TlProcessor

open System
open System.Collections.Generic;
open Models
open System.Text.RegularExpressions
let private isCommented (line: string) =
    match line.StartsWith("//") with
    | true -> Some()
    | false -> None

let private isTypeRegion (line: string) =
    match line with
    | "---types---" -> Some(true)
    | "---functions---" -> Some(false)
    | _ -> None

let private parseLine (line: string) =
    let matches = Regex.Match(line, @"^([\w\d\.\\_0-9]*)#([\w\d]*)\ ?(\{.*\})?\ ?#? ?\[? ?t?(?= ) ?\]? ?(.*)? = (.*);$")
    let groups = matches.Groups
    groups.Item(1).Value, groups.Item(2).Value, groups.Item(3).Value, groups.Item(4).Value, groups.Item(5).Value

let private parseParams (line:string) =
    match String.IsNullOrWhiteSpace line with 
    | true -> Seq.empty
    | false -> 
        line.Split(' ')
        |> Seq.map(fun p -> 
            let prms = p.Split(':')
            match prms.Length with
            | 1 -> { Name = line; Type = line;}
            | _ -> { Name = prms.GetValue(0) :?> string; Type = prms.GetValue(1) :?> string}
            )

let private createMethod parseResult = 
    let (sName:string), (sConstr:string), (sGenericType:string), (sPrms:string), (sResult:string) = parseResult
    let prms = parseParams sPrms
            |> Seq.toList
    
    if String.IsNullOrEmpty sConstr then
        failwith "sConstr must be fill"

    {Id = "0x" + sConstr; Method = sName; GenericType = sGenericType; Params = prms; Type = sResult }

let private createType parseResult = 
    let (sName:string), (sConstr:string), (sGenericType:string), (sPrms:string), (sResult:string) = parseResult
    let prms =  parseParams sPrms
                |> Seq.toList

    if String.IsNullOrEmpty sConstr then
        failwith "sConstr must be fill"
    
    {Id = "0x" + sConstr; Predicate = sName; GenericType = sGenericType; Params = prms; Type = sResult }

let parseTlSchema (lines: string seq) =
    let schema = {Types = new List<TlType>(); Requests = new List<TlRequest>()}

    let mutable isType = true

    let mutable i = 1
    for line in lines do
        i <- i + 1
        
        match String.IsNullOrWhiteSpace line with
        | true -> ()
        | false -> 
            match isCommented line with
            | Some(_) -> ()
            | None -> 
                match isTypeRegion line with
                | Some(v) -> isType <- v
                | None -> 
                    match isType with
                    | true -> 
                        parseLine(line) 
                        |> createType
                        |> schema.Types.Add
                    | false -> 
                        parseLine(line) 
                        |> createMethod
                        |> schema.Requests.Add
    schema