using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestMinimumWindowSubstring
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("ADOBECODEBANC", "ABC").Returns("BANC").SetName("BasicExample");
        yield return new TestCaseData("a", "a").Returns("a").SetName("SingleCharMatch");
        yield return new TestCaseData("a", "aa").Returns("").SetName("NotEnoughChars");
        yield return new TestCaseData("ab", "b").Returns("b").SetName("SecondCharMatch");
        yield return new TestCaseData("ab", "a").Returns("a").SetName("FirstCharMatch");
        yield return new TestCaseData("ab", "c").Returns("").SetName("NoMatch");
        yield return new TestCaseData("abcabdebac", "cda").Returns("cabd").SetName("MultiplePossibleWindows");
        yield return new TestCaseData("a", "b").Returns("").SetName("TestCase192");
        yield return new TestCaseData("cabwefgewcwaefgcf", "cae").Returns("cwae").SetName("TestCase208");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string s, string t)
    {
        var testObject = new MinimumWindowSubstring();
        return testObject.Solution(s, t);
    }
}
