﻿module SimpleFizzBuzz

let fizzbuzz number = 
    match number with
        | n when n % 15 = 0 -> "FizzBuzz"
        | n when n % 3 = 0 -> "Fizz"
        | n when n % 5 = 0 -> "Buzz"
        | _ -> number.ToString()
