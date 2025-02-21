using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestGroupsOfAnagrams
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData([(string[]) ["eat", "tea", "tan", "ate", "nat", "bat"]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            })
            .SetName("Base example");

        yield return new TestCaseData([(string[]) ["stop", "pots", "reed", "", "tops", "deer", "opts", ""]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "stop", "pots", "tops", "opts" },
                new List<string> { "reed", "deer" },
                new List<string> { "", "" },
            })
            .SetName("Medium example");

        yield return new TestCaseData([(string[]) [""]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "" }
            })
            .SetName("Empty string");

        yield return new TestCaseData([(string[]) ["", ""]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "", "" }
            })
            .SetName("Double empty string");

        yield return new TestCaseData([(string[]) ["a"]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "a" }
            })
            .SetName("Single string");

        yield return new TestCaseData([(string[]) ["a", "a", "a"]])
            .Returns(new List<IList<string>>
            {
                new List<string> { "a", "a", "a" }
            })
            .SetName("Identical strings");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<string>> TestSolution(string[] strs)
    {
        var testObject = new GroupsOfAnagrams();
        return MeasureExecutionTime.Measure(() => testObject.Solution(strs));
    }
}