namespace LeetCode.Others;

/* https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray/description/ */
public class LongestMonotonicSubarray
{
    public int Solution(int[] nums)
    {
        if (nums.Length is 0 or 1) return nums.Length;
        var maxLength = 1;
        return maxLength;
    }    
}
