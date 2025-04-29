using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestRotateArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5, 6, 7], 3).Returns((int[]) [5, 6, 7, 1, 2, 3, 4]).SetName("Example1");
        yield return new TestCaseData((int[]) [-1, -100, 3, 99], 2).Returns((int[]) [3, 99, -1, -100]).SetName("Example2");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5, 6], 2).Returns((int[]) [5, 6, 1, 2, 3, 4]).SetName("Example3");
        yield return new TestCaseData((int[]) [1, 2], 3).Returns((int[]) [2, 1]).SetName("RotateMoreThanLength");
        yield return new TestCaseData((int[]) [], 0).Returns((int[]) []).SetName("EmptyArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] array, int k)
    {
        var testObject = new RotateArray();
        testObject.Solution(array, k);
        return array;
    }
}
