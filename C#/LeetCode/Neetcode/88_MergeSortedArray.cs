using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/merge-sorted-array/description/ */
public class MergeSortedArray
{
    public void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;

        var mPointer = m - 1;
        var nPointer = n - 1;

        for (var i = m + n - 1; i > -1; i--)
        {
            if (nPointer == -1) return;

            if (mPointer == -1)
            {
                nums1[i] = nums2[nPointer--];
                continue;
            }
            
            if (nums1[mPointer] > nums2[nPointer])
            {
                nums1[i] = nums1[mPointer];
                mPointer--;
            }
            else
            {
                nums1[i] = nums2[nPointer];
                nPointer--;
            }
        }
    }
}
