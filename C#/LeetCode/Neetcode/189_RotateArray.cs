using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/rotate-array/description/ */
public class RotateArray
{
    public void Solution(int[] nums, int k)
    {
        if (k == 0) return;
        var reducedNumberOfRotations = k % nums.Length;
        
        if (reducedNumberOfRotations == 0) return;
        
        Array.Reverse(nums);
        Array.Reverse(nums, 0, reducedNumberOfRotations);
        Array.Reverse(nums, reducedNumberOfRotations, nums.Length - reducedNumberOfRotations);

    }

}