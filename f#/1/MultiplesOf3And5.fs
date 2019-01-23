open System

let multiplesOf3And5() =

    List.filter (fun x -> (x % 3 = 0) || (x % 5 = 0)) [1..999]
    |> List.sum
    |> printfn "%A"     

multiplesOf3And5()

Console.ReadKey() |> ignore