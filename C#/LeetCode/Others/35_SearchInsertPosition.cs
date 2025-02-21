namespace LeetCode.Others;

/* https://leetcode.com/problems/search-insert-position/description/ */
public class SearchInsertPosition
{
    public int Solution(int[] nums, int target)
    {
        var i = 0;
        var j = nums.Length-1;

        while (i <= j)
        { 
            var k = (i + j) / 2;
            var value = nums[k];
           
            if (value == target) return k;

            if (value > target) j = k - 1;
            if (value < target) i = k + 1;
        }
        
        return i; 
    }
}