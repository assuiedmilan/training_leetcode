using System;

namespace LeetCode.Gen;

//https://leetcode.com/problems/minimum-size-subarray-sum/description/
// 209. Minimum Size Subarray Sum

/*
 * Given an array of positive integers nums and a positive integer target, return the minimal length of a
 * subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.
 *
 * Example 1:
 * Input: target = 7, nums = [2,3,1,2,4,3]
 * Output: 2
 * Explanation: The subarray [4,3] has the minimal length under the problem constraint.
 *
 * Example 2:
 * Input: target = 4, nums = [1,4,4]
 * Output: 1
 *
 * Example 3:
 * Input: target = 11, nums = [1,1,1,1,1,1,1,1]
 * Output: 0
 */

public class MinimumSizeSubarraySum209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var minLength = int.MaxValue;
        var left = 0;
        var right = 0;
        var sum = 0;
        var n = nums.Length;

        while (right < n)
        {
            sum += nums[right];
            right++;
            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left);
                sum -= nums[left];
                left++;
            }
        }

        if (minLength == int.MaxValue)
            minLength = 0;

        return minLength;
    }
}
