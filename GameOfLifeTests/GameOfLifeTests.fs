module GameOfLifeTests

open Xunit
open GameOfLife

(*
   1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
   2. Any live cell with more than three live neighbours dies, as if by overcrowding.
   3. Any live cell with two or three live neighbours lives on to the next generation.
   4. Any dead cell with exactly three live neighbours becomes a live cell.
*)

[<Fact>]
let ``une cellule vivante avec moins de deux voisins meurt``() = 
    let size = (3,3)
    let aliveCells = [(1,1)]
    Assert.Empty(GameOfLife.run size aliveCells)

[<Fact>]
let ``une cellule vivante avec plus de trois voisins meurt``() = 
    let size = (3,3) |> Size
    let aliveCells = [(0,0);(0,1);(0,2);(1,1)]
    let expected = [(0,0);(0,2)]
    Assert.Equal(expected, GameOfLife.run size aliveCells)
     
