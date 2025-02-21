using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestImmutableRangeSumQuery
{
    const int k_LargeArrayLength = 100000;

    ImmutableRangeSumQuery LargeTable { get; set; }

    static IEnumerable<TestCaseData> TestCases()
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
        var largeArray = new int[k_LargeArrayLength];
        for (var i = 0; i < largeArray.Length; i++)
        {
            largeArray[i] = i;
        }

        LargeTable = new ImmutableRangeSumQuery(largeArray);
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums, int left, int right)
    {
        var numArray = new ImmutableRangeSumQuery(nums);
        return MeasureExecutionTime.Measure(() => numArray.SumRange(left, right));
    }

    [Test]
    public void TestSolution_VeryTimeConsuming()
    {
        var result = MeasureExecutionTime.Measure(() => LargeTable.SumRange(0, k_LargeArrayLength - 1));
        Assert.That(result, Is.EqualTo(704982704)); // Sum of first 100000 natural numbers
    }
}