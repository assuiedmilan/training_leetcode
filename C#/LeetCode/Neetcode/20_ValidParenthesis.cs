using System;
using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/valid-parentheses/ */
public class ValidParenthesis
{
    public bool Solution(string s) {
        if(s.Length < 2) return false;
        Span<char> memory = stackalloc char[s.Length];
        var top = 0;

        foreach (var c in s)
        {
            if (c is '(' or '{' or '[') { memory[top++] = c; continue;}
            if (top == 0) return false;

            var lastOpen = memory[--top];
            if (
                c == ')' && lastOpen != '(' ||
                c == ']' && lastOpen != '[' ||
                c == '}' && lastOpen != '{'
            ) { return false; }
        }

        return top == 0;
    }    
}
