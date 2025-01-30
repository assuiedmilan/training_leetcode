using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;
public class ValidPalindromeTests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("A man, a plan, a canal: Panama").Returns(true).SetName("valid palindrome");
        yield return new TestCaseData("race a car").Returns(false).SetName("not a palindrome");
        yield return new TestCaseData(" ").Returns(true).SetName("emptyString");
        yield return new TestCaseData("0P").Returns(false).SetName("0P");

    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s)
    {
        var testObject = new ValidPalindrome125();
        return MeasureExecutionTime.Measure(() => testObject.IsPalindrome(s));
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution2(string s)
    {
        var testObject = new ValidPalindrome125();
        return MeasureExecutionTime.Measure(() => testObject.IsPalindrome2(s));
    }
}
