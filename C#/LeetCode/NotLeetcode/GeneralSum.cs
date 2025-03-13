using System;
using System.Collections.Generic;

namespace LeetCode.NotLeetcode;


//N-Sum based on TwoSumII, ThreeSum and FourSum problems
public class GeneralSum
{
    public IList<IList<int>> Solution(int[] nums, int target, int combinationSize)
    {
        List<IList<int>> ans = [];

        if (nums.Length < combinationSize) return ans;

        Array.Sort(nums);
        
        if (combinationSize == 2)
        {
            TwoSum(nums, target, ans);
        }

        return ans;
    }

    void TwoSum(int[] nums, int target, IList<IList<int>> result)
    {
        Array.Sort(nums);
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var current = nums[left] + nums[right];

            if (current == target)
            {
                result.Add([nums[left], nums[right]]);
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                left++;
                right--;
                continue;
            }
            
            if (current < target)
            {
                left++;
                continue;
            }

            right--;
        }
    }
}
