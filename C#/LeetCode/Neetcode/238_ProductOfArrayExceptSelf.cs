namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/product-of-array-except-self/ */
public class ProductOfArrayExceptSelf
{
    public int[] Solution(int[] nums)
    {
        var prefixProduct = new int[nums.Length];
        var suffixProduct = new int[nums.Length];
        var answer = new int[nums.Length];
        
        prefixProduct[0] = nums[0];
        suffixProduct[^1] = nums[^1];
        
        for(var i = 1; i < nums.Length; i++)
        {
            prefixProduct[i] = prefixProduct[i - 1] * nums[i];
            suffixProduct[^(i + 1)] = suffixProduct[^i] * nums[^(i + 1)];
        }

        answer[0] = suffixProduct[1];
        answer[^1] = prefixProduct[^2];
        
        for(var i = 1; i < nums.Length - 1; i++)
        {
            answer[i] = prefixProduct[i - 1] * suffixProduct[i + 1];

        }
    
        return answer;
    }
}