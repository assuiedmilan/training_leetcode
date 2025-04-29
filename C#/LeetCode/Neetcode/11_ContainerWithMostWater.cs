using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/container-with-most-water/ */
public class ContainerWithMostWater
{
    public int Solution(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = -1;

        while (left < right)
        {
            var heightLeft = height[left];
            var heightRight = height[right];
            var area = -1;
            if (heightLeft < heightRight)
            {
                area = (right - left) * heightLeft;
                maxArea = maxArea > area ? maxArea : area;
                left++;
                continue;

            }
            area = (right - left) * heightRight;
            maxArea = maxArea > area ? maxArea : area;
            right--;
        }
        return maxArea;
    }

}