using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestRemoveDuplicatesFromSortedArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 1, 2]).Returns(2).SetName("DuplicatesPresent");
        yield return new TestCaseData((int[]) [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]).Returns(5).SetName("MultipleDuplicates");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5]).Returns(5).SetName("NoDuplicates");
        yield return new TestCaseData((int[]) [1]).Returns(1).SetName("SingleElementArray");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new RemoveDuplicatesFromSortedArray();
        return testObject.Solution(nums);
    }
}
