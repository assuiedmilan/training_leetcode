namespace LeetCode.Others;

/* https://leetcode.com/problems/single-number/description/ */
public class SingleNumber
{
    public int Solution(int[] nums) {
        var result = nums[0];
        if (nums.Length == 1) {return result;}
        
        for (var i = 1; i < nums.Length; i++)
        {
            result ^= nums[i]; //XOR will filter any number present an even number of times.
        }

        return result;    
    }
}