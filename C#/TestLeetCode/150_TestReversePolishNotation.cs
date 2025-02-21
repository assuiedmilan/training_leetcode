using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestReversePolishNotation
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData([(string[]) ["2", "1", "+", "3", "*" ]]).Returns(9).SetName("Example case 1: (2 + 1) * 3 = 9");
        yield return new TestCaseData([(string[]) ["4", "13", "5", "/", "+" ]]).Returns(6).SetName("Example case 2: 4 + (13 / 5) = 6");
        yield return new TestCaseData([(string[]) ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" ]]).Returns(22).SetName("Complex case");
        yield return new TestCaseData([(string[]) ["3", "4", "+" ]]).Returns(7).SetName("Simple addition");
        yield return new TestCaseData([(string[]) ["10", "2", "-"]]).Returns(8).SetName("Simple subtraction");
        yield return new TestCaseData([(string[]) ["2", "3", "*" ]]).Returns(6).SetName("Simple multiplication");
        yield return new TestCaseData([(string[]) ["8", "4", "/" ]]).Returns(2).SetName("Simple division");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string[] tokens)
    {
        var testObject = new ReversePolishNotation();
        return testObject.Solution(tokens);
    }
}
