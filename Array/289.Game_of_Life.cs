/*
According to Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."

The board is made up of an m x n grid of cells, where each cell has an initial state: live (represented by a 1) or dead (represented by a 0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):

Any live cell with fewer than two live neighbors dies as if caused by under-population.
Any live cell with two or three live neighbors lives on to the next generation.
Any live cell with more than three live neighbors dies, as if by over-population.
Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously. Given the current state of the m x n grid board, return the next state.

Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
Output: [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]

Input: board = [[1,1],[1,0]]
Output: [[1,1],[1,1]]
*/

public class Solution {
    /*
    Runtime: 240 ms, faster than 64.11% of C# online submissions for Game of Life.
    Memory Usage: 30.6 MB, less than 50.72% of C# online submissions for Game of Life.
    */
    //need to get more familier about the two way array relationship between col and row
    /*
    Be carefull for Jagged Array vs Multidimensional Array!
    Multidimensional is a rectangular array!
    And Jagged is a array of array, each element array inside the parent array could have different numbers of elements!
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
    */
    public void GameOfLife(int[][] board) {
        //initial another array to place the copied one
        int[] pos = new int[]{-1,0,1};

        //all the element in board has the same length
        int[,] Copied_Arr = new int[board.Length, board[0].Length];
        //fill data in to copied_arr
        for(int row = 0; row < board.Length;row++)
        {
            for(int col = 0; col < board[0].Length;col++)
            {
                Copied_Arr[row,col] = board[row][col];
            }
        }

        //loop through the copied(with original data in it)
        for(int row = 0; row < board.Length;row++)
        {
            for(int col = 0; col < board[0].Length;col++)
            {
                int live_neighbour = 0;
                //loop through all neighbours - calculate the real position
                //row + pos[i] is real row pos, col + pos[j] is real col pos
                for(int i = 0; i < pos.Length;i++)
                {
                    for(int j =0; j < pos.Length;j++)
                    {
                        //check if i and j is valid
                        if(
                            row + pos[i] >= 0 
                            && row + pos[i] < board.Length
                            && col + pos[j] >= 0 
                            && col + pos[j] < board[0].Length
                            //below is self pos
                            && !(pos[i] == 0 && pos[j] == 0)
                            && Copied_Arr[row + pos[i],col + pos[j]] == 1
                            )
                            {
                                live_neighbour++;
                            }
                    }
                }
                board[row][col] = live_neighbour;
            }
        }
        //now the board shows the live_neighbour number and copied_arr shows the self status
        for(int row = 0; row < board.Length;row++)
        {
            for(int col = 0; col < board[0].Length;col++)
            {
                if(
                    (Copied_Arr[row,col] == 1 && (board[row][col] == 2 || board[row][col] == 3))
                    || (Copied_Arr[row,col] == 0 && board[row][col] == 3)
                )
                {
                    board[row][col] = 1;
                }
                else
                {
                    board[row][col] = 0;
                }
            }
        }
    }
}