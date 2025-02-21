using System.Collections.Generic;

namespace LeetCode.Others;

/* https://leetcode.com/problems/summary-ranges/description/ */
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