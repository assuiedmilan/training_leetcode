using System;

namespace LeetCode.Gen;

//https://leetcode.com/problems/valid-palindrome/description/
//125. Valid Palindrome

public class ValidPalindrome125
{
    public bool IsPalindrome(string s)
    {
        var characters = s.ToCharArray();
        var l = 0;
        var r = characters.Length - 1;

        while (l <= r)
        {
            var leftChar = char.ToLower(characters[l]);
            var rightChar = char.ToLower(characters[r]);

            if (!char.IsAsciiLetterOrDigit(leftChar))
            {
                l++;
                continue;
            }
            if (!char.IsAsciiLetterOrDigit(rightChar))
            {
                r--;
                continue;
            }

            if (leftChar == rightChar)
            {
                l++;
                r--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
