using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/minimum-size-subarray-sum/description/ */
public class MinimumSizeSubarraySum
{
    public int Solution(int target, int[] nums)
    {
        var result = 0;
        var left = 0;
        var right = 0;
        var sum = nums[left];

        while (right < nums.Length || sum >= target)
        {
            if (sum >= target)
            {
                var potentialResult = right - left + 1;
                result = result < potentialResult && result!= 0 ? result : potentialResult;
                sum -= nums[left];
                left++;
                continue;
            }

            if (right < nums.Length)
            {
                right++;
                if (right < nums.Length ) sum += nums[right];
            }
        }
        
        return result;
    }
}
