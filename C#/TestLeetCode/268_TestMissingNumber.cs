using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestMissingNumber
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [3, 0, 1]).Returns(2).SetName("MissingMiddleNumber");
        yield return new TestCaseData((int[]) [0, 2]).Returns(1).SetName("MissingLastNumber");
        yield return new TestCaseData((int[]) [9,6,4,2,3,5,7,0,1]).Returns(8).SetName("UnorderedArray");
        yield return new TestCaseData((int[]) [0]).Returns(1).SetName("SingleElementZero");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] nums)
    {
        var testObject = new MissingNumber();
        return testObject.Solution(nums);
    }
}
