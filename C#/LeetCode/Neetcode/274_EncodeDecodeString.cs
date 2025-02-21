using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/encode-and-decode-strings/description/ */
public class EncodeDecodeString
{
    const char k_NonUtf8Character = '\u00C0';

    public string Encode(IList<string> strs)
    {
        return strs.Count == 0 ? null : string.Join(k_NonUtf8Character, strs);
    }

    public List<string> Decode(string s)
    {
        return s switch
        {
            null => [],
            "" => [""],
            _ => [..s.Split(k_NonUtf8Character)]
        };
    }
}