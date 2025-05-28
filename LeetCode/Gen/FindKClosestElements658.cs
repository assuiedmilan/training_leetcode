using System;
using System.Collections.Generic;

namespace LeetCode.Gen;

// https://leetcode.com/problems/find-k-closest-elements/description/
// 658. Find K Closest Elements

/*
 * Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array.
 * The result should also be sorted in ascending order.
 *
 * An integer a is closer to x than an integer b if:
 * |a - x| < |b - x|, or
 * |a - x| == |b - x| and a < b
 * Example 1:
 * Input: arr = [1,2,3,4,5], k = 4, x = 3
 * Output: [1,2,3,4]
 *
 * Example 2:
 * Input: arr = [1,1,2,3,4,5], k = 4, x = -1
 * Output: [1,1,2,3]
 *
 * Constraints:
 * 1 <= k <= arr.length
 * 1 <= arr.length <= 104
 * arr is sorted in ascending order.
 * -104 <= arr[i], x <= 104
 */

public class FindKClosestElements658
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var startIndex = 0;
        var result = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                startIndex = i;
                break;
            }

            if (arr[i] > x)
            {
                if(arr[i] - x > x - arr[i - 1])
                {
                    startIndex = i - 1;
                }
                else
                {
                    startIndex = i;
                }
                break;
            }
        }

        var left = startIndex;
        var right = startIndex + 1;

        while (result.Count < k)
        {
            if (left >= 0 && right <= arr.Length - 1)
            {
                var diffLeft = Math.Abs(x - arr[left]);
                var diffRight = Math.Abs(x - arr[right]);
                if (diffLeft <= diffRight)
                {
                    result.Add(arr[left]);
                    left--;
                }
                else
                {
                    result.Add(arr[right]);
                    right++;
                }
            }
            else
            {
                if (left < 0)
                {
                    result.Add(arr[right]);
                    right++;
                }
                else
                {
                    result.Add(arr[left]);
                    left--;
                }
            }
        }

        result.Sort();

        return result;
    }
}
