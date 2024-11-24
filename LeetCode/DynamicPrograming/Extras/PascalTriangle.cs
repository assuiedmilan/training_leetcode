using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.DynamicPrograming.Extras;

public class PascalTriangle
{
    public IList<IList<BigInteger>> Solution(int numRows)
    {
        var triangle = new List<IList<BigInteger>>();

        triangle.Add([1]);

        for (var i = 1; i < numRows; i++)
        {
            var previousRow = triangle[i-1];
            var row = new BigInteger[i+1];
            row[0] = 1;
            row[^1] = 1;
            
            var centerIndex = (i+1) / 2;

            for (var j = 1; j < centerIndex; j++)
            {
                var value = previousRow[j - 1] + previousRow[j];
                row[j] = value;
                row[^(1+j)] = value;
            }

            if ((i+1) % 2 !=0)
            {
                var value = previousRow[centerIndex-1] + previousRow[centerIndex];
                row[centerIndex] = value;
            }

            triangle.Add(row);
        }

        return triangle;
    }
}