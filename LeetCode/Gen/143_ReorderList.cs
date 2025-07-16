using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Gen;

public class ReorderList143 {
    public ListNode ReorderList(ListNode head)
    {
        var array = new List<ListNode>();
        var current = head;

        while (current != null)
        {
            array.Add(current);
            current = current.next;
        }

        if (array.Count == 0)
            return null;

        ListNode resultHead = null;
        ListNode listResult = null;
        var takeHead = true;

        var indexStart = 0;
        var indexEnd = array.Count - 1;

        for (int i = 0; i < array.Count; i++)
        {
            ListNode currentNode;
            if (takeHead)
            {
                currentNode = array.ElementAt(indexStart);
                if (resultHead == null)
                {
                    listResult = currentNode;
                    resultHead = listResult;
                }
                else
                {
                    listResult.next = currentNode;
                    listResult = listResult.next;
                }

                indexStart++;
            }
            else
            {
                currentNode = array.ElementAt(indexEnd);
                listResult.next = currentNode;

                listResult = listResult.next;
                indexEnd--;
            }

            takeHead = !takeHead;
        }

        listResult.next = null;

        head = resultHead;

        return head;
    }
}
