using System.Collections.Generic;

namespace LeetCode.Arrays.Extras;

public class FirstPaintedRowOrColumn
{
    public int Solution(int[] arr, int[][] mat)
    {
        var nCol = mat[0].Length;
        var nLines = mat.Length;
        
        var columnTracker = new int[nLines];
        var lineTracker = new int[nCol];

        var matrixMap = new (int, int)[nLines * nCol];

        for (var i = 0; i < nLines; i++)
        {
            for (var j = 0; j < nCol; j++)
            {
                matrixMap[mat[i][j] - 1] = (i,j);
            }
        }
    
        for (var i = 0; i < arr.Length; i++)
        {
            var cCount = columnTracker[matrixMap[arr[i] - 1].Item1]++;
            var lCount = lineTracker[matrixMap[arr[i] - 1].Item2]++;

            if (cCount == nCol -1 || lCount == nLines - 1) return i;
        }

        return -1;
    }    
}
