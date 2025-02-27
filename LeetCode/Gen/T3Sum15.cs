using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LeetCode.Gen;

// https://leetcode.com/problems/3sum/description/
// 15. 3Sum

/*
    Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
    such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    Notice that the solution set must not contain duplicate triplets.
 */

public class T3Sum15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var solutions = new List<IList<int>>();
        if(nums.Length < 3) return solutions;
        Array.Sort(nums);

        //[-4,-1,-1,0,1,2]
        //[-2,-2,0,0,2,2]

        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= 1 && nums[i] == nums[i - 1]) continue; //on skip les duplicate

            var left = i + 1;
            var right = nums.Length - 1;
            var target = -nums[i];

            while (left < right)
            {
                if (nums[left] == nums[left + 1])
                {
                    left++;
                    continue;
                }
                if (nums[right] == nums[right - 1])
                {
                    right--;
                    continue;
                }
                //[-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6]
                //[[-4,-2,6],[-4,-2,6],[-4,0,4],[-4,1,3],[-4,2,2],[-2,-2,4],[-2,0,2]]

                var sum = nums[left] + nums[right];
                if  (sum == target)
                {
                    solutions.Add(new List<int> {nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return solutions;
    }

    public IList<IList<int>> ThreeSum2(int[] nums)
    {
        var solutions = new List<IList<int>>();
        if(nums.Length < 3) return solutions;
        Array.Sort(nums);

        //[-4,-1,-1,0,1,2]
        //[-2,-2,0,0,2,2]

        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= 1 && nums[i] == nums[i - 1]) continue; //on skip les duplicate

            var left = i + 1;
            var right = nums.Length - 1;
            var target = -nums[i];

            while (left < right)
            {
                var sum = nums[left] + nums[right];
                if  (sum == target)
                {
                    solutions.Add(new List<int> {nums[i], nums[left], nums[right]});
                    while (left < right && nums[left] == nums[left + 1]) // on skip les duplicate
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1]) // on skip les duplicate
                    {
                        right--;
                    }
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return solutions;
    }
}
