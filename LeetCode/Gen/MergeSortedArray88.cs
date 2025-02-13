﻿using System;

namespace LeetCode.Gen;

// https://leetcode.com/problems/merge-sorted-array/description/
// 88. Merge Sorted Array

public class MergeSortedArray88
{
    /*
     You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing
    the number of elements in nums1 and nums2 respectively.

    Merge nums1 and nums2 into a single array sorted in non-decreasing order.

    The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be
    merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.


     *Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
    Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
    The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

    Input: nums1 = [0], m = 0, nums2 = [1], n = 1
    Output: [1]
    Explanation: The arrays we are merging are [] and [1].
    The result of the merge is [1].
    Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
     *
     */

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var nums1Right = m - 1;
        var nums2Right = n - 1;

        if (n == 0)
            return;

        while(nums1Right >= 0 || nums2Right >= 0)
        {
            if (nums2Right < 0) break;

            if (nums1Right < 0 || nums2[nums2Right] > nums1[nums1Right])
            {
                nums1[nums1Right + nums2Right + 1] = nums2[nums2Right];
                nums2Right--;
            }
            else
            {
                nums1[nums1Right + nums2Right + 1] = nums1[nums1Right];
                nums1Right--;
            }
        }
    }

}
