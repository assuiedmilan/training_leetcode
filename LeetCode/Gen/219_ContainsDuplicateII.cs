using System.Collections.Generic;

namespace LeetCode.Gen;

/*
 * https://leetcode.com/problems/contains-duplicate-ii/
 * 219. Contains Duplicate II
 */

/*
 * Given an integer array nums and an integer k, return true if there are two distinct indices i and j
 * in the array such that nums[i] == nums[j] and abs(i - j) <= k.
 */


// Input: nums = [1,2,3,1], k = 3
// Output: true

public class ContainsDuplicateII219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i], i))
            {
                var duplicate = dict[nums[i]];
                if (i - duplicate <= k)
                {
                    return true;
                }

                dict[nums[i]] = i;
            }
        }

        return false;
    }

  // public bool ContainsNearbyDuplicate(int[] nums, int k)
  // {
  //     for (int i = 0; i < nums.Length-1; i++)
  //     {
  //         for (int j = i + 1; j <= i+k; j++)
  //         {
  //             if (j > nums.Length - 1)
  //                 break;
  //
  //             if (nums[i] == nums[j])
  //             {
  //                 return true;
  //             }
  //         }
  //     }
  //
  //     return false;
  // }
}
