using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/valid-sudoku/description/ */
public class ValidSudoku
{
    public bool Solution(char[][] board)
    {
        /*
         * The solution is actually O(n) because a 9x9 board is equivalent to an array of size 81.
         * It is the size of the array that is bounded to a ^2 relationship, n is actually 81, not 9.
         * For a board of size 10, the array size increase by 23.5%, it will be the same for the execution speed.
         * If the algorithm was O(n^2), that increase would be 52%.
         */

        const int boardSize = 9;
        const int boxSize = 3;
        const int numberOfBoxes = boardSize*boardSize;
        const int tableOffset = '1';
        const int emptyCell = '.' - tableOffset;
        
        Span<bool> rowTracker = stackalloc bool[numberOfBoxes];
        Span<bool> columnTracker = stackalloc bool[numberOfBoxes];
        Span<bool> boxTracker = stackalloc bool[numberOfBoxes];

        for (var i = 0; i < boardSize; i++)
        {
            var offset = i * boardSize;
            
            for (var j = 0; j < boardSize; j++)
            {
                var rowValue =  board[i][j] - tableOffset;
                var columnValue = board[j][i] - tableOffset;
                
                var result = Do(rowValue, offset, rowTracker);
                result = result && Do(columnValue, offset, columnTracker);
                result = result && Do(rowValue, (i/boxSize * boxSize + j/boxSize) * boardSize, boxTracker);
                
                if (!result) return false;
                
            }
            
        }

        return true;

        bool Do(int value, int offset, Span<bool> tracker)
        {
            if (value != emptyCell)
            {
                var index = offset + value;
                if (tracker[index]) return false;
                tracker[index] = true;
            }

            return true;
        }
    }
}