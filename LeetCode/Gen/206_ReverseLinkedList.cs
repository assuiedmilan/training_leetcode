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

public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}

public static class ListNodeUtilities
{
    public static ListNode MakeList(int[] values, int pos)
    {
        var nodes = new List<ListNode>();
        foreach (var v in values) nodes.Add(new ListNode(v));
        for (var i = 0; i < nodes.Count - 1; i++) nodes[i].next = nodes[i + 1];
        if (pos >= 0 && pos < nodes.Count)
            nodes[^1].next = nodes[pos];
        return nodes.Count > 0 ? nodes[0] : null;
    }
}


