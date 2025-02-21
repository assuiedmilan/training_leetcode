using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/longest-consecutive-sequence/description/ */
public class LongestConsecutiveSequence
{
    public int Solution(int[] nums) {
        var longestStreak = 0;

        HashSet<int> setOfNums = [..nums];
        
        foreach (var num in setOfNums)
        {
            if (!setOfNums.Contains(num - 1))
            {
                var currentNum = num;
                var currentStreak = 1;

                while (setOfNums.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        
        return longestStreak;

    }
}