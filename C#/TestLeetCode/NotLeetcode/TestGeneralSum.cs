using System.Collections.Generic;
using LeetCode.NotLeetcode;
using NUnit.Framework;

namespace TestLeetCode.NotLeetcode;

public class TestGeneralSum
{
    static IEnumerable<TestCaseData> TestCases()
    {
        //2-Sum
        yield return new TestCaseData((int[]) [1, 2, 3, 5, 4, 1, 7, 2, 0], 5, 2).Returns((IList<int[]>) [[0, 5], [1, 4], [2, 3]]).SetName("MultipleCombinations");
        yield return new TestCaseData((int[]) [3, 1, 4, 1, 5], 6, 2).Returns((IList<int[]>) [[1, 5]]).SetName("SingleCombination");
        yield return new TestCaseData((int[]) [1, 1, 1, 1, 1], 2, 2).Returns((IList<int[]>) [[1, 1]]).SetName("AllSameValues");
        yield return new TestCaseData((int[]) [], 0, 2).Returns((IList<int[]>) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1, 2).Returns((IList<int[]>) []).SetName("SingleElementArray");
        
        //3-Sum
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4], 0, 3).Returns((IList<int[]>) [[-1, -1, 2], [-1, 0, 1]]).SetName("Example1");
        yield return new TestCaseData((int[]) [0, 1, 1], 0, 3).Returns((IList<int[]>) []).SetName("Example2");
        yield return new TestCaseData((int[]) [-1, 0, 1], 0, 3).Returns((IList<int[]>) [[-1, 0, 1]]).SetName("Example3");
        yield return new TestCaseData((int[]) [0, 0, 0], 0, 3).Returns((IList<int[]>) [[0, 0, 0]]).SetName("Example4");
        yield return new TestCaseData((int[]) [1, 2, -2, -1], 0, 3).Returns((IList<int[]>) []).SetName("NoTriplets");
        yield return new TestCaseData((int[]) [], 0, 3).Returns((IList<int[]>) []).SetName("EmptyInput");
        yield return new TestCaseData((int[]) [-2, 0, 1, 1, 2], 0, 3).Returns((IList<int[]>) [[-2, 0, 2], [-2, 1, 1]]).SetName("MultipleTriplets");
       
        //4-Sum
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4], -1, 4).Returns((IList<int[]>) [[-4, 0, 1, 2], [-1, -1, 0, 1]]).SetName("Example0");
        yield return new TestCaseData((int[]) [-1, 0, 1, 2, -1, -4], -1, 4).Returns((IList<int[]>) [[-4, 0, 1, 2], [-1, -1, 0, 1]]).SetName("Example1");
        yield return new TestCaseData((int[]) [1, 0, -1, 0, -2, 2], 0, 4).Returns((IList<int[]>) [[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]]).SetName("Example2");
        yield return new TestCaseData((int[]) [2, 2, 2, 2, 2], 8, 4).Returns((IList<int[]>) [[2, 2, 2, 2]]).SetName("AllSameValues");
        yield return new TestCaseData((int[]) [], 0, 4).Returns((IList<int[]>) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1, 4).Returns((IList<int[]>) []).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [1,-2,-5,-4,-3,3,3,5], -11, 4).Returns((IList<int[]>) [[-5,-4,-3,1]]).SetName("TestCase247");
        yield return new TestCaseData((int[]) [-1,0,-5,-2,-2,-4,0,1,-2], -9, 4).Returns((IList<int[]>) [[-5,-4,-1,1],[-5,-4,0,0],[-5,-2,-2,0],[-4,-2,-2,-1]]).SetName("TestCase247");

    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestSolution(int[] array, int target, int combinationSize)
    {
        var testObject = new GeneralSum();
        return testObject.Solution(array, target, combinationSize);
    }
}
