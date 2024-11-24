using LeetCode.DynamicPrograming.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var pascalTriangle = new PascalTriangleII();
        const int rows = 40;
        const int iters = 0;
        
        MeasureExecutionTime.MeasureFor(() => pascalTriangle.Solution(rows), iters, out var timeOne);
    }
}