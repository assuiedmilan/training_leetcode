using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;
public class ValidPalindrome2Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("aba").Returns(true).SetName("valid palindrome");
        yield return new TestCaseData("abca").Returns(true).SetName("delete1");
        yield return new TestCaseData("abc").Returns(false).SetName("not valid");
        yield return new TestCaseData("cbbcc").Returns(true).SetName("valid");
        yield return new TestCaseData("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga").Returns(true).SetName("valid2");
        yield return new TestCaseData("lcuppucul").Returns(true).SetName("valid3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s)
    {
        var testObject = new ValidPalindrome680();
        return MeasureExecutionTime.Measure(() => testObject.ValidPalindrome(s));
    }
}
