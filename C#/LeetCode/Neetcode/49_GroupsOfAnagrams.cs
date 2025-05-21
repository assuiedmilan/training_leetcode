using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/group-anagrams/description/ */
public class GroupsOfAnagrams
{
    public IList<IList<string>> Solution(string[] strs)
    {
        var results = new List<IList<string>>();
        var groups = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var tracker = new char[26];

            foreach (var t in str)
            {
                tracker[t - 'a']++;
            }
            var strKey = new string(tracker);

            if (!groups.TryGetValue(strKey, out var value))
            {
                value = new List<string>();
                value.Add(str);
                groups.Add(strKey, value);
                results.Add(value);
                continue;
            }

            groups[strKey].Add(str);
        }
        
        return results;
    }

}