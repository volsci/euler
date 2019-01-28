open System

Seq.unfold (fun state ->
    if (snd state > 4000000) then None
    else Some(fst state + snd state, (snd state, fst state + snd state))) (0,1)
|> Seq.where (fun x -> x % 2 = 0)
|> Seq.sum
|> printfn "%A" 

Console.ReadKey() |> ignore