namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/single-number/description/ */
public class SingleNumber
{
    public int Solution(int[] nums)
    {
        var value = 0b0;

        foreach (var v in nums)
        {
            value ^= v;
        }

        return value;
    }
}