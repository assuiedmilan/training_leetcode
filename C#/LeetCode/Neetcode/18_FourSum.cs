using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/4sum/description/ */
public class FourSum
{
    public IList<IList<int>> Solution(int[] nums, int target)
    {   
        Array.Sort(nums);
        List<IList<int>> ans = [];

        if (nums.Length < 4) return ans;
        
        for (var k = 0; k < nums.Length - 3; k++)
        {
            var updatedTarget = target - nums[k];
            if (k> 0 && nums[k] == nums[k - 1]) continue; //Avoid duplicates
            
            for (var i = k+1; i < nums.Length; i++)
            {
                if (i> k+1 && nums[i] == nums[i - 1]) continue;

                var subTarget = updatedTarget - nums[i];

                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    //if (nums[left] > subTarget) break;
                    var current = nums[left] + nums[right];

                    if (current == subTarget)
                    {
                        ans.Add([nums[k], nums[i], nums[left], nums[right]]);
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                        continue;
                    }

                    if (current < subTarget)
                    {
                        left++;
                        continue;
                    }

                    right--;
                }
            }
        }
        return ans;
    }
}
