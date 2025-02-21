using System;

namespace LeetCode.Neetcode;

// ReSharper disable once InconsistentNaming
/* https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/ */
public class TwoSumII
{
    public int[] Solution(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var current = numbers[left] + numbers[right];
            if (current == target) return [left + 1, right + 1];
            if (current < target) { left++; continue; }
            right--;
        }

        return [];
    }    
}
