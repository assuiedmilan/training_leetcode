using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/majority-element/description/ */
public class MajorityElement
{
    public int Solution(int[] nums)
    {
        var m = 0;
        var c = 0;

        foreach (var x in nums)
        {
            if (c == 0)
            {
                m = x;
                c = 1;
            }
            else if (m == x)
            {
                c++;
            }
            else
            {
                c--;
            }
        }

        return m;
    }
}