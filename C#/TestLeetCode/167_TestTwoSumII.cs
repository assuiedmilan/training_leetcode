using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

// ReSharper disable once InconsistentNaming
public class TestTwoSumII
{
    static readonly TwoSumII k_TestObject = new();

    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [2, 7, 11, 15], 9)
            .Returns((int[]) [1, 2])
            .SetName("Example1");
        yield return new TestCaseData((int[]) [2, 3, 4], 6)
            .Returns((int[]) [1, 3])
            .SetName("Example2");
        yield return new TestCaseData((int[]) [-1, 0], -1)
            .Returns((int[]) [1, 2])
            .SetName("NegativeNumbers");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 4, 9, 56, 90], 8)
            .Returns((int[]) [4, 5])
            .SetName("DuplicateNumbers");
        yield return new TestCaseData((int[]) [1, 2], 3)
            .Returns((int[]) [1, 2])
            .SetName("TwoElements");
        yield return new TestCaseData((int[]) [-1, -1, 1, 1, 1, 1], -2)
            .Returns((int[]) [1, 2])
            .SetName("EqualElements");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] numbers, int target)
    {
        return k_TestObject.Solution(numbers, target);
    }
}
