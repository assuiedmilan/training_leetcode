namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/add-binary/description/ */
public class AddBinary
{
    public string Solution(string a, string b)
    {
        const char zero = '0';
        const char one = '1';
        
        var (shortNumber, longNumber) = a.Length < b.Length ? (a, b) : (b, a);
        var delta = longNumber.Length - shortNumber.Length;
        var carry= zero;
        
        var ans = new char[longNumber.Length + 1];
        ans[0] = one;

        for (var i = longNumber.Length - 1; i > -1; i--)
        {
            var first = longNumber[i];
            var second = i < delta ? zero : shortNumber[i - delta];

            var sum = (first - '0') + (second - '0') + (carry - '0');
            var res = (sum & 1) == 1 ? one : zero;
            carry = sum >> 1 == 1 ? one : zero;

            ans[i+1] = res;
        }

        return carry == one ? new string(ans) : new string(ans[1..]);
    }
}