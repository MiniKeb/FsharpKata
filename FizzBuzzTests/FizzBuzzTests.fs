namespace FizzBuzzTests

open NUnit.Framework
open ChainOfResponsibilityFizzBuzz

[<TestFixture>]
type FizzBuzzTest() = 
    [<Test>]
    member this.OneShouldBeOne() = this.TestFizzBuzz 1 "1"
    [<Test>]
    member this.TwoShouldBeTwo() = this.TestFizzBuzz 2 "2"
    [<Test>]
    member this.ThreeShouldBeFizz() = this.TestFizzBuzz 3 "Fizz"
    [<Test>]
    member this.FiveShouldBeBuzz() = this.TestFizzBuzz 5 "Buzz"
    [<Test>]
    member this.FifteenShouldBeFizzBuzz() = this.TestFizzBuzz 15 "FizzBuzz"
    
    member this.TestFizzBuzz input expected = 
        let result = fizzbuzz input
        Assert.That(result, Is.EqualTo(expected))