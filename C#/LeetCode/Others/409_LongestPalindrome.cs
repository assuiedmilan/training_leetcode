namespace LeetCode.Others;

/* https://leetcode.com/problems/longest-palindrome/description/ */
public class LongestPalindrome
{   
    public string Solution(string s)
    {
        //To check all strings in ONE pass, we consider the string starting at index i and iterate along this string
        //If *i* is 0, string is single character, and then it's a palindrome size 1
        //If *i* is 1, string is 3 characters (assume array is not right bounded here) and we check for palindrome within, abb would return size 2
        //When middle is passed, size of the string will reduce. Under some conditions, the loop could be halted (no more possibility of finding a longer palindrome when the current size is above half the size of the string and the palindrome is broken).
        //This way until *i* is n-1 (right bound of the array), which is also a palindrome size 1, could be not checked
        //
        //Time Complexity of O(n^2) and Space Complexity of O(1)
        var resLen = 0;
        var res = "";
        
        for(var i=0; i<s.Length; i++)
        {
            var l = i;
            var r = i;
            
            while(l>=0 && r <s.Length && s[l] == s[r])
            {
                if (r - l + 1 > resLen)
                {
                    resLen = r-l+1;
                    res = s.Substring(l, resLen);
                }
                l -= 1;
                r += 1;
            }
            
            l = i;
            r = i+1;
            
            while(l>=0 && r <s.Length && s[l] == s[r])
            {
                if (r - l + 1 > resLen)
                {
                    resLen = r-l+1;
                    res = s.Substring(l, resLen);
                }
                l -= 1;
                r += 1;
            }
        }
        
        return res;
    }
}