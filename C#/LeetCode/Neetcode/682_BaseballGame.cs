using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/baseball-game/description/ */
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

            StringToInt(token, out var r);
            record.Push(r);
        }

        var sum = 0;
        while (record.Count > 0)
        {
            sum += record.Pop();
        }

        return sum;
    }

    static void StringToInt(string s, out int r)
    {
        r = 0;
        
        var isNegative = s[0] == '-';
        var value = 0;
        
        if (isNegative && s.Length < 2) return;
        
        for (var i = isNegative ? 1 : 0; i < s.Length; i++)
        {
            if (s[i] < '0' || s[i] > '9') return;
            r = r * 10 + (s[i] - '0');
            value = value * 10 + (s[i] - '0');
        }

        r = isNegative ? value * -1 : value;
    }
}
