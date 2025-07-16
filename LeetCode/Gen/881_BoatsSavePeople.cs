using System;

namespace LeetCode.Gen;

/*
 * https://leetcode.com/problems/boats-to-save-people/description/
 * 881. Boats to Save People
 */

/*
 * You are given an array people where people[i] is the weight of the ith person, and an infinite number of boats where
 * each boat can carry a maximum weight of limit. Each boat carries at most two people at the same time, provided the
 * sum of the weight of those people is at most limit.
 * Return the minimum number of boats to carry every given person.
 */

public class BoatsSavePeople881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        var left = 0;
        var right = people.Length - 1;
        var numberOfBoats = 0;

        while (left <= right)
        {
            if (people[left] + people[right] <= limit)
            {
                left++;
            }
            right--;
            numberOfBoats++;
        }

        return numberOfBoats;
    }
}
