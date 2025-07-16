using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class FindKClosestElements658Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,2,3,4,5], 4, 3).Returns((int[])[1,2,3,4]).SetName("Example 1");
        yield return new TestCaseData((int[])[1,1,2,3,4,5], 4, -1).Returns((int[])[1,1,2,3]).SetName("Example 2");
        yield return new TestCaseData((int[])[0,0,1,2,3,3,4,7,7,8], 3, 5).Returns((int[])[3,3,4]).SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<int> TestSolution(int[] arr, int k, int x)
    {
        var testObject = new FindKClosestElements658();
        return MeasureExecutionTime.Measure(() => testObject.FindClosestElements(arr, k, x));
    }
}
