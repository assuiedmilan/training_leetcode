using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestTopKElements
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1, 1, 1, 2, 2, 3 }, 2)
            .Returns(new[] { 2, 1 })
            .SetName("Example case 1");
        yield return new TestCaseData(new[] { 1 }, 1)
            .Returns(new[] { 1 })
            .SetName("Example case 2");
        yield return new TestCaseData(new[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, 1)
            .Returns(new[] { 4 })
            .SetName("All elements are the same");
        yield return new TestCaseData(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 2)
            .Returns(new[] { 3, 4 })
            .SetName("Multiple frequencies");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums, int k)
    {
        var testObject = new TopKElements();
        return testObject.Solution(nums, k);
    }
}
