using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestFirstMissingPositiveInteger
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 0]).Returns(3).SetName("MissingThree");
        yield return new TestCaseData((int[]) [3, 4, -1, 1]).Returns(2).SetName("MissingTwo");
        yield return new TestCaseData((int[]) [7, 8, 9, 11, 12]).Returns(1).SetName("MissingOne");
        yield return new TestCaseData((int[]) [1]).Returns(2).SetName("SingleOne");
        yield return new TestCaseData((int[]) [2]).Returns(1).SetName("SingleTwo");
        yield return new TestCaseData((int[]) []).Returns(1).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1, 1]).Returns(2).SetName("DuplicateOnes");
        yield return new TestCaseData((int[]) [2, 2, 2, 2]).Returns(1).SetName("AllTwos");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5]).Returns(6).SetName("ConsecutiveFromOne");
        yield return new TestCaseData((int[]) [-1, -2, -3]).Returns(1).SetName("AllNegatives");
        yield return new TestCaseData((int[]) [4, 5, -1, 2, 1]).Returns(3).SetName("Custom");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new FirstMissingPositiveInteger();
        return testObject.Solution(nums);
    }
}
