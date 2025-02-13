using System.Collections;
using LeetCode.Arrays.Extras;
using LeetCode.Bitmasks.Extras;
using LeetCode.Strings;
using LeetCode.TwoPointers.Extras;
using LeetCode.TwoPointers.Neetcode;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var testObj = new MergeSortedArray();

        int[] num1 = [1, 2, 3, 4, 0, 0, 0];
        testObj.Solution(num1, 4, [3,5,7], 3);

        
    }
    
    static void Print(object result, object expected)
    {
        if(expected is ICollection expectedCollection)
        {
            var resultCollection = (ICollection) result;
            Console.WriteLine($"Results:");
            foreach (var pair in expectedCollection.Cast<object>().Zip(resultCollection.Cast<object>(), (e, r) => new { Expected = e, Result = r }))
            {
                Console.WriteLine($"Expected: {pair.Expected}, Result: {pair.Result}");
            }
            return;
        }
        
        Console.WriteLine($"Expected: {expected}, Result: {result}");
    }
}