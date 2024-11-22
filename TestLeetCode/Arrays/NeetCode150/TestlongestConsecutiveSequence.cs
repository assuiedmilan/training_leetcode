using System.Collections.Generic;
using LeetCode.Arrays.NeetCode150;
using NUnit.Framework;

namespace TestLeetCode.Arrays.NeetCode150;

public class TestLongestConsecutiveSequence
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 100, 4, 200, 1, 3, 2 }).Returns(4).SetName("Example case");
        yield return new TestCaseData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }).Returns(9).SetName("Long sequence with duplicates");
        yield return new TestCaseData(new[] { 1, 2, 0, 1 }).Returns(3).SetName("Short sequence with duplicates");
        yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }).Returns(5).SetName("Already consecutive sequence");
        yield return new TestCaseData(new[] { 10, 5, 12, 3, 55, 30, 4, 11, 2 }).Returns(4).SetName("Mixed sequence");
        yield return new TestCaseData(new[] { 1 }).Returns(1).SetName("Single element");
        yield return new TestCaseData(new int[] { }).Returns(0).SetName("Empty array");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new LongestConsecutiveSequence();
        return MeasureExecutionTime.Measure(() => testObject.Solution(nums));
    }
}
