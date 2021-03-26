/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

Find the maximum profit you can achieve. You may complete at most two transactions.

Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

 

Example 1:

Input: prices = [3,3,5,0,0,3,1,4]
Output: 6
Explanation: Buy on day 4 (price = 0) and sell on day 6 (price = 3), profit = 3-0 = 3.
Then buy on day 7 (price = 1) and sell on day 8 (price = 4), profit = 4-1 = 3.
Example 2:

Input: prices = [1,2,3,4,5]
Output: 4
Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are engaging multiple transactions at the same time. You must sell before buying again.
Example 3:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
Example 4:

Input: prices = [1]
Output: 0
 

Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 105
*/

/*
https://www.youtube.com/watch?v=a8xKiVTpdks

Arr -> [3,3,5,0,0,3,1,4]
P_l -> [0,0,2,2,2,2,2,3]
P_r -> [4,4,6,6,6,5,5,3]

the reason why we need to calculate the highest price for P_r is because we loop through the original array from last to first and we have to buy first and sell later, so we need to backward the process!
*/

//int.MaxValue

public class Solution {
    public int MaxProfit(int[] prices) {

        int maxPrice = 0;

        int[] P_l = new int[prices.Length];
        int[] P_r = new int[prices.Length];

        int lowest = prices[0];   
        for(int i = 1; i < prices.Length; i++)
        {
            lowest = Math.Min(lowest, prices[i]);
            P_l[i] = Math.Max(P_l[i-1], prices[i] - lowest);
        }

        int highest = prices[prices.Length-1];
        for(int j = prices.Length-2; j >= 0; j--)
        {
            highest = Math.Max(highest , prices[j]);
            P_r[j] = Math.Max(P_r[j+1], highest - prices[j]);
        }
        
        for(int k = 0; k < prices.Length;k++)
        {
            maxPrice = Math.Max(maxPrice, P_l[k] + P_r[k]);
        }

        return maxPrice;
    }
}