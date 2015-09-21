namespace FSharpWrapper.Library.Tests

open NUnit.Framework
open FsUnit
open FSharpWrapper.Library

type LightBulb(state) =
   member x.On = state
   override x.ToString() =
       match x.On with
       | true  -> "On"
       | false -> "Off"

[<TestFixture>] 
type ``Given a LightBulb that has had its state set to true`` ()=
   let wrapper = new Wrapper()

   [<Test>] member test.
    ``not wrap on the empty string`` ()=
           wrapper.Wrap("", 3) |> should equal ""

