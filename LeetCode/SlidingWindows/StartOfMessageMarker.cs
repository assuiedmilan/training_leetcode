using System;
using System.Collections.Generic;

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

    public static int FindStartOfMessageIndex(string s)
    {
        var metCharacters = new HashSet<char>();
        var left = 0;
        var duplicateFound = true;

        while (duplicateFound)
        {
            duplicateFound = false;
            var sub = s.Substring(left, WindowsSize);

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
        return left + WindowsSize;
    }

    public static int FindStartOfMessageIndex_StaticArray(string s)
    {
        return -1;
    }
}
