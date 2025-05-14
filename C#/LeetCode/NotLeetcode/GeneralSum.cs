using System;
using System.Collections.Generic;

namespace LeetCode.NotLeetcode;


//N-Sum based on TwoSumII, ThreeSum and FourSum problems
public class GeneralSum
{
    List<IList<int>> m_Ans = [];
    
    public IList<IList<int>> Solution(int[] nums, int target, int combinationSize)
    {
        if (nums.Length < combinationSize) return m_Ans;
        return m_Ans;
    }
}
