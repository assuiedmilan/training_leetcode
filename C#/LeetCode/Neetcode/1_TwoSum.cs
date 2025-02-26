using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/two-sum/description/ */
public class TwoSum
{
    public int[] Solution(int[] nums, int target)
    {
        var complementDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (complementDictionary.TryGetValue( nums[i], out var value))
            {
                return [value, i];
            }
            complementDictionary[complement] = i;
        }
        return [];
    }
}