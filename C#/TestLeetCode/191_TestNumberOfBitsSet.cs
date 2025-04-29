using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestNumberOfBitsSet
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(0).Returns(0).SetName("ZeroInput");
        yield return new TestCaseData(1).Returns(1).SetName("SingleBitSet");
        yield return new TestCaseData(15).Returns(4).SetName("AllBitsSetInNibble");
        yield return new TestCaseData(255).Returns(8).SetName("AllBitsSetInByte");
        yield return new TestCaseData(int.MaxValue).Returns(31).SetName("MaxIntValue");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int n)
    {
        var testObject = new NumberOfBitsSet();
        return testObject.Solution(n);
    }
}
