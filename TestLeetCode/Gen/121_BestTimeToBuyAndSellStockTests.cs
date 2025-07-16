using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class BestTimeToBuyAndSellStock121Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[7,1,5,3,6,4]).Returns(5).SetName("Example 1");
        yield return new TestCaseData((int[])[7,6,4,3,1]).Returns(0).SetName("Example 2");
        yield return new TestCaseData((int[])[10,1,5,6,7,1]).Returns(6).SetName("Example 3");
        yield return new TestCaseData((int[])[10,8,7,5,2]).Returns(0).SetName("Example 4");
        yield return new TestCaseData((int[])[1,2]).Returns(1).SetName("Example 5");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] prices)
    {
        var testObject = new BestTimeToBuyAndSellStock121();
        return MeasureExecutionTime.Measure(() => testObject.MaxProfit(prices));
    }
}
