using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestConcatenationOfArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 1]).Returns((int[]) [1, 2, 1, 1, 2, 1]).SetName("SimpleArray");
        yield return new TestCaseData((int[]) [1, 3, 2, 1]).Returns((int[]) [1, 3, 2, 1, 1, 3, 2, 1]).SetName("LongerArray");
        yield return new TestCaseData((int[]) []).Returns((int[]) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [5]).Returns((int[]) [5, 5]).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [0, 0, 0]).Returns((int[]) [0, 0, 0, 0, 0, 0]).SetName("AllZeros");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums)
    {
        var testObject = new ConcatenationOfArray();
        return testObject.Solution(nums);
    }
}
