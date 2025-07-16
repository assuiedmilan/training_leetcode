using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class MinimumWindowSubstring76Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("ADOBECODEBANC", "ABC").Returns("BANC").SetName("Example 1");
        yield return new TestCaseData("a", "a").Returns("a").SetName("Example 2");
        yield return new TestCaseData("a", "aa").Returns("").SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string s, string t)
    {
        var testObject = new MinimumWindowSubstring76();
        return MeasureExecutionTime.Measure(() => testObject.MinWindow(s, t));
    }
}
