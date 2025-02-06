namespace LeetCode.Gen;

// https://leetcode.com/problems/valid-palindrome-ii/description/
// 680. Valid Palindrome II

public class ValidPalindrome680
{
    public bool ValidPalindrome(string s)
    {
        var l = 0;
        var r = s.Length - 1;

        while (l <= r)
        {
            if (s[l] == s[r])
            {
                l++;
                r--;
            }
            else
            {
                return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
            }
        }

        return true;
    }

    bool IsPalindrome(string s, int l, int r)
    {
        while (l <= r)
        {
            if (s[l] == s[r])
            {
                l++;
                r--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
