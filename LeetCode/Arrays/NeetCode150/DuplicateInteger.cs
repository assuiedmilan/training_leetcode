using System.Collections.Generic;

namespace LeetCode.Arrays.NeetCode150;

/*
 * Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
 *
 * Example 1:
 *
 * Input: nums = [1, 2, 3, 3]
 *
 * Output: true
 *
 * Example 2:
 *
 * Input: nums = [1, 2, 3, 4]
 *
 * Output: false
 *
 */
public class DuplicateInteger
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