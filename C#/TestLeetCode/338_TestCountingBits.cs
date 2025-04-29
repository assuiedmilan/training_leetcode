using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestCountingBits
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(2).Returns((int[]) [0, 1, 1]).SetName("InputTwo");
        yield return new TestCaseData(5).Returns((int[]) [0, 1, 1, 2, 1, 2]).SetName("InputFive");
        yield return new TestCaseData(0).Returns((int[]) [0]).SetName("InputZero");
        yield return new TestCaseData(1).Returns((int[]) [0, 1]).SetName("InputOne");
        yield return new TestCaseData(10).Returns((int[]) [0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2]).SetName("InputTen");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int n)
    {
        var testObject = new CountingBits();
        return testObject.Solution(n);
    }
}
