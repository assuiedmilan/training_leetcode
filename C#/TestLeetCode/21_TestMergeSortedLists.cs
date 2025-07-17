namespace TestLeetCode;

using System.Collections.Generic;
using NUnit.Framework;
using LeetCode.Neetcode;

public class TestMergeSortedLists
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(
            (int[]) [1, 2, 4], 
            (int[]) [1, 3, 4]
        ).Returns((int[]) [1, 1, 2, 3, 4, 4]).SetName("BothNonEmpty");
        
        yield return new TestCaseData(
            (int[]) [], 
            (int[]) []
        ).Returns((int[]) []).SetName("BothEmpty");
        
        yield return new TestCaseData(
            (int[]) [], 
            (int[]) [0]
        ).Returns((int[]) [0]).SetName("FirstEmpty");
        
        yield return new TestCaseData(
            (int[]) [0], 
            (int[]) []
        ).Returns((int[]) [0]).SetName("SecondEmpty");
        
        yield return new TestCaseData(
            (int[]) [2, 5, 7], 
            (int[]) [1, 3, 6, 8]
        ).Returns((int[]) [1, 2, 3, 5, 6, 7, 8]).SetName("DifferentLengths");
        
        yield return new TestCaseData(
            (int[]) [1, 1, 2], 
            (int[]) [1, 1, 2]
        ).Returns((int[]) [1, 1, 1, 1, 2, 2]).SetName("Duplicates");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] l1Arr, int[] l2Arr)
    {
        var testObject = new MergeSortedLists();
        var l1 = ReverseLinkedList.ListNode.FromArray(l1Arr);
        var l2 = ReverseLinkedList.ListNode.FromArray(l2Arr);
        var result = testObject.Solution(l1, l2);
        return ReverseLinkedList.ListNode.ToArray(result);
    }
}
