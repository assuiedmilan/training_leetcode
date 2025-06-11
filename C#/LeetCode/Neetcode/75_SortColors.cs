using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/sort-colors/description/ */
public class SortColors
{
    public void Solution(int[] nums)
    {
        Dictionary<int, int> tracker = [];

        foreach (var num in nums)
        {
            if (!tracker.TryGetValue(num, out var ints))
            {
                ints = 0;
                tracker.Add(num, ints);
            }

            tracker[num]++;
        }

        var index = 0;
        for (var i = 0; i < 3; i++)
        {
            if(!tracker.TryGetValue(i, out var ints)) continue;
            while (ints != 0)
            {
                nums[index] = i;
                index++;
                ints--;
            }
        }
    }
}