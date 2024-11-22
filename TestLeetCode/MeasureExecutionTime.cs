using System;
using System.Diagnostics;

namespace TestLeetCode;

public static class MeasureExecutionTime
{
    public static T Measure<T>(Func<T> testFunc)
    {
        var stopwatch = Stopwatch.StartNew();
        var result = testFunc();
        stopwatch.Stop();
        var elapsedMilliseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / 1000.0);
        Console.WriteLine($"Duration: {elapsedMilliseconds} ms");
        return result;
    }
}