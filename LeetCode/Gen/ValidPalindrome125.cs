using System;
using System.Linq;

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
            if (!char.IsLetterOrDigit(characters[l]))
            {
                l++;
                continue;
            }
            if (!char.IsLetterOrDigit(characters[r]))
            {
                r--;
                continue;
            }

            if (char.ToLower(characters[l]) == char.ToLower(characters[r]))
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

    public bool IsPalindrome2(string s)
    {
        var characters = s.ToLower().ToCharArray().Where(char.IsLetterOrDigit).ToArray();
        var l = 0;
        var r = characters.Length - 1;

        while (l <= r)
        {
            if (characters[l] == characters[r])
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
