using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestCarFleet
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(12, (int[]) [10, 8, 0, 5, 3], (int[]) [2, 4, 1, 1, 3]).Returns(3).SetName("Example case 1: 3 fleets");
        yield return new TestCaseData(10, (int[]) [3], (int[]) [3]).Returns(1).SetName("Single car");
        yield return new TestCaseData(100, (int[]) [0, 2, 4], (int[]) [4, 2, 1]).Returns(1).SetName("All cars form one fleet");
        yield return new TestCaseData(10, (int[]) [6, 8], (int[]) [3, 2]).Returns(2).SetName("Two separate fleets");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int target, int[] position, int[] speed)
    {
        var testObject = new CarFleet();
        return testObject.Solution(target, position, speed);
    }
}
