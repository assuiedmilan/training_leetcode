using System;

namespace LeetCode.Others;

/* https://leetcode.com/problems/palindrome-number/description/ */
public class PalindromeNumber
{
    public bool Solution(int x)
    {
        if(x < 0  || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        
        if(x < 10)
        {
            return true;
        }
        
        var reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        return x == reversedHalf || x == reversedHalf / 10;
    }
    
    public bool Solution_ConvertToString(int x) {
        
        for(var left = 0; left < x.ToString().Length / 2; left++)
        {
            var right = x.ToString().Length - 1 - left;
            if(x.ToString()[left] != x.ToString()[right])
            {
                return false;
            }
        }

        return true;
    }
}