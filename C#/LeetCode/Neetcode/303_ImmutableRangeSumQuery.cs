namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/range-sum-query-immutable/ */
public class ImmutableRangeSumQuery
{
    readonly int[] m_PrefixedSums;
    
    public ImmutableRangeSumQuery(int[] nums)
    {
        m_PrefixedSums = new int[nums.Length];
        m_PrefixedSums[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            m_PrefixedSums[i] = m_PrefixedSums[i - 1] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        if (left > 0)
        {
            return m_PrefixedSums[right] - m_PrefixedSums[left - 1];
        }

        return m_PrefixedSums[right];
    }
}