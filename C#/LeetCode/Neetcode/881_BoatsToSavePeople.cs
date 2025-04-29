using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/boats-to-save-people/ */
public class BoatsToSavePeople
{
    public int Solution(int[] people, int limit)
    {
        var res = 0;
        var l = 0;
        var r = people.Length - 1;

        Array.Sort(people);

        while (l <= r) {
            var remain = limit - people[r];
            r -= 1;
            res += 1;

            if (l <= r && remain >= people[l]) {
                l += 1;
            }
        }

        return res;
    }

}