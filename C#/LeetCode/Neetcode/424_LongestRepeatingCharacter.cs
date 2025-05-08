namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/longest-repeating-character-replacement/description/ */
public class LongestRepeatingCharacter
{
    public int Solution(string s, int k)
    {
        var max = 0;
        var left = 0;
        var right = 0;
        var counter = new int[26];

        while (right < s.Length)
        {
            var v = s[right];
            counter[v - 'A'] += 1;
            right++;
            var currentLetterCount = counter[v - 'A'];

            if (currentLetterCount > max) max = currentLetterCount;
            
            if (right - left> max + k)
            {
                counter[s[left] - 'A'] -= 1;
                left++;
            }
        }

        return right - left ;
    }
}