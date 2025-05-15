using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class MinimumSizeSubarraySum209Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(7, (int[])[2,3,1,2,4,3]).Returns(2).SetName("Example 1");
        yield return new TestCaseData(4, (int[])[1,4,4]).Returns(1).SetName("Example 2");
        yield return new TestCaseData(11, (int[])[1,1,1,1,1,1,1,1]).Returns(0).SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int target, int[] nums)
    {
        var testObject = new MinimumSizeSubarraySum209();
        return MeasureExecutionTime.Measure(() => testObject.MinSubArrayLen(target, nums));
    }
}
