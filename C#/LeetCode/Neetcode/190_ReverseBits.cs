using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/reverse-bits/description/ */
public class ReverseBits
{
    public uint Solution(uint n)
    {
        uint res = 0;

        for (var i = 0; i < 32; i++)
        {
            res = (res << 1) | (n & 1);
            n >>= 1;
        }
            
        return res;
    }
}