using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/sort-an-array/ */
public class SortArray
{
    public int[] Solution(int[] nums)
    {
        MaxHeap(nums);

        for (var i = nums.Length - 1; i > 0; i--) {
            (nums[0], nums[i]) = (nums[i], nums[0]);
            MaxHeap(nums, i, 0);
        }
        
        return nums;
    }

    static void MaxHeap(int[] arr)
    {
        var lastNonleafNode = arr.Length / 2 - 1;
        for(var i = lastNonleafNode; i > -1; i--) MaxHeap(arr, arr.Length, i);
    }

    static void MaxHeap(int[] arr, int heapifyLenght, int root)
    {
        while (true)
        {
            var largestNodeIndex = root;
            var leftLeafIndex = 2 * root + 1;
            var rightLeafIndex = leftLeafIndex + 1;

            if (leftLeafIndex < heapifyLenght && arr[leftLeafIndex] > arr[largestNodeIndex]) largestNodeIndex = leftLeafIndex;
            if (rightLeafIndex < heapifyLenght && arr[rightLeafIndex] > arr[largestNodeIndex]) largestNodeIndex = rightLeafIndex;

            if (largestNodeIndex != root)
            {
                (arr[largestNodeIndex], arr[root]) = (arr[root], arr[largestNodeIndex]);
                root = largestNodeIndex;
                continue;
            }

            break;
        }
    }
}