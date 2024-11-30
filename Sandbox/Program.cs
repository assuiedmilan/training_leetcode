using LeetCode.Arrays.Extras;
using LeetCode.DynamicPrograming.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var iters = 0;
        var testObj = new FlippingImage();
        var firstArg = new int[][] {[1]};
        var expected = new int[][] {[0]};
        
        var result = MeasureExecutionTime.MeasureFor(() => testObj.Solution(firstArg), iters, out var timeOne);
    }
}