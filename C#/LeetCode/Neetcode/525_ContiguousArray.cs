using System.Collections.Generic;

namespace LeetCode.Neetcode;

using NumberOfOnesEncounteredForEachZeroEncountered = int;
using IndexOfFirstTimeCountOfOnesIsEncountered = int;

/* https://leetcode.com/problems/contiguous-array/description/ */
public class ContiguousArray
{   
    public int Solution(int[] nums)
    {
        var longestSubArray = 0;
        var numberOfOnesEncounteredForEachZeroEncountered = 0;
        var map = new Dictionary<NumberOfOnesEncounteredForEachZeroEncountered, IndexOfFirstTimeCountOfOnesIsEncountered>
        {
            [0] = -1 //Initialize first left boundary + take zero based indexing into account for when we will calculate the range: array range between index 0 and n is n + 1.
        };

        for (var i = 0; i<nums.Length; i++)
        {
            numberOfOnesEncounteredForEachZeroEncountered += nums[i] == 1 ? 1:-1;
            
            if(map.TryGetValue(numberOfOnesEncounteredForEachZeroEncountered, out var value))
            {
                var subArraySize = i - value;
                if (longestSubArray < subArraySize)
                {
                    longestSubArray = subArraySize;
                }
            }
            else
            {
                map[numberOfOnesEncounteredForEachZeroEncountered] = i;
            }
        }

        return longestSubArray;
    }
}