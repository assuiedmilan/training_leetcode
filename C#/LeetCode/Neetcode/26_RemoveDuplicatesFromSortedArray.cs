using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/ */
public class RemoveDuplicatesFromSortedArray
{
    public int Solution(int[] nums) {
        var uniqueElementsCount = 1;
        
        for(var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1]) continue;
            nums[uniqueElementsCount] = nums[i];
            uniqueElementsCount++;
        }
        
        return uniqueElementsCount;
    }
}