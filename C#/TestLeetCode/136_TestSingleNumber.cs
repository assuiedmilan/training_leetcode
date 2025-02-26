using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestSingleNumber
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [2, 2, 1]).Returns(1).SetName("SingleNumberAtEnd");
        yield return new TestCaseData((int[]) [4, 1, 2, 1, 2]).Returns(4).SetName("SingleNumberAtStart");
        yield return new TestCaseData((int[]) [1]).Returns(1).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [int.MaxValue, int.MinValue, int.MaxValue]).Returns(int.MinValue).SetName("MaxMinValues");
        yield return new TestCaseData((int[]) [-1, -1, -2]).Returns(-2).SetName("NegativeNumbers");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] array)
    {
        var testObject = new SingleNumber();
        return MeasureExecutionTime.Measure(() => testObject.Solution(array));
    }
}
