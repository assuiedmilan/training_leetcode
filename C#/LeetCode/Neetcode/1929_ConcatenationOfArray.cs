using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/concatenation-of-array/description/ */
public class ConcatenationOfArray
{
    public int[] Solution(int[] nums)
    {
        var ans = new int[2 * nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}