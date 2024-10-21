using System.Collections.Generic;
using LeetCode.Patterns.PrefixSum;
using NUnit.Framework;

namespace TestLeetCode.Easy.PrefixSums;

public class TestImmutableRangeSumQuery
{
    const int LargeArrayLength = 100000;

    ImmutableRangeSumQuery LargeTable { get; set; }

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { -2, 0, 3, -5, 2, -1 }, 0, 2).Returns(1);
        yield return new TestCaseData(new[] { -2, 0, 3, -5, 2, -1 }, 2, 5).Returns(-1);
        yield return new TestCaseData(new[] { -2, 0, 3, -5, 2, -1 }, 0, 5).Returns(-3);
        yield return new TestCaseData(new[] { 1 }, 0, 0).Returns(1);
        yield return new TestCaseData(new[] { -1, -2, -3, -4, -5 }, 0, 2).Returns(-6);
        yield return new TestCaseData(new[] { -1, -2, -3, -4, -5 }, 0, 4).Returns(-15);
        yield return new TestCaseData(new[] { 1, -1, 2, -2, 3, -3 }, 0, 1).Returns(0);
        yield return new TestCaseData(new[] { 1, -1, 2, -2, 3, -3 }, 2, 3).Returns(0);
        yield return new TestCaseData(new[] { 1, -1, 2, -2, 3, -3 }, 4, 5).Returns(0);
    }

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        var largeArray = new int[LargeArrayLength];
        for (var i = 0; i < largeArray.Length; i++)
        {
            largeArray[i] = i;
        }

        LargeTable = new ImmutableRangeSumQuery(largeArray);
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSumRangeBasic(int[] nums, int left, int right)
    {
        var numArray = new ImmutableRangeSumQuery(nums);
        return numArray.SumRangeBasic(left, right);
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSumRange(int[] nums, int left, int right)
    {
        var numArray = new ImmutableRangeSumQuery(nums);
        return numArray.SumRange(left, right);
    }

    [Test]
    public void TestSumRangeBasic_VeryTimeConsuming()
    {
        var result = MeasureExecutionTime.Measure(() => LargeTable.SumRangeBasic(0, LargeArrayLength - 1));
        Assert.That(result, Is.EqualTo(704982704)); // Sum of first 100000 natural numbers
    }

    [Test]
    public void TestSumRange_VeryTimeConsuming()
    {
        var result = MeasureExecutionTime.Measure(() => LargeTable.SumRange(0, LargeArrayLength - 1));
        Assert.That(result, Is.EqualTo(704982704)); // Sum of first 100000 natural numbers
    }
}