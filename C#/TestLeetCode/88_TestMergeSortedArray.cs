using System;
using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestMergeSortedArray
{
    static readonly MergeSortedArray k_TestObject = new();

    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 0, 0, 0], 3, (int[]) [2, 5, 6], 3)
            .Returns((int[]) [1, 2, 2, 3, 5, 6])
            .SetName("Example1");
        yield return new TestCaseData((int[]) [1], 1, (int[]) [], 0)
            .Returns((int[]) [1])
            .SetName("SingleElement");
        yield return new TestCaseData((int[]) [0], 0, (int[]) [1], 1)
            .Returns((int[]) [1])
            .SetName("EmptyFirstArray");
        yield return new TestCaseData((int[]) [4, 5, 6, 0, 0, 0], 3, (int[]) [1, 2, 3], 3)
            .Returns((int[]) [1, 2, 3, 4, 5, 6])
            .SetName("ReverseOrder");
        yield return new TestCaseData((int[]) [2, 0], 1, (int[]) [1], 1)
            .Returns((int[]) [1, 2])
            .SetName("SingleElementEach");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums1, int m, int[] nums2, int n)
    {
        k_TestObject.Solution(nums1, m, nums2, n);
        return nums1;
    }
}
