namespace LeetCode.Easy;

public static class PalindromeNumber
{
    /* 
     * Problem: 9. Palindrome Number
     *
     * Given an integer x, return true if x is a palindrome, and false otherwise.
     *
     *
     *
     * Example 1:
     *
     * Input: x = 121
     * Output: true
     * Explanation: 121 reads as 121 from left to right and from right to left.
     *
     * Example 2:
     *
     * Input: x = -121
     * Output: false
     * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore, it is not a palindrome.
     *
     * Example 3:
     *
     * Input: x = 10
     * Output: false
     * Explanation: Reads 01 from right to left. Therefore, it is not a palindrome.
     *
     *
     *
     * Constraints:
     *
     *     -231 <= x <= 231 - 1
     *
     *
     * Follow up: Could you solve it without converting the integer to a string?
     */
    
    public static bool IsPalindrome(int x)
    {
        if(x < 0  || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        
        if(x < 10)
        {
            return true;
        }
        
        var reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        // x == reversedHalf for even length palindrome, but will have one more digit for odd length palindrome
        return x == reversedHalf || x == reversedHalf / 10;
    }
    
    public static bool IsPalindromeString(int x) {
        
        for(var left = 0; left < x.ToString().Length / 2; left++)
        {
            var right = x.ToString().Length - 1 - left;
            if(x.ToString()[left] != x.ToString()[right])
            {
                return false;
            }
        }

        return true;
    }
}