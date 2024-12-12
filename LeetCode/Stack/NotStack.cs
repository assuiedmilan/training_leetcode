using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCode.Stack;

public class NotStack
{
    public NotStack()
    {
        // n = 1 => ()
        // n = 2 => ()(), (())    ajoute () apres, ajoute () à l'intérieur d'un (), etc du previous step
        // n = 3 => ()()(), (())(), ()(()), (()()), ((()))

        var result = Solution(3);
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }

    // zéro optimisé

    public string[] Solution(int n)
    {
        const char open = '(';
        const char close = ')';

        int previous = n - 1;
        var result = string.Empty;

        if (previous > 0)
        {
            var arrays = Solution(previous);

            List<string> newArrays = new();

            foreach (var s in arrays)
            {
                var newString = s;
                var newString2 = s;
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] == open && s[i + 1] == close)
                    {
                        newString = s.Insert(i, ""+open+close);
                        newString2 = s.Insert(i+1, ""+open+close);
                        newArrays.Add(newString);
                        newArrays.Add(newString2);
                    }
                }
            }

            return newArrays.Distinct().ToArray();
        }

        result += open;
        result += close;

        return [result];
    }
}
