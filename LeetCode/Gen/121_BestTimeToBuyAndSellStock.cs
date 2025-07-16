namespace LeetCode.Gen;

public class BestTimeToBuyAndSellStock121
{
    /*
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
     * 121. Best Time to Buy and Sell Stock
     */

    /*
     * You are given an array prices where prices[i] is the price of a given stock on the ith day.
     * You want to maximize your profit by choosing a single day to buy one stock and choosing a different day
     * in the future to sell that stock.
     * Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
     */

    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var minPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if(prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}
