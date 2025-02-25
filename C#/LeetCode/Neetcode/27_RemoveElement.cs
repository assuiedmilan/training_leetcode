using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/remove-element/description/ */
public class RemoveElement
{
    public int Solution(int[] nums, int val) 
    {
        var replacementIndex = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) continue;
            nums[replacementIndex] = nums[i];
            replacementIndex++;
        }

        return replacementIndex;
    }
}