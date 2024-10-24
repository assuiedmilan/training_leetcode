using System;
using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.SlidingWindows;

public static class StartOfMessageMarker
{
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
    const int WindowsSize = 14;

    public static int FindStartOfMessageIndex_BitMask(string s)
    {
        const int binaryOne = 0b1;
        const int maskSize = 32;
        var mask = 0b0;
        var left = 0;

        for (var i = 0; i < WindowsSize; i++)
        {
            var bitPosition = s[i] % maskSize;
            var bitShifted = binaryOne << bitPosition;
            mask ^= bitShifted;
        }

        while (BitOperations.PopCount((uint)mask) != WindowsSize)
        {
            var leftCharPosition = s[left] % maskSize;
            var rightCharPosition = s[left+WindowsSize] % maskSize;
            var excludeLeftShifted = binaryOne << leftCharPosition;
            var includeRightShifted = binaryOne << rightCharPosition;
            mask = mask ^ excludeLeftShifted ^ includeRightShifted;
            left++;
        }

        return left + WindowsSize;
    }

    public static int FindStartOfMessageIndex(string s)
    {
        if (s.Length == WindowsSize) return WindowsSize;

        var metCharacters = new HashSet<char>();
        var left = 0;
        var totalLoopIterations = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            duplicateFound = false;
            var sub = s.Substring(left, WindowsSize);

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

        Console.Out.WriteLine($"Message found in {s} after maker {s.Substring(left, WindowsSize)} starting at position {left + WindowsSize + 1} after {totalLoopIterations} iterations");
        return left + WindowsSize;
    }

    public static int FindStartOfMessageIndex_StaticArray(string s)
    {
        if (s.Length == WindowsSize) return WindowsSize;

        var metCharacters = new char[WindowsSize];
        var left = 0;
        var totalLoopIterations = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            int loopIndex;
            var sub = s.Substring(left, WindowsSize);

            duplicateFound = false;

            for(loopIndex = sub.Length -1; loopIndex > -1; loopIndex--)
            {
                var c = sub[loopIndex];
                int arrayIndex;

                /* It is un-necessary to clean/reallocate the array since we only test against indexes that are located at the right of the loopIndex.
                 * By construction, the index located at loopIndex cannot contain a duplicate as it is either empty, or contains an old value. Hence, it must always be updated.
                 *
                 * Step-by-step:
                 * When looking for sub[WindowsSize - 1] in bar, the loop is not entered due to loopIndex being equal to WindowsSize - 1, so bar[WindowsSize - 1] is updated
                 * Then for sub[WindowsSize - 2] only bar[WindowsSize - 1] will be checked for duplicate and bar[WindowsSize - 2] updated
                 * This until sub[0] for which we will check bar[WindowsSize - 1] to bar[1] only. If we get there, no duplicate where found.
                 *
                 * This trick makes the algorithm approx 4-5x faster vs reallocating / clearing the array.
                 */
                for(arrayIndex = metCharacters.Length - 1; arrayIndex > loopIndex; arrayIndex--)
                {
                    totalLoopIterations++;
                    if (metCharacters[arrayIndex] != c) continue;
                    duplicateFound = true;
                    left = left + loopIndex + 1;
                    break;
                }

                if (duplicateFound) break;
                metCharacters[arrayIndex] = c;
            }
        }

        Console.Out.WriteLine($"Message found in {s} after maker {s.Substring(left, WindowsSize)} starting at position {left + WindowsSize + 1} after {totalLoopIterations} iterations");
        return left + WindowsSize;
    }

    public static int FindStartOfMessageIndex_StaticArray_NoSubstring(string s)
    {
        if (s.Length == WindowsSize) return WindowsSize;

        var metCharacters = new char[WindowsSize];
        var left = 0;
        var totalLoopIterations = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            int loopIndex;
            duplicateFound = false;

            for(loopIndex = left + WindowsSize - 1; loopIndex > left - 1; loopIndex--)
            {
                var c = s[loopIndex];
                int arrayIndex;

                /* It is un-necessary to clean/reallocate the array since we only test against indexes that are located at the right of the loopIndex.
                 * By construction, the index located at loopIndex cannot contain a duplicate as it is either empty, or contains an old value. Hence, it must always be updated.
                 *
                 * Step-by-step:
                 * When looking for sub[WindowsSize - 1] in bar, the loop is not entered due to loopIndex being equal to WindowsSize - 1, so bar[WindowsSize - 1] is updated
                 * Then for sub[WindowsSize - 2] only bar[WindowsSize - 1] will be checked for duplicate and bar[WindowsSize - 2] updated
                 * This until sub[0] for which we will check bar[WindowsSize - 1] to bar[1] only. If we get there, no duplicate where found.
                 *
                 * This trick makes the algorithm approx 4-5x faster vs reallocating / clearing the array.
                 */
                for(arrayIndex = metCharacters.Length - 1; arrayIndex > loopIndex - left; arrayIndex--)
                {
                    totalLoopIterations++;
                    if (metCharacters[arrayIndex] != c) continue;
                    duplicateFound = true;
                    left = loopIndex + 1;
                    break;
                }

                if (duplicateFound) break;
                metCharacters[arrayIndex] = c;
            }

        }

        Console.Out.WriteLine($"Message found in {s} after maker {s.Substring(left, WindowsSize)} starting at position {left + WindowsSize + 1} after {totalLoopIterations} iterations");
        return left + WindowsSize;
    }
}
