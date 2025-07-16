using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class PermutationInString567Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("ab", "eidbaooo").Returns(true).SetName("Example 1");
        yield return new TestCaseData("ab", "s2").Returns(false).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s1, string s2)
    {
        var testObject = new PermutationInString567();
        return MeasureExecutionTime.Measure(() => testObject.CheckInclusion(s1, s2));
    }
}
