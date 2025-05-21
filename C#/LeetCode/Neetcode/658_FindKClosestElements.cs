using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/find-k-closest-elements/ */
public class FindKClosestElements
{
    public IList<int> Solution(int[] arr, int k, int x)
    {
        if (k == arr.Length || arr.Length == 1) return arr;

        #region Find index of x

        var left = 0;
        var right = arr.Length - 1;
        var indexOfX =0;
        
        while (left <= right)
        {
            indexOfX = left + (right - left) / 2;
            if (arr[indexOfX] == x) break;
            if (arr[indexOfX] < x) left = indexOfX + 1; 
            else right = indexOfX - 1; 
        }

        if (arr[indexOfX] != x)
        {
            if (left >= arr.Length) indexOfX = right;
            else if (right < 0) indexOfX = left;
            else indexOfX = Math.Abs(arr[left] - x) < Math.Abs(arr[right] - x) ? left : right;
        }
        #endregion
        
        #region Find closests elements

        var leftPart = new List<int> { arr[indexOfX] };
        var rightPart = new List<int>();
        
        left = indexOfX - 1;
        right = indexOfX + 1;
        k--;

        while ( k != 0)
        {
            switch (left)
            {
                case > -1 when right == arr.Length:
                case > -1 when (x - arr[left] < arr[right] - x || x - arr[left] == arr[right] - x):
                    leftPart.Add(arr[left]);
                    left--;
                    k--;
                    continue;
            }

            if (right < arr.Length)
            {
                rightPart.Add(arr[right]);
                right++;
                k--;
                continue;
            }

            break;
        }

        var res = new List<int>();

        for (var i = leftPart.Count - 1; i > -1; i--)
        {
            res.Add(leftPart[i]);
        }

        foreach (var t in rightPart)
        {
            res.Add(t);
        }
        
        #endregion
        return res;

    }
}