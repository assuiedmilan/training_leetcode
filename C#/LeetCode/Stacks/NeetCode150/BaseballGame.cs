using System.Collections.Generic;

namespace LeetCode.Stacks.NeetCode150;

/*
 * You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.
 *
 * You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:
 *
 *     An integer x.
 *         Record a new score of x.
 *     '+'.
 *         Record a new score that is the sum of the previous two scores.
 *     'D'.
 *         Record a new score that is the double of the previous score.
 *     'C'.
 *         Invalidate the previous score, removing it from the record.
 *
 * Return the sum of all the scores on the record after applying all the operations.
 *
 * The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.
 */
public class BaseballGame
{
    public int Solution(string[] operations)
    {
        var record = new Stack<int>();

        foreach (var token in operations)
        {
            switch (token)
            {
                case "+":
                {
                    var x = record.Pop();
                    var y = record.Peek();
                    record.Push(x);
                    record.Push(x + y);
                    continue;
                }
                case "D":
                {
                    var x = record.Peek();
                    record.Push(2 * x);
                    continue;
                }
                case "C":
                {
                    record.Pop();
                    continue;
                }
            }

            TryStringToInt(token, out var r);
            record.Push(r);
        }

        var sum = 0;
        while (record.Count > 0)
        {
            sum += record.Pop();
        }

        return sum;
    }

    static bool TryStringToInt(string s, out int r)
    {
        r = 0;
        
        var isNegative = s[0] == '-';
        var value = 0;
        
        if (isNegative && s.Length < 2) return false;
        
        for (var i = isNegative ? 1 : 0; i < s.Length; i++)
        {
            if (s[i] < '0' || s[i] > '9') return false;
            r = r * 10 + (s[i] - '0');
            value = value * 10 + (s[i] - '0');
        }

        r = isNegative ? value * -1 : value;
        return true;
    }
}
