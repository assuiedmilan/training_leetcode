using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class T3Sum15Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        // yield return new TestCaseData((int[])[-1,0,1,2,-1,-4]).Returns((IList<IList<int>>)[[-1,-1,2],[-1,0,1]]).SetName("Example 1");
        // yield return new TestCaseData((int[])[0,1,1]).Returns((IList<IList<int>>)[]).SetName("Example 2");
        // yield return new TestCaseData((int[])[0,0,0]).Returns((IList<IList<int>>)[[0,0,0]]).SetName("Example 3");
        // yield return new TestCaseData((int[])[-2,-2,0,0,2,2]).Returns((IList<IList<int>>)[[-2,0,2]]).SetName("Example 4");
        yield return new TestCaseData((int[])[-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6]).Returns((IList<IList<int>>)[[-4,-2,6],[-4,0,4],[-4,1,3],[-4,2,2],[-2,-2,4],[-2,0,2]]).SetName("Example 5");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] nums)
    {
        var testObject = new T3Sum15();
        return MeasureExecutionTime.Measure(() => testObject.ThreeSum2(nums));
    }
}
