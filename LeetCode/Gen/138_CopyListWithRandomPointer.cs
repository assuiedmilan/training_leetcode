using System;
using System.Collections.Generic;

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