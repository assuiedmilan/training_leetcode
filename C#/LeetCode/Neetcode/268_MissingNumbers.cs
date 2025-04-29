namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/missing-number/description/ */
public class MissingNumber
{
    public int Solution(int[] nums)
    {
        var res = nums.Length;

        for (var i = 0; i < nums.Length; i++)
        {
            res ^= i ^ nums[i];
        }
        
        return res;
    }
}