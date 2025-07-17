using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/reorder-list/description/ */
public class ReorderList
{
    public ReverseLinkedList.ListNode Solution(ReverseLinkedList.ListNode head)
    {
        var reverser = new ReverseLinkedList();
        var reversedList = reverser.Solution(head);
        
        return head;
    }
}