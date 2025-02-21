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
            var complement = target - nums[i]; //If this value is in the dict, it means that the sum of the two values is equal to the target.
            if (complementDictionary.ContainsKey( nums[i]))
            {
                return [complementDictionary[nums[i]], i];
            }
            complementDictionary[complement] = i;
        }
        return [];
    }
}