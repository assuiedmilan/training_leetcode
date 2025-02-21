using System.Collections.Generic;
using LeetCode.Others;
using NUnit.Framework;

namespace TestLeetCode;

public class TestLongestPalindrome
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("babad").Returns("bab").SetName("Example1");
        yield return new TestCaseData("cbbd").Returns("bb").SetName("Example2");
        yield return new TestCaseData("a").Returns("a").SetName("SingleCharacter");
        yield return new TestCaseData("ac").Returns("a").SetName("TwoDifferentCharacters");
        yield return new TestCaseData("bb").Returns("bb").SetName("TwoSameCharacters");
        yield return new TestCaseData("abcba").Returns("abcba").SetName("OddLengthPalindrome");
        yield return new TestCaseData("abccba").Returns("abccba").SetName("EvenLengthPalindrome");
        yield return new TestCaseData("aabbcc").Returns("aa").SetName("MultiplePairs");
        yield return new TestCaseData("racecar").Returns("racecar").SetName("FullStringPalindrome");
        yield return new TestCaseData("abacdfgdcaba").Returns("aba").SetName("MixedCharacters");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string s)
    {
        var solution = new LongestPalindrome();
        return solution.Solution(s);
    }
}