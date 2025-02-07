using System.Collections.Generic;

namespace LeetCode.Stacks.NeetCode150;

/*
 * You are given an array of strings tokens that represents a valid arithmetic expression in Reverse Polish Notation.
 *
 * Return the integer that represents the evaluation of the expression.
 *
 *     The operands may be integers or the results of other operations.
 *     The operators include '+', '-', '*', and '/'.
 *     Assume that division between integers always truncates toward zero.
 *
 * Example 1:
 *
 * Input: tokens = ["1","2","+","3","*","4","-"]
 *
 * Output: 5
 *
 * Explanation: ((1 + 2) * 3) - 4 = 5
 *
 * Constraints:
 *
 *     1 <= tokens.length <= 1000.
 *     tokens[i] is "+", "-", "*", or "/", or a string representing an integer in the range [-100, 100].
 *
 */
public class ReversePolishNotation
{
    public int Solution(string[] tokens)
    {
        var valuesStack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (TryStringToInt(token, out var number)) {
                valuesStack.Push(number);
                continue;
            }

            switch (token)
            {
                case "+":
                    valuesStack.Push(valuesStack.Pop() + valuesStack.Pop());
                    continue;
                case "-":
                    valuesStack.Push(-valuesStack.Pop() + valuesStack.Pop());
                    continue;
                case "*":
                    valuesStack.Push(valuesStack.Pop() * valuesStack.Pop());
                    continue;
                case "/":
                {
                    var denominator = valuesStack.Pop();
                    valuesStack.Push(valuesStack.Pop() / denominator);
                    break;
                }
            }
        }

        return valuesStack.Pop();
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
