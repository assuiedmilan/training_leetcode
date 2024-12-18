using System.Collections.Generic;
using System.Xml.XPath;

namespace LeetCode.Backtracking;

public class GenerateParenthesis
{
   
    public IList<string> Solution(int n)
    {
        List<string> result = [];
        var stack = new char[2*n];

        backtrack('(', 1, 0);
        void backtrack(char s, int openCount, int closeCount)
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
            backtrack('(', openCount+1, closeCount);
            backtrack(')', openCount, closeCount+1);
        }

        return result;
    }
}