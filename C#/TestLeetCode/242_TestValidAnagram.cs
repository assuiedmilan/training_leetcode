using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestValidAnagram
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("anagram", "nagaram")
            .Returns(true)
            .SetName("Example case 1: anagram and nagaram");
        yield return new TestCaseData("rat", "car")
            .Returns(false)
            .SetName("Example case 2: rat and car");
        yield return new TestCaseData("a", "a")
            .Returns(true)
            .SetName("Single character same");
        yield return new TestCaseData("a", "b")
            .Returns(false)
            .SetName("Single character different");
        yield return new TestCaseData("ab", "ba")
            .Returns(true)
            .SetName("Two characters same");
        yield return new TestCaseData("ab", "bc")
            .Returns(false)
            .SetName("Two characters different");
        yield return new TestCaseData("abc", "cba")
            .Returns(true)
            .SetName("Three characters same");
        yield return new TestCaseData("abc", "def")
            .Returns(false)
            .SetName("Three characters different");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s, string t)
    {
        var testObject = new ValidAnagram();
        return testObject.Solution(s, t);
    }
}
