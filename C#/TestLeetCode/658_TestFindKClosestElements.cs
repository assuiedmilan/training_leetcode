using System.Collections.Generic;
using System.Linq;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestFindKClosestElements
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 4, 3)
            .Returns((int[]) [1, 2, 3, 4])
            .SetName("KLessThanArrayLength_TargetInMiddle");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 2, 3)
            .Returns((int[]) [2, 3])
            .SetName("KLessThanArrayLength_TargetInMiddle_SmallerK");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 5, 3)
            .Returns((int[]) [1, 2, 3, 4, 5])
            .SetName("KEqualsArrayLength");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 3, 6)
            .Returns((int[]) [3, 4, 5])
            .SetName("TargetGreaterThanAllElements");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5], 3, -1)
            .Returns((int[]) [1, 2, 3])
            .SetName("TargetLessThanAllElements");
        yield return new TestCaseData((int[]) [1, 1, 1, 10, 10, 10], 3, 9)
            .Returns((int[]) [10, 10, 10])
            .SetName("AllCloseToTarget");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] arr, int k, int x)
    {
        var testObject = new FindKClosestElements();
        return testObject.Solution(arr, k, x).ToArray();
    }
}
