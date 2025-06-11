using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Gen;

// https://leetcode.com/problems/reverse-linked-list/description/
// 206. Reverse Linked List

public class ReverseLinkedList206
{
    public ListNode ReverseList(ListNode head)
    {
        var list = new List<ListNode>();
        ListNode result = null;
        ListNode current = null;

        while (head != null)
        {
            list.Add(head);
            head = head.next;
        }

        while (list.Count > 0)
        {
            var listNode = list.ElementAt(list.Count - 1);
            list.RemoveAt(list.Count-1);

            if (result == null)
            {
                result = new ListNode(listNode.val);

                if (list.Count > 1)
                {
                    result.next = list.ElementAt(list.Count - 2);
                }

                current = result;
            }
            else
            {
                current.next = new ListNode(listNode.val);
                current = current.next;
            }
        }

        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
