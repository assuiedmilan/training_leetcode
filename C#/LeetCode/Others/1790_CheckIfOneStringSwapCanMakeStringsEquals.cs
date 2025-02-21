using System.Collections.Generic;

namespace LeetCode.Others;

/* https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/description/ */
public class CheckIfOneStringSwapCanMakeStringsEquals
{
    public bool Solution(string s1, string s2)
    {
        var indexes = new List<int>();

        for (var i = 0; i < s1.Length; i++)
        {
            var first = s1[i];
            var second = s2[i];
            
            if (first == second) continue;
            indexes.Add(i);
            
            if (indexes.Count > 2) return false;

        }

        return indexes.Count == 0 || (indexes.Count == 2 && s1[indexes[0]] == s2[indexes[1]] && s2[indexes[0]] == s1[indexes[1]]);
    }    
}
