using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCode.Gen;

// https://leetcode.com/problems/permutation-in-string/
// 424. Longest Repeating Character Replacement

/*
 * Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
 * In other words, return true if one of s1's permutations is the substring of s2.
 *
 * Example 1:
 * Input: s1 = "ab", s2 = "eidbaooo"
 * Output: true
 * Explanation: s2 contains one permutation of s1 ("ba").
 *
 * Example 2:
 * Input: s1 = "ab", s2 = "eidboaoo"
 * Output: false
 *
 * Constraints:
 * 1 <= s1.length, s2.length <= 104
 * s1 and s2 consist of lowercase English letters.
 */

public class PermutationInString567
{
    public bool CheckInclusion(string s1, string s2)
    {
        var result = false;
        var left = 0;
        var right = s1.Length - 1;




        return result;
    }
}
