using System;
using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class MergeSortedArray88Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,2,3,0,0,0], 3, (int[])[2,5,6], 3); //1,2,2,3,5,6
        yield return new TestCaseData((int[])[0], 0, (int[])[1], 1); // 1
        yield return new TestCaseData((int[])[1, 0], 1, (int[])[2], 1); // 1,2
        // yield return new TestCaseData((int[])[1,2,3,0,0,0], 3, (int[])[2,5,6], 3).Returns((int[])[1,2,2,3,5,6]).SetName("Example 1");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public void TestSolution(int[] nums1, int m, int[] nums2, int n)
    {
        var testObject = new MergeSortedArray88();
        testObject.Merge(nums1, m, nums2, n);
        for (int i = 0; i < nums1.Length; i++)
        {
            Console.WriteLine(nums1[i]);
        }
        // return MeasureExecutionTime.Measure(() => testObject.Merge(nums1, m, nums2, n));
    }
}
