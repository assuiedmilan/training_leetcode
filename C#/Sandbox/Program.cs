using System.Collections;
using System.Numerics;
using System.Text;
using LeetCode.Arrays.Extras;
using LeetCode.Arrays.Stack;
using LeetCode.DynamicPrograming.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var testObj = new SummaryRanges();
        const int iters = 0;
        int[] firstArg = [0,1,2,4,5,7];
        string[] expected = ["0->2","4->5","7"];

        var x = AddBinary("0", "0");
        
        Console.WriteLine(x);
        Console.WriteLine(x.Equals("0"));
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
    
    static string AddBinary(string a, string b) {
        var i = a.Length - 1;
        var j = b.Length - 1;
        var r = 1;
        var strip = true;
        
        var carry = 0;
        var res = new char[(a.Length > b.Length ? a.Length : b.Length) + 1];

        while(i > -1 || j > -1 || carry == 1)
        {
            if(i == -1 && j == -1) strip = false;
            carry = (i > -1 && a[i--] == '1' ? 1:0) + (j > -1 && b[j--] == '1' ? 1:0) + (carry == 1 ? 1 : 0);
            res[^r++] = carry%2 == 0 ? '0':'1';
            carry /=2; 
        }

        return strip ? new string(res)[1..] : new string(res);
    }
}