using System;
using System.Collections.Generic;

namespace LeetCode.Gen;

public class F4Sum18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var solutions = new List<IList<int>>();

        if(nums.Length < 4) return solutions;
        Array.Sort(nums);



        Print(solutions);

        return solutions;
    }

    void Print(List<IList<int>> solutions)
    {
        Console.WriteLine("=======");
        Console.Write("[");
        for(int i = 0; i < solutions.Count; i++)
        {
            Console.Write("[");
            for (int j = 0; j < solutions[i].Count; j++)
            {
                Console.Write(solutions[i][j]);
                if(j != solutions.Count)
                    Console.Write(", ");
            }
            if(i != solutions.Count - 1)
                Console.Write("], ");
        }
        Console.Write("]]");
        Console.WriteLine("\n");
    }
}
