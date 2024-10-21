using System.Collections.Generic;
using LeetCode.Easy;
using NUnit.Framework;

namespace TestLeetCode.Easy;

public class TestLongestCommonPrefixClass
{
    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { "flower", "flow", "flight" }, "fl").SetName("CommonPrefix_fl");
        yield return new TestCaseData(new[] { "dog", "racecar", "car" }, "").SetName("NoCommonPrefix");
        yield return new TestCaseData(new[] { "interspecies", "interstellar", "interstate" }, "inters").SetName("CommonPrefix_inters");
        yield return new TestCaseData(new[] { "throne", "throne" }, "throne").SetName("IdenticalStrings");
        yield return new TestCaseData(new[] { "throne", "dungeon" }, "").SetName("NoCommonPrefixDifferentStart");
        yield return new TestCaseData(new[] { "prefix", "pre" }, "pre").SetName("CommonPrefix_pre");
        yield return new TestCaseData(new[] { "a" }, "a").SetName("SingleString");
        yield return new TestCaseData(new string[] { }, "").SetName("EmptyArray");
        yield return new TestCaseData(
            new[] { "a".PadRight(200, 'a'), "a".PadRight(199, 'a') + "b", "a".PadRight(198, 'a') + "bc" },
            "a".PadRight(198, 'a')
        ).SetName("MaxComplexityCase");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public void LongestCommonPrefixBasic_ValidInput_ReturnsExpectedResult(string[] strs, string expected)
    {
        var result = MeasureExecutionTime.Measure(() => LongestCommonPrefixClass.LongestCommonPrefixBasic(strs));
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public void LongestCommonPrefix_HorizontalScanning_ValidInput_ReturnsExpectedResult(string[] strs, string expected)
    {
        var result = MeasureExecutionTime.Measure(() => LongestCommonPrefixClass.LongestCommonPrefix_HorizontalScanning(strs));
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public void LongestCommonPrefix_Sorting_ValidInput_ReturnsExpectedResult(string[] strs, string expected)
    {
        var result = MeasureExecutionTime.Measure(() => LongestCommonPrefixClass.LongestCommonPrefix_Sorting(strs));
        Assert.That(result, Is.EqualTo(expected));
    }
}