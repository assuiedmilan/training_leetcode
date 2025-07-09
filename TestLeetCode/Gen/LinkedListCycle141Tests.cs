using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;

namespace TestLeetCode.Gen;

public class LinkedListCycle141Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(ListNodeUtilities.MakeList([3, 2, 0, -4], 1)).Returns(true).SetName("CycleAtIndex1");
        yield return new TestCaseData(ListNodeUtilities.MakeList([1, 2], 0)).Returns(true).SetName("CycleAtIndex0");
        yield return new TestCaseData(ListNodeUtilities.MakeList([1], -1)).Returns(false).SetName("SingleNodeNoCycle");
        yield return new TestCaseData(ListNodeUtilities.MakeList([1, 2, 3, 4, 5], -1)).Returns(false).SetName("NoCycle");
        yield return new TestCaseData(ListNodeUtilities.MakeList([], -1)).Returns(false).SetName("EmptyList");
        yield break;
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(ListNode head)
    {
        var testObject = new LinkedListCycle141();
        return testObject.HasCycle(head);
    }
}