using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Gen;

public class CopyListWithRandomPointer138 {

    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;

        var mapOldListToNewList = new Dictionary<Node, Node>();

        var currentOldNode = head;

        while (currentOldNode != null)
        {
            mapOldListToNewList.Add(currentOldNode, new Node(currentOldNode.val));
            currentOldNode = currentOldNode.next;
        }

        currentOldNode = head;
        while (currentOldNode != null)
        {
            if (currentOldNode.next == null)
            {
                mapOldListToNewList[currentOldNode].next = null;
            }
            else
            {
                mapOldListToNewList[currentOldNode].next = mapOldListToNewList[currentOldNode.next];
            }

            if (currentOldNode.random == null)
            {
                mapOldListToNewList[currentOldNode].random = null;
            }
            else
            {
                mapOldListToNewList[currentOldNode].random = mapOldListToNewList[currentOldNode.random];
            }

            currentOldNode = currentOldNode.next;
        }

        mapOldListToNewList.TryGetValue(head, out var newHeadNode);

        return newHeadNode;
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var head = new ListNode(0); // Dummy head node
        var list1 = l1;
        var list2 = l2;

        var current = head; //on va pouvoir utiliser head.next pour retourner le resultat

        int resultSum = 0;
        while (list1 != null || list2 != null)
        {
            var val1 = list1?.val ?? 0; //si la liste est null, on prend 0, vu qu'on commence avec les unités, le reste est good si on met 0
            var val2 = list2?.val ?? 0;

            var sum = resultSum + val1 + val2;
            resultSum = sum / 10; // mettons "7 / 10" donne 0 pour la division en C# pour un entier. On veut garder le "surplus" pour la prochaine node
            current.next = new ListNode(sum % 10); // on garde la partie unité pour la node et on l'ajoute
            current = current.next;

            if (list1 != null)
                list1 = list1.next;

            if (list2 != null)
                list2 = list2.next;
        }

        if (resultSum > 0)
        {
            current.next = new ListNode(resultSum);
        }

        return head.next;
    }
}

/*
 // Pour les tests
 var n1 = new Node(7);
        var n2 = new Node(13);
        var n3 = new Node(11);
        var n4 = new Node(10);
        var n5 = new Node(1);
        n1.next = n2;
        n2.next = n3;
        n2.random = n1;
        n3.next = n4;
        n3.random = n5;
        n4.next = n5;
        n4.random = n3;
        n5.random = n1;
 */