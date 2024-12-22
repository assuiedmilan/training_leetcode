using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.SlidingWindows;

/*
 * A start of message marker is a sequence in a string which consist of 14 distinct characters.
 * The actual message starts right after the marker.
 *
 * The objective is to find the number of characters that need to be processed to detect the start of the message.
 *
 * Here are the first positions for all the below examples:
 *
 *  - mjqjpqmgbljsphdztnvjfqwrcgsmlb: Message starts after 19 characters
 *  - bvwbjplbgvbhsrlpgdmjqwftvncz: Message starts after 23 characters
 *  - nppdvjthqldpwncqszvftbrmjlhg: Message starts after 23 characters
 *  - nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg: Message starts after 29 characters
 *  - zcfzfwzzqfrljwlrfnpqdbhtmscgvjw: Message starts after 26 characters
 *
 * See video: https://www.youtube.com/watch?v=Rxd3W1wnlEc
 */
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
        var totalLoopIterations = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            duplicateFound = false;
            var sub = s.Substring(left, k_WindowsSize);

            for (var i = sub.Length - 1; i > -1; i--)
            {
                totalLoopIterations++;
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
