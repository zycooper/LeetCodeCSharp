/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.
You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

Example 1:
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

Example 2:
Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
 
Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 104
*/
public class Solution {
    //one pass
    public int MaxProfit(int[] prices) {
        
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
        for(int i =0; i < prices.Length;i++)
        {
            if(minPrice > prices[i])
            {
                minPrice = prices[i];
            }
            else if(maxProfit < prices[i] - minPrice)
            {
                maxProfit = prices[i] - minPrice;
            }
        }
        
        return maxProfit;
    }

    public int MaxProfit_2(int[] prices) {
        //wrong answer, since the initial min and max price will stay the same till the end if no criteria matches the if.
        //[7,6,4,3,1]
        int maxProfit = 0;

        int minPrice = prices[0];
        int maxPrice = prices[prices.Length -1];
        for(int l = 0, r = prices.Length-1; l < r;)
        {
            if(minPrice > prices[l])
            {
                minPrice = prices[l];                
            }
            l++;
            if(maxPrice < prices[r])
            {
                maxPrice = prices[r];
                
            }
            r--;
            maxProfit = Math.Max(maxProfit, Math.Abs(prices[l] - prices[r]));
        }

        return maxProfit;
    }
}