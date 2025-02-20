using System;
using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

public class TwoSumII167Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[2,7,11,15], 9).Returns((int[])[1,2]).SetName("Example 1");
        yield return new TestCaseData((int[])[2,3,4], 6).Returns((int[])[1,3]).SetName("Example 2");
        yield return new TestCaseData((int[])[-1,0], -1).Returns((int[])[1,2]).SetName("Example 3");
        yield return new TestCaseData((int[])[-10,-8,-2,1,2,5,6], 0).Returns((int[])[3,5]).SetName("Example 4");

    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums, int target)
    {
        var testObject = new TwoSumII167();
        return MeasureExecutionTime.Measure(() => testObject.TwoSum(nums, target));
    }
}
