using System.Collections;
using LeetCode.Neetcode;
using LeetCode.Others;

namespace Sandbox;

public static class Program
{
    static void Main(string[] args)
    {
        var testObj = new MergeSortedArray();

        var num1 = (int[])[1, 2, 3, 4, 0, 0, 0];
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