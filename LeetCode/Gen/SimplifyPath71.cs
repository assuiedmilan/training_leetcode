using System.Collections.Generic;

namespace LeetCode.Gen;

//https://leetcode.com/problems/simplify-path/description/
//71. Simplify Path
public class SimplifyPath71
{
    public string Solution(string path)
    {
        return SimplifyPath(path);
    }

    static string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        var words = path.Split('/');
        var skipNextWord = 0;

        for(int i = words.Length - 1; i >= 0; i--)
        {
            if (words[i] == "." || words[i] == string.Empty)
                continue;
            if (words[i] == "..")
                skipNextWord++;
            else
            {
                if (skipNextWord > 0)
                {
                    skipNextWord--;
                    continue;
                }
                stack.Push(words[i]);
            }
        }

        return "/" + string.Join("/", stack);
    }
}
