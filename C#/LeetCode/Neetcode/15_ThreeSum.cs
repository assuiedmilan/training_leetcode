﻿using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/3sum/description/ */
public class ThreeSum
{
    public IList<IList<int>> Solution(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> ans = [];

        if (nums.Length < 3) return ans;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i-1]) continue; //Avoid duplicates
            
            var targetIndex = i;
            var target = -nums[i];

            var left = targetIndex + 1;
            var right = nums.Length - 1;
            
            while (left < right)
            {
                if (nums[left] > target) break;
                var current = nums[left] + nums[right];

                if (current == target)
                {
                    ans.Add([-target, nums[left], nums[right]]);
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                    continue;
                }
                    
                if (current < target) { left++; continue; }
                right--;
            }
        }

        return ans;
    }
}
