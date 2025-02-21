using System;

namespace LeetCode.Others;

/* https://leetcode.com/problems/longest-common-prefix/ */
public class LongestCommonPrefix
{
    public string Solution_HorizontalScanning(string[] strs)
    {
        switch (strs.Length)
        {
            case 0:
                return "";
            case 1:
                return strs[0];
        }

        var prefix = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix, StringComparison.Ordinal))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return "";
            }
        }
        return prefix;
    }
    
    public string Solution_Sorting(string[] strs)
    {
        switch (strs.Length)
        {
            case 0:
                return "";
            case 1:
                return strs[0];
        }
    
        Array.Sort(strs); //O(n2 log n)

        var first = strs[0];
        var last = strs[^1];
        var shortestWordLenght = Math.Min(first.Length, last.Length);

        var i = 0;

        while (i < shortestWordLenght && first[i] == last[i]) {
            i++;
        }

        return i == 0 ? "" : first[..i];
    }
}