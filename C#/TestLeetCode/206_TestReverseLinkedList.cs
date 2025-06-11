using System;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestReverseLinkedList
{

    [Test]
    public void TestSolution()
    {
        var testObject = new ReverseLinkedList();
        
        var five = new ReverseLinkedList.ListNode(5);
        var four = new ReverseLinkedList.ListNode(4, five);
        var three = new ReverseLinkedList.ListNode(3, four);
        var two = new ReverseLinkedList.ListNode(2, three);
        var one = new ReverseLinkedList.ListNode(1, two);
        var reversed = testObject.Solution(one);
        
        Assert.That(reversed, Is.SameAs(five));
        Assert.That(five.next, Is.SameAs(four));
        Assert.That(four.next, Is.SameAs(three));
        Assert.That(three.next, Is.SameAs(two));
        Assert.That(two.next, Is.SameAs(one));
        Assert.That(one.next, Is.Null);
    }
    
    [Test]
    public void TestOneNode()
    {
        var testObject = new ReverseLinkedList();
        
        var five = new ReverseLinkedList.ListNode(5);
        var reversed = testObject.Solution(five);
        
        Assert.That(reversed, Is.SameAs(five));
        Assert.That(five.next, Is.Null);
    }
    
    [Test]
    public void TestSolutionTwoNodes()
    {
        var testObject = new ReverseLinkedList();
        
        var five = new ReverseLinkedList.ListNode(5);
        var four = new ReverseLinkedList.ListNode(4, five);
        var reversed = testObject.Solution(four);
        
        Assert.That(reversed, Is.SameAs(five));
        Assert.That(five.next, Is.SameAs(four));
        Assert.That(four.next, Is.Null);
    }
    
    [Test]
    public void TestSolutionNull()
    {
        var testObject = new ReverseLinkedList();
        testObject.Solution(null);
    }
}
