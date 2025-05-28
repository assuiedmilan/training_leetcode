namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/minimum-window-substring/description/ */
public class MinimumWindowSubstring
{
    public string Solution(string s, string t)
    {
        if (t.Length > s.Length) return "";

        var referenceTable = new int[58];
        var trackingTable = new int[58];
        var referenceSum = t.Length;
        var trackingSum = 0;
        var minLen = int.MaxValue;
        var startIndex = 0;
        
        foreach (var c in t)
        {
            referenceTable[c - 'A'] += 1;
        }

        var left = 0;
        for (var right = 0; right < s.Length; right++)
        {
            var c = s[right];
            var cIndex = c - 'A';
            trackingTable[cIndex] += 1;

            if (trackingTable[cIndex] <= referenceTable[cIndex]) trackingSum++;

            if (trackingSum == referenceSum)
            {
                var leftChar = s[left];
                var leftCharIndex = leftChar - 'A';
                while (left < right && (referenceTable[leftCharIndex] == 0 || trackingTable[leftCharIndex] > referenceTable[leftCharIndex]))
                {
                    trackingTable[leftCharIndex] -= 1;
                    left++;
                    leftChar = s[left];
                    leftCharIndex = leftChar - 'A';
                }
                
                var len = right - left + 1;
                if (minLen > len)
                {
                    startIndex = left;
                    minLen = len;
                }
            }
        }

        return trackingSum == referenceSum ? s.Substring(startIndex, minLen) : "";
    }
} 