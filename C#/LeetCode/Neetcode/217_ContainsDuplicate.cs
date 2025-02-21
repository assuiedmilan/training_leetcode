using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/contains-duplicate/description/ */
public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1)
        {
            return false;
        }

        var map = new Dictionary<int, int>();

        foreach (var value in nums)
        {
            if (!map.TryAdd(value, 1))
            {
                return true;
            }
        }

        return false;
    }
}