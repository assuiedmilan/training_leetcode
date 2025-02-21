using System;
using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestContiguousArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 0, 1 }).Returns(2).SetName("Base case two values");
        yield return new TestCaseData(new[] { 0, 1, 0 }).Returns(2).SetName("Base case three values");
        yield return new TestCaseData(new[] { 0, 1, 0, 1, 1, 0, 1 }).Returns(6).SetName("Odd number of contiguous 0/1");
        yield return new TestCaseData(new[] { 0, 1, 0, 1, 1, 0 }).Returns(6).SetName("Even number of contiguous 0/1");
        yield return new TestCaseData(new[] { 0, 0, 1, 0, 1, 1, 0, 0 }).Returns(6).SetName("Longest subarray in the middle");
        yield return new TestCaseData(new[] { 0, 0, 1, 1, 0, 1, 1 }).Returns(6).SetName("Longest subarray at the end with even length");
        yield return new TestCaseData(new[] { 0, 1, 0, 1, 1, 0, 1 }).Returns(6).SetName("Longest subarray at the end with odd length");
        yield return new TestCaseData(new[] { 1, 0, 1, 0, 0, 1, 1 }).Returns(6).SetName("Longest subarray at the beginning starting with 1");
        yield return new TestCaseData(new[] { 1, 1, 0, 1, 0, 0, 1 }).Returns(6).SetName("Longest subarray in the middle starting with 1");
        yield return new TestCaseData(new[] { 1, 1, 1, 0, 1, 0, 1 }).Returns(4).SetName("Longest subarray at the end starting with 1");
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new ContiguousArray();
        return MeasureExecutionTime.Measure(() => testObject.Solution(nums));
    }
}