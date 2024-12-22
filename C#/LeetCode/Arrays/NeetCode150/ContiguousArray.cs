using System.Collections.Generic;

namespace LeetCode.Arrays.NeetCode150;

using NumberOfOnesEncounteredForEachZeroEncountered = int;
using IndexOfFirstTimeCountOfOnesIsEncountered = int;

/*
 * Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.
 *
 * Example 1:
 *
 * Input: nums = [0,1]
 * Output: 2
 * Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
 *
 * Example 2:
 *
 * Input: nums = [0,1,0]
 * Output: 2
 * Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
 *
 * Constraints:
 *
 *     1 <= nums.length <= 105
 *     nums[i] is either 0 or 1.
 *
 */ 
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