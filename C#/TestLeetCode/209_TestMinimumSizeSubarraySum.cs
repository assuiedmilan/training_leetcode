using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestMinimumSizeSubarraySum
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(7, (int[]) [2, 3, 1, 2, 4, 3]).Returns(2).SetName("SubarrayAtStart");
        yield return new TestCaseData(4, (int[]) [1, 4, 4]).Returns(1).SetName("SingleElementSubarray");
        yield return new TestCaseData(11, (int[]) [1, 1, 1, 1, 1, 1, 1, 1]).Returns(0).SetName("NoValidSubarray");
        yield return new TestCaseData(15, (int[]) [5, 1, 3, 5, 10, 7, 4, 9, 2, 8]).Returns(2).SetName("SubarrayInMiddle");
        yield return new TestCaseData(8, (int[]) [3, 3, 3, 3, 3]).Returns(3).SetName("MultipleEqualElements");
        yield return new TestCaseData(1, (int[]) [1]).Returns(1).SetName("SingleElementArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int target, int[] nums)
    {
        var testObject = new MinimumSizeSubarraySum();
        return testObject.Solution(target, nums);
    }
}
