using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class F4Sum18Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,0,-1,0,-2,2], 0).Returns((IList<IList<int>>)[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]).SetName("Example 1");
        yield return new TestCaseData((int[])[2,2,2,2,2], 8).Returns((IList<IList<int>>)[[2,2,2,2]]).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] nums, int target)
    {
        var testObject = new F4Sum18();
        return MeasureExecutionTime.Measure(() => testObject.FourSum(nums, target));
    }
}
