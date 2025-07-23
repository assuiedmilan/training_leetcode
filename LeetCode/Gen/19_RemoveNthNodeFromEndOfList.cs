namespace LeetCode.Gen;

public class RemoveNthNodeFromEndOfList19 {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null || head.next == null)
            return null;

        ListNode fast = head;
        ListNode slow = head;
        int f = 0;
        int s = 0;

        while (fast != null)
        {
            fast = fast.next;
            f++;

            if (f - s > n+1)
            {
                s++;
                slow = slow.next;
            }
        }

        if(f == n)
            return slow.next;

        slow.next = slow.next.next;
        return head;
    }
}
