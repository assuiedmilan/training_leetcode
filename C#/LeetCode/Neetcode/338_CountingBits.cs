using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/counting-bits/description/ */
public class CountingBits
{
    public int[] Solution(int n)
    {
        var ans = new int[n + 1];

        for (var i = 1; i < n + 1; i++)
        {
            ans[i] = ans[i >> 1] + (i & 1);
            
            Console.Write($"Value at index {i}: ");
            Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
            
            Console.Write($"Value at index {i >> 1}: ");
            Console.WriteLine(Convert.ToString(i >> 1, 2).PadLeft(32, '0'));
            Console.WriteLine($"Number of set bits: {ans[i]}");
            Console.WriteLine();
        }

        return ans;
    }
}