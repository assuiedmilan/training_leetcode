using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestReverseBits
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((uint)2).Returns((uint)1073741824).SetName("SimpleCase");
        yield return new TestCaseData((uint)43261596).Returns((uint)964176192).SetName("ExampleCase1");
        yield return new TestCaseData(4294967293).Returns(3221225471).SetName("ExampleCase2");
        yield return new TestCaseData((uint)0).Returns((uint)0).SetName("AllZeroBits");
        yield return new TestCaseData((uint)1).Returns(2147483648).SetName("SingleOneBit");
        yield return new TestCaseData(4294967295).Returns(4294967295).SetName("AllOneBits");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public uint TestSolution(uint n)
    {
        var testObject = new ReverseBits();
        return testObject.Solution(n);
    }
}
