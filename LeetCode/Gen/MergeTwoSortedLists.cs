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
            if (list1 == null)
                currentNode = CreateCurrentNode(ref list2, currentNode);
            else if(list2 == null)
                currentNode = CreateCurrentNode(ref list1, currentNode);
            else
            {
                if (list1.val <= list2.val)
                    currentNode = CreateCurrentNode(ref list1, currentNode);
                else
                    currentNode = CreateCurrentNode(ref list2, currentNode);
            }

            headResult ??= currentNode;
        }

        return headResult;
    }

    static ListNode CreateCurrentNode(ref ListNode list, ListNode currentNode)
    {
        if (currentNode == null)
            currentNode = new ListNode(list.val);
        else
        {
            currentNode.next = new ListNode(list.val);
            currentNode = currentNode.next;
        }

        list = list.next;
        return currentNode;
    }
}
