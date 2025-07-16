namespace LeetCode.Gen;

// https://leetcode.com/problems/minimum-window-substring/description/
// 76. Minimum Window Substring

/*
 * Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every
 * character in t (including duplicates) is included in the window.
 * If there is no such substring, return the empty string "".
 * The testcases will be generated such that the answer is unique.
 *
 * Example 1:
 * Input: s = "ADOBECODEBANC", t = "ABC"
 * Output: "BANC"
 * Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
 *
 * Example 2:
 * Input: s = "a", t = "a"
 * Output: "a"
 * Explanation: The entire string s is the minimum window.
 *
 * Example 3:
 * Input: s = "a", t = "aa"
 * Output: ""
 * Explanation: Both 'a's from t must be included in the window.
 * Since the largest window of s only has one 'a', return empty string.
 *
 * Constraints:
 * m == s.length
 * n == t.length
 * 1 <= m, n <= 105
 * s and t consist of uppercase and lowercase English letters.
 *
 * Follow up: Could you find an algorithm that runs in O(m + n) time?
 *
 */

public class MinimumWindowSubstring76
{
    public string MinWindow(string s, string t)
    {
        // Solution from https://leetcode.com/problems/minimum-window-substring/solutions/4673541/beats-100-explained-any-language-by-prodonik/
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return "";
        }

        int[] map = new int[128];
        int count = t.Length;
        int start = 0, end = 0, minLen = int.MaxValue, startIndex = 0;
        foreach (char c in t) {
            map[c]++;
        }

        char[] chS = s.ToCharArray();

        while (end < chS.Length) {
            if (map[chS[end++]]-- > 0) {
                count--;
            }

            while (count == 0) {
                if (end - start < minLen) {
                    startIndex = start;
                    minLen = end - start;
                }

                if (map[chS[start++]]++ == 0) {
                    count++;
                }
            }
        }

        return minLen == int.MaxValue ? "" : new string(chS, startIndex, minLen);
    }
}
