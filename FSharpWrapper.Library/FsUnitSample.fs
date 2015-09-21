namespace FSharpWrapper.Library.Tests

open NUnit.Framework
open FsUnit
open FSharpWrapper.Library

[<TestFixture>] 
type ``Word Wrapper Should`` ()=
   let wrapper = new Wrapper()

   [<Test>] member test.
    ``not wrap on columnwith > string length`` ()=
           wrapper.Wrap("a", 3) |> should equal "a"


   [<Test>] member test.
    ``wrap when the column size is 1`` ()=
           wrapper.Wrap("abc", 1) |> should equal "a\nb\nc"

    [<Test>] member test.
    ``wrap when the column size is 2 with 5 characters`` ()=
           wrapper.Wrap("abcde", 2) |> should equal "ab\ncd\ne"

    [<Test>] member test.
    ``wrap when columnWidth is different than 2`` ()=
           wrapper.Wrap("babc", 3) |> should equal "bab\nc"

    [<Test>] member test.
    ``wrap when there are spaces`` ()=
           wrapper.Wrap("b b b b", 4) |> should equal "b b \nb b"

