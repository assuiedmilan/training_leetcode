using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/ */
public class RemoveDuplicatesFromSortedArray
{
    public int Solution(int[] nums)
    {
        var replacementIndex = 1;
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i-1] == nums[i]) continue;
            nums[replacementIndex++] = nums[i];
        }

        return replacementIndex;
    }
}