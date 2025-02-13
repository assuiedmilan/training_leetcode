using System;
using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

public class RemoveDuplicatesFromSortedArray26Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,1,2]).Returns(2).SetName("Example 1");
        yield return new TestCaseData((int[])[0,0,1,1,1,2,2,3,3,4]).Returns(5).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new RemoveDuplicatesFromSortedArray26();
        return MeasureExecutionTime.Measure(() => testObject.RemoveDuplicates(nums));
    }
}
