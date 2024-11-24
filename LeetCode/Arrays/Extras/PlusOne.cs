using System;

namespace LeetCode.Arrays.Extras;

public class PlusOne
{
    public int[] Solution(int[] digits)
    {   
        for (var i = 0; i < digits.Length; i++)
        {
            if (digits[^(1+i)] != 9)
            {
                digits[^(1+i)] += 1;
                return digits;
            }

            digits[^(1 + i)] = 0;
        }
       
        var newArray = new int[digits.Length + 1];
        newArray[0] = 1;
        return newArray;
    }
}