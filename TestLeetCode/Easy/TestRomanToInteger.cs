using System.Collections.Generic;
using LeetCode.Easy;
using NUnit.Framework;

namespace TestLeetCode.Easy;

public class TestRomanToInteger
{
    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("I", 1).SetName("SingleChar");
        yield return new TestCaseData("II", 2).SetName("TwoCharsTwoValue");
        yield return new TestCaseData("IV", 4).SetName("TwoCharsOneValue");
        yield return new TestCaseData("CDI", 401).SetName("StartsWithTwoCharsEndsWithSingle");
        yield return new TestCaseData("CDIV", 404).SetName("StartsWithTwoCharsEndsWithTwoChars");
        yield return new TestCaseData("MIV", 1004).SetName("EndsWithTwoChars");
        yield return new TestCaseData("MCDI", 1401).SetName("HaveTwoCharsInMiddle");
        yield return new TestCaseData("III", 3).SetName("ThreeCharsThreeValue");
        yield return new TestCaseData("IV", 4).SetName("TwoCharsOneValue");
        yield return new TestCaseData("IX", 9).SetName("TwoCharsNineValue");
        yield return new TestCaseData("CDI", 401).SetName("StartsWithTwoCharsEndsWithSingle");
        yield return new TestCaseData("LVIII", 58).SetName("FiveCharsFiftyEightValue");
        yield return new TestCaseData("MCMXCIV", 1994).SetName("SevenCharsNineteenNinetyFourValue");
        yield return new TestCaseData("MMXXIII", 2023).SetName("SevenCharsTwoThousandTwentyThreeValue");
        yield return new TestCaseData("CDXLIV", 444).SetName("SixCharsFourHundredFortyFourValue");

    }

    [Test, TestCaseSource(nameof(TestCases))]
    public void RomanToInt_ValidInput_ReturnsExpectedResult(string roman, int expected)
    {
        var result = RomanToInteger.RomanToInt(roman);
        Assert.That(result, Is.EqualTo(expected));
    }
}