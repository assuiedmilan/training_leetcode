namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/number-of-1-bits/description/ */
public class NumberOfBitsSet
{
    public int Solution(int n)
    {
        var count = 0;
        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}