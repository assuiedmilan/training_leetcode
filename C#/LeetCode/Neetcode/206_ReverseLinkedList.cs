using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/reverse-linked-list/description/ */
public class ReverseLinkedList
{
    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
        
        public static ListNode FromArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            var dummy = new ListNode();
            var current = dummy;
            foreach (var val in arr)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummy.next;
        }
        
        public static int[] ToArray(ListNode head)
        {
            var result = new List<int>();
            var current = head;
            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }
            return result.ToArray();
        }
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