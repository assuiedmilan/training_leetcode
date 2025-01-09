using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Gen;

//https://leetcode.com/problems/baseball-game/description/
//682. Baseball Game
public class BaseballGame682
{
    public int Solution(string[] operations)
    {
        var records = new Stack<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out var score))
            {
                records.Push(score);
            }
            else if (operations[i] == "+")
            {
                var last = records.Pop();
                var secondLast = records.Peek();

                records.Push(last);

                var newRecord = last + secondLast;
                records.Push(newRecord);
            }
            else if (operations[i] == "D")
            {
                var newRecord = records.Peek() * 2;
                records.Push(newRecord);
            }
            else if (operations[i] == "C")
            {
                records.Pop();
            }
        }

        var sum = 0;

        while (records.TryPop(out var record))
        {
            sum += record;
        }

        Console.WriteLine(sum);

        return sum;
    }
}
