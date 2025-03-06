using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestThreeSum
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4]).Returns(new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } }).SetName("Example1");
        yield return new TestCaseData((int[]) [0, 1, 1]).Returns(new List<IList<int>>()).SetName("Example2");
        yield return new TestCaseData((int[]) [-1, 0, 1]).Returns((IList<IList<int>>)[[-1, 0, 1]]).SetName("Example3");
        yield return new TestCaseData((int[]) [0, 0, 0]).Returns(new List<IList<int>> { new List<int> { 0, 0, 0 } }).SetName("Example4");
        yield return new TestCaseData((int[]) [1, 2, -2, -1]).Returns(new List<IList<int>>()).SetName("NoTriplets");
        yield return new TestCaseData((int[]) []).Returns(new List<IList<int>>()).SetName("EmptyInput");
        yield return new TestCaseData((int[]) [-2, 0, 1, 1, 2]).Returns((IList<IList<int>>) [[-2, 0, 2], [-2, 1, 1]]).SetName("MultipleTriplets");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] array)
    {
        var testObject = new ThreeSum();
        return MeasureExecutionTime.Measure(() => testObject.Solution(array));
    }
}
