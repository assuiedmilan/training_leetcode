using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Gen;

public class SlidingWindowMaximum239
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var output = new int[nums.Length - k + 1];
        var queue = new LinkedList<int>();
        var left = 0;
        var right = 0;

        while (right < nums.Length)
        {
            while (queue.Count > 0 && nums[queue.Last.Value] < nums[right])
                queue.RemoveLast();

            queue.AddLast(right);

            if(left > queue.First.Value)
                queue.RemoveFirst();

            if(right + 1 >= k)
            {
                output[left] = nums[queue.First.Value];
                left++;
            }

            right++;
        }

        return output;
    }
}
