using System;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/ */
public class BestTimeToBuyAndSellStock
{
    public int Solution(int[] prices)
    {
        var minPrice = prices[0];
        var maxProfit = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else
                maxProfit = maxProfit - (prices[i] - minPrice) > 0 ? maxProfit : prices[i] - minPrice;
        }

        return maxProfit;
    }
}