using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestLongestSubstringWithoutRepeatingCharacters
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abcabcbb").Returns(3).SetName("Example1");
        yield return new TestCaseData("bbbbb").Returns(1).SetName("AllSameCharacters");
        yield return new TestCaseData("pwwkew").Returns(3).SetName("SubstringInMiddle");
        yield return new TestCaseData("").Returns(0).SetName("EmptyString");
        yield return new TestCaseData("a").Returns(1).SetName("SingleCharacter");
        yield return new TestCaseData("au").Returns(2).SetName("TwoUniqueCharacters");
        yield return new TestCaseData("dvdf").Returns(3).SetName("NonConsecutiveRepeats");
        yield return new TestCaseData("aabaab!bb").Returns(3).SetName("Non ASCII characters");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string s)
    {
        var testObject = new LongestSubstringWithoutRepeatingCharacters();
        return testObject.Solution(s);
    }
}
