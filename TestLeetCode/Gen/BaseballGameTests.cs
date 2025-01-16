using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class BaseballGameTests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData([(string[]) ["1", "C"]]).Returns(0).SetName("example1");
        yield return new TestCaseData([(string[]) ["5", "2", "C", "D", "+"]]).Returns(30).SetName("example2");
        yield return new TestCaseData([(string[]) ["5", "-2", "4", "C", "D", "9", "+", "+"]]).Returns(27).SetName("example3");
        yield return new TestCaseData([(string[]) ["1","C"]]).Returns(0).SetName("example4");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string[] operations)
    {
        var testObject = new BaseballGame682();
        return MeasureExecutionTime.Measure(() => testObject.Solution(operations));
    }
}
