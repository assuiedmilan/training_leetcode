using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestPermutationsInString
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("ab", "eidbaooo").Returns(true).SetName("PermutationExists");
        yield return new TestCaseData("eidbaooo", "ab").Returns(false).SetName("PermutationIsInTheFirstString");
        yield return new TestCaseData("ab", "eidboaoo").Returns(false).SetName("NoPermutationExists");
        yield return new TestCaseData("adc", "dcda").Returns(true).SetName("PermutationExistsAtEnd");
        yield return new TestCaseData("a", "a").Returns(true).SetName("SingleCharacterMatch");
        yield return new TestCaseData("a", "b").Returns(false).SetName("SingleCharacterNoMatch");
        yield return new TestCaseData("abc", "bbbca").Returns(true).SetName("PermutationExistsInMiddle");
        yield return new TestCaseData("hello", "ooolleoooleh").Returns(false).SetName("TestCase58");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s1, string s2)
    {
        var testObject = new PermutationInString();
        return testObject.Solution(s1, s2);
    }
}
