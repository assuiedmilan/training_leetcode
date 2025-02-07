using System.Collections.Generic;

namespace LeetCode.Arrays.Extras;

public class NumberOfDistinctColorsAmongBalls
{
    public int[] Solution(int limit, int[][] queries)
    {
        var colors = new Dictionary<int, int>();
        var ballColorTracker = new Dictionary<int, int>();
        
        var res = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var ballIndex = queries[i][0];
            var color = queries[i][1];

            if (ballColorTracker.TryGetValue(ballIndex, out var currentColor))
            {
                colors[currentColor] -= 1;
                if (colors[currentColor] == 0) colors.Remove(currentColor);
            }
        
            colors.TryAdd(color, 0);

            colors[color] += 1;
            ballColorTracker[ballIndex] = color;

            res[i] = colors.Count;
        }

        return res;
    }    
}
