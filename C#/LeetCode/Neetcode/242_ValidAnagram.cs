namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/valid-anagram/description/ */
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