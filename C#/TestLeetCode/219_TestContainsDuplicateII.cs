using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestContainsDuplicateIi
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 1], 3).Returns(true).SetName("DuplicateWithinRange");
        yield return new TestCaseData((int[]) [1, 0, 1, 1], 1).Returns(true).SetName("DuplicateAtDistanceOne");
        yield return new TestCaseData((int[]) [1, 2, 3, 4], 2).Returns(false).SetName("NoDuplicateWithinRange");
        yield return new TestCaseData((int[]) [1], 1).Returns(false).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [], 0).Returns(false).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 5).Returns(false).SetName("AllUniqueElements");
        yield return new TestCaseData((int[]) [1, 2, 3, 1, 2, 3], 2).Returns(false).SetName("DuplicateOutsideRange");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(int[] nums, int k)
    {
        var testObject = new ContainsDuplicateIi();
        return testObject.Solution(nums, k);
    }
}
