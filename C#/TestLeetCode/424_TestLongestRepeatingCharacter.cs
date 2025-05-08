using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestLongestRepeatingCharacter
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("AABABBA", 1).Returns(4).SetName("ExampleCase");
        yield return new TestCaseData("ABAB", 2).Returns(4).SetName("AllCharactersReplaced");
        yield return new TestCaseData("AABABBA", 0).Returns(2).SetName("NoReplacementsAllowed");
        yield return new TestCaseData("AAAA", 2).Returns(4).SetName("AllSameCharacters");
        yield return new TestCaseData("ABCD", 1).Returns(2).SetName("NoRepeatingCharacters");
        yield return new TestCaseData("", 2).Returns(0).SetName("EmptyString");
        yield return new TestCaseData("A", 0).Returns(1).SetName("SingleCharacterString");
        yield return new TestCaseData("AAABBB", 2).Returns(5).SetName("TwoGroupsOfCharacters");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string s, int k)
    {
        var testObject = new LongestRepeatingCharacter();
        return testObject.Solution(s, k);
    }
}
