using System.Collections;
using LeetCode.Bitmasks.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var testObj = new MinimizeXor();
        const int firstArg = 3;
        const int secondArg = 5;

        var x = testObj.Solution(firstArg, secondArg);
        
        Console.WriteLine(x);
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
        
        Console.WriteLine($"Expected: {result}, Result: {expected}");
    }
}