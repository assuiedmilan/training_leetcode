using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/group-anagrams/description/ */
public class GroupsOfAnagrams
{
    public IList<IList<string>> Solution(string[] strs)
    {
        switch (strs.Length)
        {
            case 0:
                return new List<IList<string>> { new List<string> { string.Empty } };
            case 1:
                return new List<IList<string>> { new List<string> { strs[0] } };
        }

        var resultsDict = new Dictionary<string, List<string>>();
        var results = new List<IList<string>>();
        
        foreach(var s in strs)
        {
            var charCount = new char[26];

            foreach (var d in s)
            {
                charCount[d%26]++;
            }
            
            var key = new string(charCount);
            
            if (!resultsDict.TryGetValue(key, out var curr))
            {
                curr = [];
                results.Add(curr);
                resultsDict.Add(key, curr);
            }

            curr.Add(s);
        }

        return results;
    }
}