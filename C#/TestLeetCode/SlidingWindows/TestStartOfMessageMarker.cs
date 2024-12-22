using System;
using System.Collections.Generic;
using LeetCode.SlidingWindows;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.SlidingWindows;

public class TestStartOfMessageMarker
{
    static readonly StartOfMessageMarker k_TestObject = new();
    
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abcdefghijklmn").Returns(14).SetName("MinimalCase");
        yield return new TestCaseData("xqwertyuiopasdfzxcvbnm").Returns(14).SetName("SimpleCase");
        yield return new TestCaseData("xxqwertyuiopasdfzxcvbnm").Returns(15).SetName("DoubleCharacterAtPosition1");
        yield return new TestCaseData("xxxqwertyuiopasdfzxcvbnm").Returns(16).SetName("TripleCharacterAtPosition1");
        yield return new TestCaseData("xqwqwexrtyuiopasdfzxcvbnm").Returns(17).SetName("SeveralDuplicationBeforeMarker");
        yield return new TestCaseData("mjqjpqmgbljsphdztnvjfqwrcgsmlb").Returns(19).SetName("Example1");
        yield return new TestCaseData("bvwbjplbgvbhsrlpgdmjqwftvncz").Returns(23).SetName("Example2");
        yield return new TestCaseData("nppdvjthqldpwncqszvftbrmjlhg").Returns(23).SetName("Example3");
        yield return new TestCaseData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg").Returns(29).SetName("Example4");
        yield return new TestCaseData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw").Returns(26).SetName("Example5");
    }

    static IEnumerable<TestCaseData> MethodsToTest()
    {
        yield return new TestCaseData((Func<string, int>)k_TestObject.Solution).SetName("Regular solution");
        yield return new TestCaseData((Func<string, int>)k_TestObject.Solution_BitMask).SetName("Bitmask");
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
    public int TestSolution(string s, Func<string, int> algorithm)
    {
        return MeasureExecutionTime.Measure(() => algorithm(s));
    }
}
