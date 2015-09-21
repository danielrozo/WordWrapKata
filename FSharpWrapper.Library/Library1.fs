namespace FSharpWrapper.Library
open System

type Wrapper() = 
    member this.Separator(index, colWidth, length) =
         if (index - 1) % colWidth = 0 && index < length - 1 then "\n" else ""

    member this.Wrap(input : string, columnWidth) =
        input.ToCharArray() 
        |> Seq.mapi(fun i ch -> ch.ToString() + this.Separator(i, columnWidth, input.Length))
        |> Seq.reduce (fun acc x -> acc + x)