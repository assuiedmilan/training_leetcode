using System;
using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.NotLeetcode;

/* https://medium.com/@wujido20/advent-of-code-2022-day-6-6f66d3376c08 */
public class StartOfMessageMarker
{
    const int k_WindowsSize = 14;

    public int Solution_BitMask(string s)
    {
        if (s.Length == k_WindowsSize) return k_WindowsSize;
        
        const int binaryOne = 0b1;
        const int maskSize = 32;
        var mask = 0b0;
        var left = 0;

        for (var i = 0; i < k_WindowsSize; i++)
        {
            var bitPosition = s[i] % maskSize;
            var bitShifted = binaryOne << bitPosition;
            mask ^= bitShifted;
        }

        while (BitOperations.PopCount((uint)mask) != k_WindowsSize)
        {
            var leftCharPosition = s[left] % maskSize;
            var rightCharPosition = s[left+k_WindowsSize] % maskSize;
            var excludeLeftShifted = binaryOne << leftCharPosition;
            var includeRightShifted = binaryOne << rightCharPosition;
            mask = mask ^ excludeLeftShifted ^ includeRightShifted;
            left++;
        }

        return left + k_WindowsSize;
    }

    public int Solution(string s)
    {
        if (s.Length == k_WindowsSize) return k_WindowsSize;

        var metCharacters = new HashSet<char>();
        var left = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            duplicateFound = false;
            var sub = s.Substring(left, k_WindowsSize);

            for (var i = sub.Length - 1; i > -1; i--)
            {
                if (!metCharacters.Add(sub[i]))
                {
                    duplicateFound = true;
                    left = left + i + 1;
                    metCharacters.Clear();
                    break;
                }
            }
        }

        return left + k_WindowsSize;
    }
}
