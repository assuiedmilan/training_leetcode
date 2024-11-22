namespace LeetCode.Arrays.NeetCode150;

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
public class ValidAnagram
{
    public bool Solution(string s, string t) {

        //Unicode would be exactly the same because the letters are sequentially aligned both in ASCII and Unicode.

        if (s.Length != t.Length) {
            return false;
        }

        var counts = new int[26];
        for (var i = 0; i < s.Length; i++) {
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }    
        foreach(var count in counts) {
            if (count != 0) {
                return false;
            }
        }
        return true;
    }
}