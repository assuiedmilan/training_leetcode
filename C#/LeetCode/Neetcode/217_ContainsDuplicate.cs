using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/contains-duplicate/description/ */
public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        var tracker = new HashSet<int>();

        foreach (var num in nums)
        {
            if (tracker.TryGetValue(num, out _)) return true;
            tracker.Add(num);
        }
        return false;
    }
}