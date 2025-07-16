using System;
using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;

namespace TestLeetCode.Gen;

public class ReorderList143Test {
    static IEnumerable<TestCaseData> TestCases()
    {
        var list1 = (int[]) [1, 2, 3, 4];
        var listNode1 = ListNodeTestsHelper.ArrayToLinkedList(list1);

        var list2 = (int[]) [1, 2, 3, 4, 5];
        var listNode2 = ListNodeTestsHelper.ArrayToLinkedList(list2);

        yield return new TestCaseData(listNode1).Returns((int[]) [1, 4, 2, 3]).SetName("Example 1");
        yield return new TestCaseData(listNode2).Returns((int[]) [1, 5, 2, 4, 3]).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestMergeTwoLists(ListNode head)
    {
        var testObject = new ReorderList143();
        var result = testObject.ReorderList(head);

        var resultArray = ListNodeTestsHelper.LinkedListToArray(result);
        for(int i = 0; i < resultArray.Length; i++)
        {
            Console.WriteLine($"resultArray[{i}] = {resultArray[i]}");
        }

        return resultArray;
    }
}
