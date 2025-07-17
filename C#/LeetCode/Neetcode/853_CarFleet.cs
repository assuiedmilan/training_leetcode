using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/car-fleet/description/ */
public class CarFleet
{
    public int Solution(int target, int[] position, int[] speed)
    {
        var cars = new (int p, int s)[speed.Length];
        double bn = -1;
        var count = 0;

        for(var i=0; i<speed.Length; i++)
        {
            cars[i] = ((position[i], speed[i]));
        }

        Array.Sort(cars,((c1, c2)=>c2.p.CompareTo(c1.p))); 
        for(var i=0; i<speed.Length; i++)
        {
            var time = ((target-cars[i].p)/(double)cars[i].s);
            if(time > bn)
            {
                bn = time;
                count++;
            }
        }
        return count;
    }    
}
