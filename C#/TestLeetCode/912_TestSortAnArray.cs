using System;
using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestSortArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [5, 2, 3, 1]).Returns((int[]) [1, 2, 3, 5]).SetName("UnsortedArray");
        yield return new TestCaseData((int[]) [5, 1, 1, 2, 0, 0]).Returns((int[]) [0, 0, 1, 1, 2, 5]).SetName("ArrayWithDuplicates");
        yield return new TestCaseData((int[]) []).Returns((int[]) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1]).Returns((int[]) [1]).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [int.MaxValue, int.MinValue, 0]).Returns((int[]) [int.MinValue, 0, int.MaxValue]).SetName("ArrayWithExtremeValues");
        yield return new TestCaseData((int[]) [-1, -2, -3, -4, -5]).Returns((int[]) [-5, -4, -3, -2, -1]).SetName("NegativeNumbers");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums)
    {
        var testObject = new SortArray();
        return testObject.Solution(nums);
    }
}
