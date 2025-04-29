using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestSumOfTwoIntegers
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(234, 684).Returns(918).SetName("Custom");
        yield return new TestCaseData(1, 2).Returns(3).SetName("PositiveNumbers");
        yield return new TestCaseData(-1, -2).Returns(-3).SetName("NegativeNumbers");
        yield return new TestCaseData(0, 0).Returns(0).SetName("BothZero");
        yield return new TestCaseData(0, 5).Returns(5).SetName("OneZeroOnePositive");
        yield return new TestCaseData(-5, 5).Returns(0).SetName("NegativeAndPositive");
        yield return new TestCaseData(int.MaxValue, 0).Returns(int.MaxValue).SetName("MaxValueAndZero");
        yield return new TestCaseData(int.MinValue, 0).Returns(int.MinValue).SetName("MinValueAndZero");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int a, int b)
    {
        var testObject = new SumOfTwoIntegers();
        return testObject.Solution(a, b);
    }
}
