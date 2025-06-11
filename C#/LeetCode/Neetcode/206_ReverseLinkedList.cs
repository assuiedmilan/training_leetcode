using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/reverse-linked-list/description/ */
public class ReverseLinkedList
{
    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }

    public ListNode Solution(ListNode head)
    {
        ListNode prev = null;
        var curr = head;
        while (curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}