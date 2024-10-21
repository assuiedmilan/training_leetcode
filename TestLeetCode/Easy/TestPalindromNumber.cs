using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Easy;
using NUnit.Framework;

namespace TestLeetCode.Easy;

public class TestPalindromeNumber
{
    private static int GenerateLargePalindrome(int length)
    {
        var random = new Random();
        var halfLength = length / 2;
        var firstHalf = random.Next((int)Math.Pow(10, halfLength - 1), (int)Math.Pow(10, halfLength));
        var secondHalf = int.Parse(new string(firstHalf.ToString().Reverse().ToArray()));
        return int.Parse(firstHalf + secondHalf.ToString());
    }
    
    private static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(121, true).SetName("PositivePalindrome");
        yield return new TestCaseData(-121, false).SetName("NegativeNumber");
        yield return new TestCaseData(10, false).SetName("NotAPalindrome");
        yield return new TestCaseData(0, true).SetName("Zero");
        yield return new TestCaseData(12321, true).SetName("OddLengthPalindrome");
        yield return new TestCaseData(1221, true).SetName("EvenLengthPalindrome");
        yield return new TestCaseData(GenerateLargePalindrome(9), true).SetName("LargePalindrome");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public void TestIsPalindrome(int x, bool expected)
    {
        Assert.That(MeasureExecutionTime.Measure(() => PalindromeNumber.IsPalindrome(x)), Is.EqualTo(expected));
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public void TestIsPalindromeBasic(int x, bool expected)
    {
        Assert.That(MeasureExecutionTime.Measure(() => PalindromeNumber.IsPalindromeString(x)), Is.EqualTo(expected));
    }
}