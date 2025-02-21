using System;
using System.Collections.Generic;
using LeetCode.Others;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestLongestCommonPrefix
{
    static readonly LongestCommonPrefix k_TestObject = new();
    
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((string[]) ["flower", "flow", "flight"], "fl").SetName("CommonPrefix_fl");
        yield return new TestCaseData((string[]) ["dog", "racecar", "car"], "").SetName("NoCommonPrefix");
        yield return new TestCaseData((string[]) ["interspecies", "interstellar", "interstate"], "inters").SetName("CommonPrefix_inters");
        yield return new TestCaseData((string[]) ["throne", "throne"], "throne").SetName("IdenticalStrings");
        yield return new TestCaseData((string[]) ["throne", "dungeon"], "").SetName("NoCommonPrefixDifferentStart");
        yield return new TestCaseData((string[]) ["prefix", "pre"], "pre").SetName("CommonPrefix_pre");
        yield return new TestCaseData((string[]) ["a"], "a").SetName("SingleString");
        yield return new TestCaseData(Array.Empty<string>(), "").SetName("EmptyArray");
        yield return new TestCaseData(
            new[] { "a".PadRight(200, 'a'), "a".PadRight(199, 'a') + "b", "a".PadRight(198, 'a') + "bc" },
            "a".PadRight(198, 'a')
        ).SetName("MaxComplexityCase");
    }

    static IEnumerable<TestCaseData> MethodsToTest()
    {
        yield return new TestCaseData((Func<string[], string>)k_TestObject.Solution_HorizontalScanning).SetName("Horizontal scanning");
        yield return new TestCaseData((Func<string[], string>)k_TestObject.Solution_Sorting).SetName("Sorting");
    }

    static IEnumerable<TestCaseData> CombinedCases()
    {
        foreach (var firstCase in TestCases())
        {
            foreach (var secondCase in MethodsToTest())
            {
                yield return new TestCaseData(firstCase.Arguments[0], firstCase.Arguments[1], secondCase.Arguments[0]).SetName($"{firstCase.TestName}_{secondCase.TestName}");
            }
        }
    }
    
    [Test, TestCaseSource(nameof(CombinedCases))]
    public void TestSolution(string[] strs, string expected, Func<string[], string> algorithm)
    {
        var result = MeasureExecutionTime.Measure(() => algorithm(strs));
        Assert.That(result, Is.EqualTo(expected));
    }
}