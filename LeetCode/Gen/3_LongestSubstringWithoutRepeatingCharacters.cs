using System;
using System.Collections.Generic;

namespace LeetCode.Gen;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
// 3. Longest Substring Without Repeating Characters

public class LongestSubstringWithoutRepeatingCharacters3
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        var hashSet = new HashSet<char>();
        var left = 0;
        var maxCount = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (hashSet.Contains(s[right]))
            {
                hashSet.Remove(s[left++]);
            }

            hashSet.Add(s[right]);
            maxCount = Math.Max(maxCount, right - left + 1);
        }

        return maxCount;
    }
}
