using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestAddBinary
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("11", "1").Returns("100").SetName("SimpleAddition");
        yield return new TestCaseData("1010", "1011").Returns("10101").SetName("DifferentLengths");
        yield return new TestCaseData("0", "0").Returns("0").SetName("BothZero");
        yield return new TestCaseData("1", "0").Returns("1").SetName("OneZero");
        yield return new TestCaseData("1111", "1111").Returns("11110").SetName("CarryOver");
        yield return new TestCaseData("0", "1111").Returns("1111").SetName("OneZeroOneNonZero");
        yield return new TestCaseData("100000", "1").Returns("100001").SetName("LargeDifferenceInLength");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string a, string b)
    {
        var testObject = new AddBinary();
        return testObject.Solution(a, b);
    }
}
