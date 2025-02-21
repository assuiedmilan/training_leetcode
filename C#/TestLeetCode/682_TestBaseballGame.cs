using System;
using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestBaseballGame
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData([(string[])["5", "2", "C", "D", "+"]]).Returns(30).SetName("Example case 1: 5 + 2 - 2 + 10 + 15 = 30");
        yield return new TestCaseData([(string[])["5", "-2", "4", "C", "D", "9", "+", "+"]]).Returns(27).SetName("Example case 2: 5 - 2 + 4 - 4 + 8 + 9 + 17 = 27");
        yield return new TestCaseData([(string[])["1"]]).Returns(1).SetName("Single score");
        yield return new TestCaseData([(string[])["10", "20", "30", "C", "D", "+"]]).Returns(130).SetName("Complex case");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string[] ops)
    {
        var testObject = new BaseballGame();
        return testObject.Solution(ops);
    }    
}
