using System;

namespace LeetCode.Gen;

// https://leetcode.com/problems/merge-strings-alternately/
// 1768. Merge Strings Alternately

public class MergeStringsAlternately1768
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = string.Empty;
        var stringLength = Math.Min(word1.Length, word2.Length);

        if (word1.Length == word2.Length)
        {
            stringLength = word1.Length;
        }

        for (int i = 0; i < stringLength; i++)
        {
            result += word1[i] + "" + word2[i];
        }

        if(word1.Length > word2.Length)
        {
            result += word1.Substring(stringLength, word1.Length - stringLength);
        }
        else if(word2.Length > word1.Length)
        {
            result += word2.Substring(stringLength, word2.Length - stringLength);
        }

        return result;
    }
}
