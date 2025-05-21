namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/valid-anagram/description/ */
public class ValidAnagram
{
    public bool Solution(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var tracker = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            tracker[s[i] - 'a']++;
            tracker[t[i] - 'a']--;
        }

        for (var i = 0; i < 26; i++)
        {
            if (tracker[i] != 0) return false;
        }
 
        return true;
    }
}