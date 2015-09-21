// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open FSharpWrapper.Library

// Define your library scripting code here

"abcde".ToCharArray()  
|> Seq.map(fun ch -> ch.ToString() + "\n")
|> Seq.reduce (fun acc x -> acc + x)


"".ToCharArray()