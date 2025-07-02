using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class MergeTwoSortedListsTests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1, 2, 4], (int[])[1, 3, 4]).Returns((int[])[1,1,2,3,4,4]).SetName("Example 1");
        yield return new TestCaseData((int[])[], (int[])[]).Returns((int[])[]).SetName("Example 2");
        yield return new TestCaseData((int[])[], (int[])[0]).Returns((int[])[0]).SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestMergeTwoLists(int[] list1Array, int[] list2Array)
    {
        var list1 = ListNodeTestsHelper.ArrayToLinkedList(list1Array);
        var list2 = ListNodeTestsHelper.ArrayToLinkedList(list2Array);

        var testObject = new MergeTwoSortedLists();
        var mergedList = testObject.MergeTwoLists(list1, list2);

        return ListNodeTestsHelper.LinkedListToArray(mergedList);
    }
}

public static class ListNodeTestsHelper
{
    public static ListNode ArrayToLinkedList(int[] values)
    {
        if (values == null || values.Length == 0) return null;

        var dummy = new ListNode(0);
        var current = dummy;

        foreach (var value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }

        return dummy.next;
    }

    public static int[] LinkedListToArray(ListNode head)
    {
        var result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result.ToArray();
    }
}
