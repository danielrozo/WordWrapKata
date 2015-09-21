namespace FSharpWrapper.Library.Tests

open NUnit.Framework
open FsUnit
open FSharpWrapper.Library

[<TestFixture>] 
type ``Word Wrapper Should`` ()=
   let wrapper = new Wrapper()

   [<Test>] member test.
    ``not wrap on the empty string`` ()=
           wrapper.Wrap("", 3) |> should equal ""

