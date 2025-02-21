using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestValidParenthesis
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("()").Returns(true).SetName("Valid simple parentheses");
        yield return new TestCaseData("()[]{}").Returns(true).SetName("Valid mixed parentheses");
        yield return new TestCaseData("(]").Returns(false).SetName("Invalid mixed parentheses");
        yield return new TestCaseData("([)]").Returns(false).SetName("Invalid nested parentheses");
        yield return new TestCaseData("{[]}").Returns(true).SetName("Valid nested parentheses");
        yield return new TestCaseData("(").Returns(false).SetName("Single open parenthesis");
        yield return new TestCaseData(")").Returns(false).SetName("Single close parenthesis");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s)
    {
        var testObject = new ValidParenthesis();
        return testObject.Solution(s);
    }    
}
