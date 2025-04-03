using System.Collections.Generic;

namespace LeetCode.Gen;

// https://leetcode.com/problems/rotate-array/
// 189. Rotate Array

/*
 * Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
 *
    Example 1:
    Input: nums = [1,2,3,4,5,6,7], k = 3
    Output: [5,6,7,1,2,3,4]
    Explanation:
    rotate 1 steps to the right: [7,1,2,3,4,5,6]
    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    rotate 3 steps to the right: [5,6,7,1,2,3,4]

    Example 2:
    Input: nums = [-1,-100,3,99], k = 2
    Output: [3,99,-1,-100]
    Explanation:
    rotate 1 steps to the right: [99,-1,-100,3]
    rotate 2 steps to the right: [3,99,-1,-100]


    [-1]   k = 2
 */

public class RotateAway189
{
    public void Rotate(int[] nums, int k) {

        var newRotation = k % nums.Length;

        var list = new List<int>(nums);

        var test = list.GetRange(nums.Length - newRotation, newRotation);
        list.RemoveRange(nums.Length - newRotation, newRotation);
        list.InsertRange(0, test);

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = list[i];
        }
    }
}
