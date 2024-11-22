using System.Collections.Generic;

namespace LeetCode.Arrays.NeetCode150;

/*
 * Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
 *
 *
 *
 * Example 1:
 *
 * Input: nums = [1,1,1,2,2,3], k = 2
 * Output: [1,2]
 *
 * Example 2:
 *
 * Input: nums = [1], k = 1
 * Output: [1]
 *
 *
 *
 * Constraints:
 *
 *     1 <= nums.length <= 105
 *     -104 <= nums[i] <= 104
 *     k is in the range [1, the number of unique elements in the array].
 *     It is guaranteed that the answer is unique.
 *
 *
 *
 * Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
 */
public class TopKElements
{
    public int[] Solution(int[] nums, int k) {
        if (nums.Length == k) return nums;

        //Done in O(n) time and space complexity
        var frequency = new Dictionary<int, int>();
        var frequencyArray = new List<int>[nums.Length + 1];
        var results = new int[k];

        foreach (var v in nums) //O(n)
        {
            if(!frequency.TryAdd(v, 1)) frequency[v]++;
        }

        foreach (var (key, value) in frequency) //O(n-1) (a single value is found twice in the original array, all values distinct is already covered)
        {
            frequencyArray[value] ??= [];
            frequencyArray[value].Add(key);
        }

        for(var i = frequencyArray.Length - 1; i > 0; i--) //O(n-1)
        {
            if(frequencyArray[i] != null)
            {
                foreach (var v in frequencyArray[i])
                {
                    k--;
                    results[k] = v;
                }
            }

            if (k == 0) break;
        }

        return results;
    }
}
