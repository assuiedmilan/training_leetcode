using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/generate-parentheses/ */
public class GenerateParenthesis
{
    public IList<string> Solution(int n)
    {
        List<string> result = [];
        var stack = new char[2*n];

        Backtrack('(', 1, 0);

        return result;

        void Backtrack(char s, int openCount, int closeCount)
        {
            if (openCount == n && closeCount == n)
            {
                stack[openCount + closeCount -1 ] = s;
                result.Add(new string(stack));
                return;
            }
            if (s == ')' && openCount < closeCount) return;
            if (openCount == n + 1 || closeCount == n + 1) return;

            stack[openCount + closeCount -1 ] = s;
            Backtrack('(', openCount+1, closeCount);
            Backtrack(')', openCount, closeCount+1);
        }
    }
}