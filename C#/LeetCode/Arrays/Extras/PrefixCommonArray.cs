namespace LeetCode.Arrays.Extras;

public class PrefixCommonArray
{
    public int[] Solution(int[] A, int[] B)
    {
        var ans = new int[A.Length];
        var encoutered = new bool[A.Length];
        var prefix = 0;

        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] == B[i])
            {
                prefix += 1;
                ans[i] = prefix;
                continue;
            }

            if (encoutered[A[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encoutered[A[i] - 1] = true;
            }

            if (encoutered[B[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encoutered[B[i] - 1] = true;
            }
            
            ans[i] = prefix;
        }

        return ans;
    }    
}
