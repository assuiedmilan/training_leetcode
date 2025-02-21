using System;
using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestContainsDuplicate
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [ 1, 2, 3, 3 ]).Returns(true).SetName("Example case with duplicates");
        yield return new TestCaseData((int[]) [ 1, 2, 3, 4 ]).Returns(false).SetName("Example case without duplicates");
        yield return new TestCaseData((int[]) [ 1 ]).Returns(false).SetName("Single element");
        yield return new TestCaseData(Array.Empty<int>()).Returns(false).SetName("Empty array");
        yield return new TestCaseData((int[]) [ 1, 1, 1, 1 ]).Returns(true).SetName("All elements are the same");
        yield return new TestCaseData((int[]) [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]).Returns(false).SetName("All unique elements");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(int[] nums)
    {
        var testObject = new ContainsDuplicate();
        return MeasureExecutionTime.Measure(() => testObject.Solution(nums));
    }
}
