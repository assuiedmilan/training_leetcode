using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestSortColors
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [2, 0, 2, 1, 1, 0])
            .Returns((int[]) [0, 0, 1, 1, 2, 2])
            .SetName("MixedColors");
        
        yield return new TestCaseData((int[]) [2, 0, 1])
            .Returns((int[]) [0, 1, 2])
            .SetName("OneOfEach");
            
        yield return new TestCaseData((int[]) [0, 0, 0])
            .Returns((int[]) [0, 0, 0])
            .SetName("AllZeros");
            
        yield return new TestCaseData((int[]) [1, 1, 1])
            .Returns((int[]) [1, 1, 1])
            .SetName("AllOnes");
            
        yield return new TestCaseData((int[]) [2, 2, 2])
            .Returns((int[]) [2, 2, 2])
            .SetName("AllTwos");
            
        yield return new TestCaseData((int[]) [])
            .Returns((int[]) [])
            .SetName("EmptyArray");
            
        yield return new TestCaseData((int[]) [1])
            .Returns((int[]) [1])
            .SetName("SingleElement");
            
        yield return new TestCaseData((int[]) [2, 1, 2, 0, 0, 1, 2, 1, 0])
            .Returns((int[]) [0, 0, 0, 1, 1, 1, 2, 2, 2])
            .SetName("LargerInput");
    }
    
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums)
    {
        var testObject = new SortColors();
        var result = (int[])nums.Clone();
        testObject.Solution(result);
        return result;
    }
}
