using System;
using System.Collections.Generic;

namespace LeetCode.NotLeetcode;


//N-Sum based on TwoSumII, ThreeSum and FourSum problems
public class GeneralSum
{
    List<IList<int>> m_Ans = [];
    
    public IList<IList<int>> Solution(int[] nums, int target, int combinationSize)
    {
        if (nums.Length < combinationSize) return m_Ans;

        Array.Sort(nums);
        NSum(nums, target, combinationSize, []);
        return m_Ans;
    }

    void NSum(int[] nums, int target, int combinationSize, IList<int> result)
    {
        switch (combinationSize)
        {
            case > 2:
            {
                var boundary = nums.Length - combinationSize + 1;
                for (var i = 0; i < boundary; i++)
                {
                    while (i > 0 && i < boundary && nums[i] == nums[i - 1]) i++;
                    result.Add(nums[i]);
                    var rangeStart = i + 1;
                    NSum(nums[rangeStart..], target - nums[i], combinationSize - 1, result);
                    result.Remove(nums[i]);
                }
                break;
            }
            case 2:
                TwoSum(nums, target, result);
                break;
        }
    }

    void TwoSum(int[] nums, int target, IList<int> result)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var current = nums[left] + nums[right];

            if (current == target)
            {
                result.Add(nums[left]);
                result.Add(nums[right]);
                m_Ans.Add(new List<int>(result));
                result.Remove(nums[left]);
                result.Remove(nums[right]);
                
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
