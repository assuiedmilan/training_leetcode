namespace LeetCode.Arrays.NeetCode150;

/*
 * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
 *
 * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 *
 * You must write an algorithm that runs in O(n) time and without using the division operation.
 *
 *
 *
 * Example 1:
 *
 * Input: nums = [1,2,3,4]
 * Output: [24,12,8,6]
 *
 * Example 2:
 *
 * Input: nums = [-1,1,0,-3,3]
 * Output: [0,0,9,0,0]
 *
 *
 *
 * Constraints:
 *
 *    2 <= nums.length <= 105
 *    -30 <= nums[i] <= 30
 *    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 *
 *
 *
 * Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
 */
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