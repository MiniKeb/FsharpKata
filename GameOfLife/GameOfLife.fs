module GameOfLife

type Size = Size of (int * int)
type Position = Position of (int * int)

let run (size:Size) (aliveCells:Position list) = 
    aliveCells


    