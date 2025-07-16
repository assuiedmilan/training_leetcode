using System.Collections.Generic;
using LeetCode.Gen;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode.Gen;

public class SimplifyPath71Tests
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("/").Returns("/").SetName("SingleSlash");
        yield return new TestCaseData("/home/").Returns("/home").SetName("example1");
        yield return new TestCaseData("/home//foo/").Returns("/home/foo").SetName("example2");
        yield return new TestCaseData("/home/user/Documents/../Pictures").Returns("/home/user/Pictures").SetName("example3");
        yield return new TestCaseData("/../").Returns("/").SetName("example4");
        yield return new TestCaseData("/.../a/../b/c/../d/./").Returns("/.../b/d").SetName("example5");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string path)
    {
        var testObject = new SimplifyPath71();
        return MeasureExecutionTime.Measure(() => testObject.Solution(path));
    }
}