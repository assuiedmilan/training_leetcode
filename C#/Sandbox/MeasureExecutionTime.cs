using System.Diagnostics;

namespace Sandbox;

public static class MeasureExecutionTime
{
    public static T? Measure<T>(Func<T> testFunc)
    {
        return MeasureFor(testFunc, 1, out _);
    }
    
    public static T? Measure<T>(Func<T> testFunc, out double elapsedTime)
    {
        return MeasureFor(testFunc, 1, out elapsedTime);
    }
    
    public static T? MeasureFor<T>(Func<T> testFunc, int iterations, out double elapsedTime)
    {
        iterations++;
        var stopwatch = Stopwatch.StartNew();
        elapsedTime = 0.0;
        
        var result = default(T);
        
        for (var i = 0; i< iterations; i++) {
            stopwatch.Restart();
            result = testFunc();
            stopwatch.Stop();
            
            if(i == 0) continue;
            elapsedTime += stopwatch.ElapsedTicks / (Stopwatch.Frequency / 1000.0);
        }
        
        Console.WriteLine($"Average Duration: {elapsedTime/iterations} ms");
        
        return result;
    }
    
    
}