using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestGenerateParenthesis
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(1).Returns((string[]) ["()"]).SetName("SinglePair");
        yield return new TestCaseData(2).Returns((string[]) ["(())", "()()"]).SetName("TwoPairs");
        yield return new TestCaseData(3).Returns((string[]) ["((()))", "(()())", "(())()", "()(())", "()()()"]).SetName("ThreePairs");
        yield return new TestCaseData(0).Returns((string[]) []).SetName("ZeroPairs");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<string> TestSolution(int n)
    {
        var testObject = new GenerateParenthesis();
        return testObject.Solution(n);
    }
}
