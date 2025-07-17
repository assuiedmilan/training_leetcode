using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/merge-two-sorted-lists/description/ */
public class MergeSortedLists
{
    public ReverseLinkedList.ListNode Solution(ReverseLinkedList.ListNode l1, ReverseLinkedList.ListNode l2)
    {
        if (l1 == null && l2 == null) return null;
        ReverseLinkedList.ListNode head = new();
        var curr = head;

        while (l1 != null || l2 != null)
        {
            if (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    head.val = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    head.val = l2.val;
                    l2 = l2.next;
                }
                
            }

            else if (l1 != null)
            {
                head.val = l1.val;
                l1 = l1.next;
            }
            
            else 
            {
                head.val = l2.val;
                l2 = l2.next;
            }

            if (l1 != null || l2 != null)
            {
                head.next = new ReverseLinkedList.ListNode();
                head = head.next;
            }
        }
        return curr;

    }
}
