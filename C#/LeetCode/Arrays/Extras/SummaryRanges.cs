using System.Collections.Generic;

namespace LeetCode.Arrays.Extras;

/*
 * Note: The word continuous is missing from problem description
 * Each returned string must cover a subarray that contains ONLY continuous values
 * https://leetcode.com/problems/summary-ranges/description/
 *
 * Note: it seems that string.Concat is the most efficient way to concat strings, over StringBuilder.
 */
public class SummaryRanges
{
    public IList<string> Solution(int[] nums) {
        var results = new List<string>();
        
        if (nums.Length == 0) return results;

        var left = nums[0];

        for(var i = 1; i < nums.Length; i++)
        {   
            if (nums[i] == nums[i-1] + 1) continue;
            AddRange(i-1);
            left = nums[i];
        }
        
        AddRange(nums.Length-1);
        return results;

        void AddRange(int r) => results.Add(left == nums[r] ? string.Concat(left) : string.Concat(left, "->", nums[r]));
    }    
}