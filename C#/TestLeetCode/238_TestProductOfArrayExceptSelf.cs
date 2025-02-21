using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestProductOfArrayExceptSelf
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1,2,3,4 }).Returns((int[]) [24,12,8,6]).SetName("Example case");
        yield return new TestCaseData(new[] { 5,2,3,4 }).Returns(new[] { 24,60,40,30 }).SetName("Example case 2");
        yield return new TestCaseData(new[] { -1,1,0,-3,3 }).Returns(new[] { 0,0,9,0,0 }).SetName("Example case 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums)
    {
        var testObject = new ProductOfArrayExceptSelf();
        return MeasureExecutionTime.Measure(() => testObject.Solution(nums));
    }
}
