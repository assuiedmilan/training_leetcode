using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class ContainsDuplicateII219Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,2,3,1], 3).Returns(true).SetName("Example 1");
        yield return new TestCaseData((int[])[1,0,1,1], 1).Returns(true).SetName("Example 2");
        yield return new TestCaseData((int[])[1,2,3,1,2,3], 2).Returns(false).SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(int[] nums, int k)
    {
        var testObject = new ContainsDuplicateII219();
        return MeasureExecutionTime.Measure(() => testObject.ContainsNearbyDuplicate(nums, k));
    }
}
