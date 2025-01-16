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

    /*
        yield return new TestCaseData("/").Returns("/").SetName("SingleSlash");
        yield return new TestCaseData("/home/").Returns("/home").SetName("example1");
        yield return new TestCaseData("/home//foo/").Returns("/home/foo").SetName("example2");
        yield return new TestCaseData("/home/user/Documents/../Pictures").Returns("/home/user/Pictures").SetName("example3");
        yield return new TestCaseData("/../").Returns("/").SetName("example4");
        yield return new TestCaseData("/.../a/../b/c/../d/./").Returns("/.../b/d").SetName("example5");
     */

    static string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        string[] words = path.Split('/');
        int skipNextWord = 0;

        for(int i = words.Length - 1; i >= 0; i--)
        {
            if (words[i] == "..")
                skipNextWord++;
            else if (words[i] == "." || words[i] == string.Empty)
                continue;
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
