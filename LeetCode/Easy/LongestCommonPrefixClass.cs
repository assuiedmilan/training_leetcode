using System;

namespace LeetCode.Easy;

public class LongestCommonPrefixClass
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     *
     * If there is no common prefix, return an empty string "".
     *
     *
     *
     * Example 1:
     *
     * Input: strs = ["flower","flow","flight"]
     * Output: "fl"
     *
     * Example 2:
     *
     * Input: strs = ["dog","racecar","car"]
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
     *
     *
     *
     * Constraints:
     *
     *     1 <= strs.length <= 200
     *     0 <= strs[i].length <= 200
     *     strs[i] consists of only lowercase English letters.
     *
     */

    public static string LongestCommonPrefix_HorizontalScanning(string[] strs)
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
        return prefix; //O(n * n^2) aka O(n^2) but can perform less because of array sorting overhead and comparison costs of sorting arrays.
    }
    
    public static string LongestCommonPrefix_Sorting(string[] strs)
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

        return i == 0 ? "" : first[..i]; //O(n log n + n) aka O(n)
    }
    
    public static string LongestCommonPrefixBasic(string[] strs)
    {
        const int maxSize = 200;
    
        var output = "";
        switch (strs.Length)
        {
            case 0:
                return output;
            case 1:
                return strs[0];
        }

        var shortestWordLenght = maxSize + 1;

        foreach (var word in strs) //O(n) iteration
        {
            shortestWordLenght = word.Length < shortestWordLenght ? word.Length : shortestWordLenght;
        }

        //O(n2) as max lengths are same by constraints
        for (var i = 0; i < shortestWordLenght; i++)
        {
            var isSame = true;
            var nextChar = strs[0][i];
            for (var j =1; j < strs.Length; j++) //O(n) iteration
            {
                if (strs[j][i] == nextChar) continue;
                isSame = false;
                break;
            }

            if (!isSame)
            {
                break;
            }

            output += nextChar;
        }

        return output;
    }
}