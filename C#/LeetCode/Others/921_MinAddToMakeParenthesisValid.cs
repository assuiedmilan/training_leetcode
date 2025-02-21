namespace LeetCode.Others;

/* https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/ */
public class MinAddToMakeParenthesisValid
{
    public int Solution(string s) {
        var open = 0;
        var close = 0;

        foreach (var t in s)
        {
            if (t == '(') { open++; }
            else
            {
                if (open > 0) open--;
                else close++;
            }
        }
        
        return open + close;
    }
}