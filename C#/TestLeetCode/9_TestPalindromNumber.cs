using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Others;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestPalindromeNumber
{
    static readonly PalindromeNumber k_TestObject = new();
    
    static int GenerateLargePalindrome(int length)
    {
        var random = new Random();
        var halfLength = length / 2;
        var firstHalf = random.Next((int)Math.Pow(10, halfLength - 1), (int)Math.Pow(10, halfLength));
        var secondHalf = int.Parse(new string(firstHalf.ToString().Reverse().ToArray()));
        return int.Parse(firstHalf + secondHalf.ToString());
    }
    
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(121).Returns(true).SetName("PositivePalindrome");
        yield return new TestCaseData(-121).Returns(false).SetName("NegativeNumber");
        yield return new TestCaseData(10).Returns(false).SetName("NotAPalindrome");
        yield return new TestCaseData(0).Returns(true).SetName("Zero");
        yield return new TestCaseData(12321).Returns(true).SetName("OddLengthPalindrome");
        yield return new TestCaseData(1221).Returns(true).SetName("EvenLengthPalindrome");
        yield return new TestCaseData(GenerateLargePalindrome(9)).Returns(true).SetName("LargePalindrome");
    }

    static IEnumerable<TestCaseData> MethodsToTest()
    {
        yield return new TestCaseData((Func<int, bool>)k_TestObject.Solution).SetName("Solution using maths");
        yield return new TestCaseData((Func<int, bool>)k_TestObject.Solution_ConvertToString).SetName("Solution by converting to string");
    }

    static IEnumerable<TestCaseData> CombinedCases()
    {
        foreach (var firstCase in TestCases())
        {
            foreach (var secondCase in MethodsToTest())
            {
                yield return new TestCaseData(firstCase.Arguments[0], secondCase.Arguments[0]).SetName($"{firstCase.TestName}_{secondCase.TestName}").Returns(firstCase.ExpectedResult);
            }
        }
    }
    
    [Test, TestCaseSource(nameof(CombinedCases))]
    public bool TestIsPalindrome(int x, Func<int, bool> algorithm)
    {
        return MeasureExecutionTime.Measure(() => algorithm(x));
    }
}