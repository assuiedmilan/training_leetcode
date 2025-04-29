using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/longest-substring-without-repeating-characters/description/ */
public class LongestSubstringWithoutRepeatingCharacters
{
    public int Solution(string s)
    {
        if (s.Length is 1 or 0) return s.Length;

        var charSet = new bool[256];
        var longestSequence = 0;
        var start = 0;

        for (var end = 0; end < s.Length; end++)
        {
            while (charSet[s[end]])
            {
                charSet[s[start]] = false;
                start++;
            }

            charSet[s[end]] = true;
            var candidate = end - start + 1;
            longestSequence = longestSequence > candidate ? longestSequence : candidate;
        }

        return longestSequence;
    }
}
