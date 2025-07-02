namespace LeetCode.Gen;

// https://leetcode.com/problems/merge-two-sorted-lists/description/
// 21. Merge Two Sorted Lists

/*
 * You are given the heads of two sorted linked lists list1 and list2.
 * Merge the two lists into one sorted list.
 * The list should be made by splicing together the nodes of the first two lists.
 * Return the head of the merged linked list.
 *
 */

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode headResult = null;
        ListNode currentNode = null;

        while (list1 != null || list2 != null)
        {
            if (list1 != null && list2 != null)
            {
                int currentValue;
                if (list1.val <= list2.val)
                {
                    currentValue = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    currentValue = list2.val;
                    list2 = list2.next;
                }

                if (currentNode == null)
                    currentNode = new ListNode(currentValue);
                else
                {
                    currentNode.next = new ListNode(currentValue);
                    currentNode = currentNode.next;
                }
            }
            else if (list1 == null)
            {
                if (currentNode == null)
                    currentNode = new ListNode(list2.val);
                else
                {
                    currentNode.next = new ListNode(list2.val);
                    currentNode = currentNode.next;
                }

                list2 = list2.next;
            }
            else //list2 == null
            {
                if (currentNode == null)
                    currentNode = new ListNode(list1.val);
                else
                {
                    currentNode.next = new ListNode(list1.val);
                    currentNode = currentNode.next;
                }

                list1 = list1.next;
            }

            if(headResult == null)
                headResult = currentNode;
        }

        return headResult;
    }
}
