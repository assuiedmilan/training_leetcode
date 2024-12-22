using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.DynamicPrograming.Extras;

// ReSharper disable once InconsistentNaming
public class PascalTriangleII
{
    public IList<BigInteger> Solution(int rowIndex)
    {
        var row = new BigInteger[rowIndex + 1];
        row[0] = 1;

        for (var i = 1; i <= rowIndex; i++) {
            
            var centerIndex = (i+1) / 2;
            var centerValue = row[centerIndex] + row[centerIndex - 1];
            
            for (var j = i; j > centerIndex -1; j--) {
                row[j] += row[j - 1];
                row[i - j] = row[j];
            }
            
            if ((i+1) % 2 !=0)
            {
                row[centerIndex] = centerValue; 
            }
        }

        return row;
    }
}