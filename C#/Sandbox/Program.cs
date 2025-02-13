﻿using System.Collections;
using LeetCode.Arrays.Extras;
using LeetCode.Bitmasks.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var testObj = new NumberOfDistinctColorsAmongBalls();
        int[] firstArg = [-100, -140, -80];
        const int secondArg = 5;

        var x = testObj.Solution(4, [[1,4], [2, 5], [2,3], [0, 2]]);

        Print(x, new int[]{1, 2, 2, 3});
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