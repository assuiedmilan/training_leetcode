namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/sum-of-two-integers/description/ */
public class SumOfTwoIntegers
{
    public int Solution(int a, int b)
    {
        while (b != 0)
        {
            var carry = a & b;
            a ^= b;
            b = carry << 1;
        }

        return a;
    }
}
