using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/linked-list-cycle/description/ */
public class LinkedListCycle
{
    public bool Solution(ReverseLinkedList.ListNode head)
    {
        if (head == null) return false;

        var power = 1;
        var lam = 1;
        var tortoise = head;
        var hare = head.next;

        while (hare != null)
        {
            if (tortoise == hare) return true;

            if (lam == power)
            {
                tortoise = hare;
                power *= 2;
                lam = 0;
            }
            hare = hare.next;
            lam++;
        }

        return false;
    }
}