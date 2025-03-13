using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestFourSum
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4], -1).Returns((IList<int[]>) [[-4, 0, 1, 2], [-1, -1, 0, 1]]).SetName("Example0");
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4], -1).Returns((IList<int[]>) [[-4, 0, 1, 2], [-1, -1, 0, 1]]).SetName("Example1");
        yield return new TestCaseData((int[]) [1, 0, -1, 0, -2, 2], 0).Returns((IList<int[]>) [[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]]).SetName("Example2");
        yield return new TestCaseData((int[]) [2, 2, 2, 2, 2], 8).Returns((IList<int[]>) [[2, 2, 2, 2]]).SetName("AllSameValues");
        yield return new TestCaseData((int[]) [], 0).Returns((IList<int[]>) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1).Returns((IList<int[]>) []).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [1,-2,-5,-4,-3,3,3,5], -11).Returns((IList<int[]>) [[-5,-4,-3,1]]).SetName("TestCase247");
        yield return new TestCaseData((int[]) [-1,0,-5,-2,-2,-4,0,1,-2], -9).Returns((IList<int[]>) [[-5,-4,-1,1],[-5,-4,0,0],[-5,-2,-2,0],[-4,-2,-2,-1]]).SetName("TestCase247");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] array, int target)
    {
        var testObject = new FourSum();
        return MeasureExecutionTime.Measure(() => testObject.Solution(array, target));
    }
}
