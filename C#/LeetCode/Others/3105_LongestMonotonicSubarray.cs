namespace LeetCode.Others;

/* https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray/description/ */
public class LongestMonotonicSubarray
{
    public int Solution(int[] nums)
    {
        if (nums.Length is 0 or 1) return nums.Length;

        var maxLength = 1;
        var currentIncreasingLenght = 1;
        var currentDecreasingLength = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                currentIncreasingLenght++;
                currentDecreasingLength = 1;
            }
            else if (nums[i - 1] < nums[i])
            {
                currentDecreasingLength++;
                currentIncreasingLenght = 1;
            }
            else
            {
                currentIncreasingLenght = 1;
                currentDecreasingLength = 1;
            }
            
            var currentMax = currentIncreasingLenght > currentDecreasingLength ? currentIncreasingLenght : currentDecreasingLength;
            maxLength = currentMax > maxLength ? currentMax : maxLength;
        }

        return maxLength;
    }    
}
