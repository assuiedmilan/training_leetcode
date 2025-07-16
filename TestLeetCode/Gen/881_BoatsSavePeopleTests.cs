using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class BoatsSavePeople881Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[])[1,2], 3).Returns(1).SetName("Example 1");
        yield return new TestCaseData((int[])[3,2,2,1], 3).Returns(3).SetName("Example 2");
        yield return new TestCaseData((int[])[3,5,3,4], 5).Returns(4).SetName("Example 3");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] people, int limit)
    {
        var testObject = new BoatsSavePeople881();
        return MeasureExecutionTime.Measure(() => testObject.NumRescueBoats(people, limit));
    }
}
