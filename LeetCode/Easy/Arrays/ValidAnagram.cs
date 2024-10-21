using System.Collections.Generic;

namespace LeetCode.Easy.Arrays;

public class ValidAnagram
{
    /*
    * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    *
    * Example 1:
    *
    * Input: s = "anagram", t = "nagaram"
    *
    * Output: true
    *
    * Example 2:
    *
    * Input: s = "rat", t = "car"
    *
    * Output: false
    *
    *
    *
    * Constraints:
    *
    *     1 <= s.length, t.length <= 5 * 104
    *     s and t consist of lowercase English letters.
    *
    *
    *
    * Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
     */

    static void DoCount(string s, Dictionary<char, int> map)
    {
        foreach (var value in s)
        {
            if (!map.TryAdd(value, 1))
            {
                map[value] += 1;
            }
        }
    }

    public bool IsAnagram(string s, string t) {

        //Unicode would be exactly the same

        if (s.Length != t.Length)
        {
            return false;
        }

        var charCount = new Dictionary<char, int>();

        DoCount(s, charCount);

        foreach (var c in t)
        {
            if (!charCount.TryGetValue(c, out var count) || count == 0)
            {
                return false;
            }
            charCount[c]--;
        }

        return true;
    }
}
