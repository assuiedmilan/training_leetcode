using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/permutation-in-string/description/ */
public class PermutationInString
{
    public bool Solution(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;
        
        var res = false;

        var windowsSize = s1.Length;

        var left = 0;
        var right = windowsSize;

        var s1CharsTracker = new int[26];
        var s2CharsTracker = new int[26];

        for (var i = 0; i < windowsSize; i++)
        {
            s1CharsTracker[s1[i] - 'a'] += 1;
            s2CharsTracker[s2[i] - 'a'] += 1;
        }

        while (right < s2.Length + 1)
        {
            res = true;
            for (var i = 0; i < s1CharsTracker.Length; i++)
            {
                if (s1CharsTracker[i] != s2CharsTracker[i])
                {
                    s2CharsTracker[s2[left] - 'a'] -= 1;
                    if(right < s2.Length) s2CharsTracker[s2[right] - 'a'] += 1;
                    right++;
                    left++;

                    res = false;
                    break;
                }
            }

            if (res) break;
        }
        
        return res;
    }
}