
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/contains-duplicate-ii/description/ */
public class ContainsDuplicateIi
{
    public bool Solution(int[] nums, int k)
    {
        var set = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.TryAdd(nums[i], i))
            {
                var duplicateIndex = set[nums[i]];
                if (i - duplicateIndex <= k) return true;

                set[nums[i]] = i;
            }
        }

        return false;
    }
}