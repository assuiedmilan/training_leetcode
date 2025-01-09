using LeetCode.Gen;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var testing = new BaseballGame682();
        var operators1 = new [] { "5", "2", "C", "D", "+" }; // 30
        var operators2 = new [] { "5","-2","4","C","D","9","+","+" }; // 27
        var operators3 = new [] { "1","C" }; // 0

        var iter = 1;

       MeasureExecutionTime.MeasureFor(() => testing.Solution(operators1), iter, out var timeOne);
       MeasureExecutionTime.MeasureFor(() => testing.Solution(operators2), iter, out var timeTwo);
       MeasureExecutionTime.MeasureFor(() => testing.Solution(operators3), iter, out var timeThree);
    }
}