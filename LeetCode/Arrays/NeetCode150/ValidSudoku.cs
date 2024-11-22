﻿namespace LeetCode.Arrays.NeetCode150;

/*
 * You are given a 9 x 9 Sudoku board. A Sudoku board is valid if the following rules are followed:
 *
 *    Each row must contain the digits 1-9 without duplicates.
 *    Each column must contain the digits 1-9 without duplicates.
 *    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without duplicates.
 *
 * Return true if the Sudoku board is valid, otherwise return false
 *
 * Note: A board does not need to be full or be solvable to be valid.
 */
public class ValidSudoku
{
    const int k_BoardSize = 9;
    const int k_BoxSize = 3;
    const char k_EmptyCell = '.';
    const char k_DigitWasSeen = '1';

    public bool Solution(char[][] board) {

    /*
     * The solution is actually O(n) because a 9x9 board is equivalent to an array of size 81.
     * It is the size of the array that is bounded to a ^2 relationship, n is actually 81, not 9.
     * For a board of size 10, the array size increase by 23.5%, it will be the same for the execution speed.
     * If the algorithm was O(n^2), that increase would be 52%.
     */

        var boxesMatrix = new char[k_BoardSize][];
        for (var i = 0; i < k_BoardSize; i++)
        {
            var rowArray = new char[k_BoardSize];
            var columnArray = new char[k_BoardSize];

            for(var j = 0;  j < k_BoardSize; j++)
            {
                var rowValue = board[i][j];
                var columnValue = board[j][i];

                var boxIndex = i/k_BoxSize * k_BoxSize + j / k_BoxSize;
                boxesMatrix[boxIndex] ??= new char[k_BoardSize];
                var currentBox = boxesMatrix[boxIndex];

                if (rowValue != k_EmptyCell)
                {
                    if (rowArray[rowValue - '1'] == k_DigitWasSeen || currentBox[rowValue - '1'] == k_DigitWasSeen)
                    {
                        return false;
                    }

                    rowArray[rowValue - '1'] = k_DigitWasSeen;
                    currentBox[rowValue - '1'] = k_DigitWasSeen;
                }

                if (columnValue != k_EmptyCell)
                {
                    if (columnArray[columnValue - '1'] == k_DigitWasSeen)
                    {
                        return false;
                    }

                    columnArray[columnValue - '1'] = k_DigitWasSeen;
                }
            }
        }

        return true;
    }
}