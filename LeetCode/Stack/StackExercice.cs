using System;
using System.Collections.Generic;

namespace LeetCode.Stack;

public class StackExercice
{
    public StackExercice()
    {
        Console.WriteLine(Solution(["4", "5", "3", "/", "2", "+", "-" ]));
    }

    public int Solution(string[] calculatricePolonaiseInverse)
    {
        var stack = new Stack<int>();

        foreach(var s in calculatricePolonaiseInverse)
        {
            if(int.TryParse(s, out var number)) // C'est un nombre
            {
               stack.Push(number);
            }
            else // C'est un opérateur
            {
                var operateur = s;
                var nombre2 = stack.Pop();
                var nombre1 = stack.Pop();
                int result = 0;

                if (operateur == "+")
                {
                    result = nombre1 + nombre2;
                }
                else if (operateur == "-")
                {
                    result = nombre1 - nombre2;
                }
                else if (operateur == "*")
                {
                    result = nombre1 * nombre2;
                }
                else if (operateur == "/")
                {
                    result = nombre1 / nombre2;
                }
                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
