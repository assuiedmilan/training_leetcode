namespace LeetCode.Others;

/* https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/description/ */
public class PrefixCommonArray
{
    public int[] Solution(int[] a, int[] b)
    {
        var ans = new int[a.Length];
        var encountered = new bool[a.Length];
        var prefix = 0;

        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i])
            {
                prefix += 1;
                ans[i] = prefix;
                continue;
            }

            if (encountered[a[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encountered[a[i] - 1] = true;
            }

            if (encountered[b[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encountered[b[i] - 1] = true;
            }
            
            ans[i] = prefix;
        }

        return ans;
    }    
}
