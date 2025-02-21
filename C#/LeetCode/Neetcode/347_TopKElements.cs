using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/top-k-frequent-elements/description/ */
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
