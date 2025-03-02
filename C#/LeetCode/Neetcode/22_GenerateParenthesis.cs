using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/generate-parentheses/ */
public class GenerateParenthesis
{
    public IList<string> Solution(int n)
    {
        if (n == 0) return [];
        List<string> result = [];
        Span<char> stack = stackalloc char[2*n];
        
        Backtrack('(', 1, 0, stack);
        
        return result;

        // ReSharper disable once InconsistentNaming
        void Backtrack(char s, int openCount, int closeCount, Span<char> _stack)
        {
            _stack[openCount + closeCount - 1] = s;
            if (openCount == n && closeCount == n)
            {
                result.Add(new string(_stack));
                return;
            }
            
            if (openCount < n) { Backtrack('(', openCount + 1, closeCount, _stack);}
            if (closeCount < openCount) { Backtrack(')', openCount, closeCount + 1, _stack);}
        }
    }
}