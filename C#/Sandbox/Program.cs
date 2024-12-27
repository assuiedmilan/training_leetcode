using LeetCode.Backtracking;
using LeetCode.Backtracking.Extras;
using LeetCode.Stack.NeetCode150;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {

        var testObj = new CombinationSum();
        var result = testObj.Solution([2, 3, 6, 7], 7);

        foreach (var list in result)
        {
            Console.WriteLine(string.Join(", ", list));
        }

    }
}