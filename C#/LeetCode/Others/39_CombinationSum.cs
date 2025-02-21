using System.Collections.Generic;

namespace LeetCode.Others;

/* https://leetcode.com/problems/combination-sum/description/ */
public class CombinationSum
{
    public IList<IList<int>> Solution(int[] candidates, int target)
    {
        var res = new List<IList<int>>();
        var stack = new List<int>();

        Backtrack(0, 0);
        return res;

        void Backtrack(int index, int curr)
        {
            if (curr == target)
            {
                res.Add(new List<int>(stack));
                return;
            }
            if (curr > target) return;

            stack.Add(candidates[index]);
            Backtrack(index, curr+candidates[index]);
            stack.RemoveAt(stack.Count - 1);

            if (index < candidates.Length -1 ) {
                Backtrack(index+1, curr);
            }
        }
    }    
}
