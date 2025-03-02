using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestRemoveElement
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [3, 2, 2, 3], 3).Returns(2).SetName("Remove3s");
        yield return new TestCaseData((int[]) [0, 1, 2, 2, 3, 0, 4, 2], 2).Returns(5).SetName("Remove2s");
        yield return new TestCaseData((int[]) [1, 1, 1, 1], 1).Returns(0).SetName("RemoveAll1s");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 6).Returns(5).SetName("RemoveNonExistent6");
        yield return new TestCaseData((int[]) [], 1).Returns(0).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1).Returns(0).SetName("SingleElementArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums, int val)
    {
        var testObject = new RemoveElement();
        return testObject.Solution(nums, val);
    }
}
