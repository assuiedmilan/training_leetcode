using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class LongestSubstringWithoutRepeatingCharacters3Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abcabcbb").Returns(3).SetName("Example 1");
        yield return new TestCaseData("bbbbb").Returns(1).SetName("Example 2");
        yield return new TestCaseData("pwwkew").Returns(3).SetName("Example 3");
        yield return new TestCaseData("aa").Returns(1).SetName("Example 4");
        yield return new TestCaseData("aab").Returns(2).SetName("Example 5");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string s)
    {
        var testObject = new LongestSubstringWithoutRepeatingCharacters3();
        return MeasureExecutionTime.Measure(() => testObject.LengthOfLongestSubstring(s));
    }
}
