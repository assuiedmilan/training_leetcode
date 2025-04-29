using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestContainerWithMostWater
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 8, 6, 2, 5, 4, 8, 3, 7]).Returns(49).SetName("Example1");
        yield return new TestCaseData((int[]) [1, 8, 1, 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]).Returns(20).SetName("Large flat container");
        yield return new TestCaseData((int[]) [1, 1]).Returns(1).SetName("MinimalHeight");
        yield return new TestCaseData((int[]) [4, 3, 2, 1, 4]).Returns(16).SetName("SymmetricalHeights");
        yield return new TestCaseData((int[]) [1, 2, 1]).Returns(2).SetName("SmallArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] height)
    {
        var testObject = new ContainerWithMostWater();
        return testObject.Solution(height);
    }
}
