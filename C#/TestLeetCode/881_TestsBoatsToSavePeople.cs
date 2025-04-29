using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestsBoatsToSavePeople
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2], 3).Returns(1).SetName("TwoPeopleFitInOneBoat");
        yield return new TestCaseData((int[]) [3, 2, 2, 1], 3).Returns(3).SetName("MultipleBoatsRequired");
        yield return new TestCaseData((int[]) [3, 5, 3, 4], 5).Returns(4).SetName("EachPersonInSeparateBoat");
        yield return new TestCaseData((int[]) [], 3).Returns(0).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 3).Returns(1).SetName("SinglePerson");
        yield return new TestCaseData((int[]) [1,5,3,5], 7).Returns(3).SetName("Test45");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int TestSolution(int[] people, int limit)
    {
        var testObject = new BoatsToSavePeople();
        return testObject.Solution(people, limit);
    }
}
