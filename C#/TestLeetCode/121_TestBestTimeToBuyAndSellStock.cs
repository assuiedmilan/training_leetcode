using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestBestTimeToBuyAndSellStock
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [7, 1, 5, 3, 6, 4]).Returns(5).SetName("ExampleCase");
        yield return new TestCaseData((int[]) [7, 6, 4, 3, 1]).Returns(0).SetName("NoProfit");
        yield return new TestCaseData((int[]) [1, 2, 3, 4, 5]).Returns(4).SetName("AscendingPrices");
        yield return new TestCaseData((int[]) [5, 4, 3, 2, 1]).Returns(0).SetName("DescendingPrices");
        yield return new TestCaseData((int[]) [2, 4, 1]).Returns(2).SetName("SmallArray");
        yield return new TestCaseData((int[]) [1]).Returns(0).SetName("SingleElement");
        yield return new TestCaseData((int[]) [3, 3, 5, 0, 0, 3, 1, 4]).Returns(4).SetName("MultipleOpportunities");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] prices)
    {
        var testObject = new BestTimeToBuyAndSellStock();
        return testObject.Solution(prices);
    }
}
