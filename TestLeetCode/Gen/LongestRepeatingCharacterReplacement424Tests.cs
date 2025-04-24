using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class LongestRepeatingCharacterReplacement424Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("ABAB", 2).Returns(4).SetName("Example 1");
        yield return new TestCaseData("AABABBA", 1).Returns(4).SetName("Example 2");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string s, int k)
    {
        var testObject = new LongestRepeatingCharacterReplacement424();
        return MeasureExecutionTime.Measure(() => testObject.CharacterReplacement(s, k));
    }
}
