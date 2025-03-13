using System.Collections.Generic;
using LeetCode.NotLeetcode;
using NUnit.Framework;

namespace TestLeetCode.NotLeetcode;

public class TestGeneralSum
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 5, 2).Returns((IList<int[]>) [[1, 4], [2, 3]]).SetName("MultipleCombinations");
        yield return new TestCaseData((int[]) [3, 1, 4, 1, 5], 6, 2).Returns((IList<int[]>) [[1, 5]]).SetName("SingleCombination");
        yield return new TestCaseData((int[]) [1, 1, 1, 1, 1], 2, 2).Returns((IList<int[]>) [[1, 1]]).SetName("AllSameValues");
        yield return new TestCaseData((int[]) [], 0, 2).Returns((IList<int[]>) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1, 2).Returns((IList<int[]>) []).SetName("SingleElementArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] array, int target, int combinationSize)
    {
        var testObject = new GeneralSum();
        return testObject.Solution(array, target, combinationSize);
    }
}
