using System.Collections.Generic;
using NUnit.Framework;
using LeetCode.Neetcode;

namespace TestLeetCode;

public class TestReorderList
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(MakeList([3, 2, 0, -4], 1)).Returns(true).SetName("CycleAtIndex1");
        yield return new TestCaseData(MakeList([1, 2], 0)).Returns(true).SetName("CycleAtIndex0");
        yield return new TestCaseData(MakeList([1], -1)).Returns(false).SetName("SingleNodeNoCycle");
        yield return new TestCaseData(MakeList([1, 2, 3, 4, 5], -1)).Returns(false).SetName("NoCycle");
        yield return new TestCaseData(MakeList([], -1)).Returns(false).SetName("EmptyList");
        yield break;

        ReverseLinkedList.ListNode MakeList(int[] values, int pos)
        {
            var nodes = new List<ReverseLinkedList.ListNode>();
            foreach (var v in values) nodes.Add(new ReverseLinkedList.ListNode(v));
            for (var i = 0; i < nodes.Count - 1; i++) nodes[i].next = nodes[i + 1];
            if (pos >= 0 && pos < nodes.Count)
                nodes[^1].next = nodes[pos];
            return nodes.Count > 0 ? nodes[0] : null;
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(ReverseLinkedList.ListNode head)
    {
        var testObject = new ReorderList();
        testObject.Solution(head);
        return true;
    }
}
