namespace LeetCode.Stack.Extras;

public class MinAddToMakeValid
{
    public int Solution(string s) {
        var open = 0;
        var close = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') { open++; }
            else
            {
                if (open > 0) open--;
                else close++;
            }
        }
        
        return open + close;
    }
}