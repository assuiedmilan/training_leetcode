namespace LeetCode.Arrays.Extras;

public class MinimumLengthAfterOperations
{
    public int Solution(string s)
    {
        var tracker = new int[26];
        var sum = 0;
        
        foreach (var c in s) tracker[c - 'a']++;
        foreach (var v in tracker) sum += v == 0 ? 0 : v%2 == 0 ? 2:1;

        return sum;
    }    
}
