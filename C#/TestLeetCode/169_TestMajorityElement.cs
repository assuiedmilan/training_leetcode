namespace TestLeetCode;

using System.Collections.Generic;
using NUnit.Framework;
using LeetCode.Neetcode;

public class TestMajorityElement
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [3, 2, 3]).Returns(3).SetName("MajorityAtStart");
        yield return new TestCaseData((int[]) [2, 2, 1, 1, 1, 2, 2]).Returns(2).SetName("MajoritySpread");
        yield return new TestCaseData((int[]) [1]).Returns(1).SetName("SingleElement");
        yield return new TestCaseData((int[]) [4, 4, 4, 2, 2, 4, 2]).Returns(4).SetName("MajorityWithDuplicates");
        yield return new TestCaseData((int[]) [5, 5, 5, 5, 5]).Returns(5).SetName("AllSame");
        yield return new TestCaseData((int[]) [6, 7, 6, 6, 7, 6, 7, 6]).Returns(6).SetName("AlternatingMajority");
        yield return new TestCaseData((int[]) [0, 0, 1, 1, 0]).Returns(0).SetName("ZeroAndOne");
        yield return new TestCaseData((int[]) [-1, -1, -1, 2, 2, -1]).Returns(-1).SetName("NegativeMajority");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new MajorityElement();
        return testObject.Solution(nums);
    }
}
