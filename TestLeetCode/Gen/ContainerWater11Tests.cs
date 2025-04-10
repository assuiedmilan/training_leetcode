using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class ContainerWater11Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,8,6,2,5,4,8,3,7]).Returns(49).SetName("Example 1");
        yield return new TestCaseData((int[])[1,1]).Returns(1).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] height)
    {
        var testObject = new ContainerWater11();
        return MeasureExecutionTime.Measure(() => testObject.MaxArea(height));
    }
}
