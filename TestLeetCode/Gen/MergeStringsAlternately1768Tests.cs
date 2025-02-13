using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;
public class MergeStringsAlternately1768Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abc", "pqr").Returns("apbqcr").SetName("Example 1");
        yield return new TestCaseData("ab", "pqrs").Returns("apbqrs").SetName("Example 2");
        yield return new TestCaseData("abcd", "pq").Returns("apbqcd").SetName("Example 3");
        yield return new TestCaseData("cdf", "a").Returns("cadf").SetName("Example 4");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string word1, string word2)
    {
        var testObject = new MergeStringsAlternately1768();
        return MeasureExecutionTime.Measure(() => testObject.MergeAlternately(word1, word2));
    }
}
