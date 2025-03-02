using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/merge-sorted-array/description/ */
public class MergeSortedArray
{
    public void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;
        
        var nPointer = n - 1;
        var mPointer = m - 1;

        while (mPointer > -1 || nPointer > -1)
        {
            if (nPointer == -1) break;
            if (mPointer == -1)
            {
                nums1[nPointer] = nums2[nPointer--];
                continue;
            }

            var mValue = nums1[mPointer];
            var nValue = nums2[nPointer];

            if (mValue > nValue)
            {
                nums1[mPointer + nPointer + 1] = mValue;
                mPointer--;
                continue;
            }
            nums1[mPointer + nPointer + 1] = nValue;
            nPointer--;

        }
    }
}
