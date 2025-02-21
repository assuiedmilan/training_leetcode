using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestEncodeDecodeString
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new List<string> { "neet", "code", "love", "you" })
            .Returns(new List<string> { "neet", "code", "love", "you" })
            .SetName("Example case 1");
        yield return new TestCaseData(new List<string> { "we", "say", ":", "yes" })
            .Returns(new List<string> { "we", "say", ":", "yes" })
            .SetName("Example case 2");
        yield return new TestCaseData(new List<string>())
            .Returns(new List<string>())
            .SetName("Empty list");
        yield return new TestCaseData(new List<string> { "" })
            .Returns(new List<string> { "" })
            .SetName("Single empty string");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public List<string> TestSolution(List<string> strs)
    {
        var testObject = new EncodeDecodeString();
        var encoded = testObject.Encode(strs);
        return testObject.Decode(encoded);
    }
}
