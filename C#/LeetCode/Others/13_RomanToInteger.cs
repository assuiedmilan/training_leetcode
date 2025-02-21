using System;
using System.Collections.Generic;

namespace LeetCode.Others;

/* https://leetcode.com/problems/roman-to-integer/description/ */
public class RomanToInteger
{   
    static readonly Dictionary<string, int> k_ValuesMap = new()
    {
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 }
    };
    
    public int Solution(string s)
    {
        var numericValue = 0;
        
        for( var index = 0; index < s.Length; index++ )
        {
            var nextChar = "";
            if (index < s.Length - 1)
            {
                nextChar = s[index + 1].ToString();
            }

            var currentChar = s[index].ToString();
    
            if (k_ValuesMap.TryGetValue(currentChar + nextChar, out var value))
            {
                numericValue += value;
                index++;
            }
            else
            {
                numericValue += k_ValuesMap[currentChar];
            }
        }
        
        return numericValue;
    }
}