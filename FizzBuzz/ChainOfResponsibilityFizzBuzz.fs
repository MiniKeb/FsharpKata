module ChainOfResponsibilityFizzBuzz

let fibu = (fun x -> x % 15 = 0), fun x -> "FizzBuzz"
let fizz = (fun x -> x % 3 = 0), fun x -> "Fizz"
//let blaz = (fun x -> x % 4 = 0), fun x -> "Blaz"
let buzz = (fun x -> x % 5 = 0), fun x -> "Buzz"
let defo = (fun x -> true), fun x -> x.ToString()

let chain (check, apply) (value:int, doNext, res:string) = 
    if check value && doNext then 
        let result = apply value
        (value, false, result)
    else (value, doNext, res)

    
let fizbuz = chain fibu >> chain fizz >> (*chain blaz >> *) chain buzz >> chain defo

let fizzbuzz value = 
    let (_,_,result) = fizbuz (value, true, "")
    result
