open System

List.filter (fun x -> (x % 3 = 0) || (x % 5 = 0)) [1..999]
|> List.sum
|> printfn "%A"     

Console.ReadKey() |> ignore