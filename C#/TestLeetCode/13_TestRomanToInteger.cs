using System.Collections.Generic;
using LeetCode.Others;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestRomanToInteger
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("I").Returns(1).SetName("SingleChar");
        yield return new TestCaseData("II").Returns(2).SetName("TwoCharsTwoValue");
        yield return new TestCaseData("IV").Returns(4).SetName("TwoCharsOneValue");
        yield return new TestCaseData("CDI").Returns(401).SetName("StartsWithTwoCharsEndsWithSingle");
        yield return new TestCaseData("CDIV").Returns(404).SetName("StartsWithTwoCharsEndsWithTwoChars");
        yield return new TestCaseData("MIV").Returns(1004).SetName("EndsWithTwoChars");
        yield return new TestCaseData("MCDI").Returns(1401).SetName("HaveTwoCharsInMiddle");
        yield return new TestCaseData("III").Returns(3).SetName("ThreeCharsThreeValue");
        yield return new TestCaseData("IV").Returns(4).SetName("TwoCharsOneValue");
        yield return new TestCaseData("IX").Returns(9).SetName("TwoCharsNineValue");
        yield return new TestCaseData("CDI").Returns(401).SetName("StartsWithTwoCharsEndsWithSingle");
        yield return new TestCaseData("LVIII").Returns(58).SetName("FiveCharsFiftyEightValue");
        yield return new TestCaseData("MCMXCIV").Returns(1994).SetName("SevenCharsNineteenNinetyFourValue");
        yield return new TestCaseData("MMXXIII").Returns(2023).SetName("SevenCharsTwoThousandTwentyThreeValue");
        yield return new TestCaseData("CDXLIV").Returns(444).SetName("SixCharsFourHundredFortyFourValue");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(string roman)
    {
        var testObject = new RomanToInteger();
        return MeasureExecutionTime.Measure(() => testObject.Solution(roman));
    }
}