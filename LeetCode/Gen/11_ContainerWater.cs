using System;
namespace LeetCode.Gen;

/*
 * https://leetcode.com/problems/container-with-most-water/
 * 11. Container With Most Water
 */

/*
 * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of
 * the ith line are (i, 0) and (i, height[i]).
 * Find two lines that together with the x-axis form a container, such that the container contains the most water.
 * Return the maximum amount of water a container can store.
 * Notice that you may not slant the container.
 */

public class ContainerWater11
{
  public int MaxArea(int[] height)
  {
      var maxArea = 0;
      var left = 0;
      var right = height.Length - 1;

      while (left <= right)
      {
          var area = (right-left) * Math.Min(height[left], height[right]);
          maxArea = Math.Max(area, maxArea);
          if (height[left] < height[right])
          {
              left++;
          }
          else
          {
              right--;
          }
      }
      return maxArea;
  }
}
