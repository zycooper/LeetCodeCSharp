/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.
Find the maximum profit you can achieve. You may complete as many transactions as you like 
(i.e., buy one and sell one share of the stock multiple times) with the following restrictions:
After you sell your stock, you cannot buy stock on the next day (i.e., cooldown one day).
Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

Example 1:
Input: prices = [1,2,3,0,2]
Output: 3
Explanation: transactions = [buy, sell, cooldown, buy, sell]

Example 2:
Input: prices = [1]
Output: 0

Constraints:

1 <= prices.length <= 5000
0 <= prices[i] <= 1000
*/
 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-04-21 10:25
 *********************************************************************************
 Submission Result:
    
    Runtime: 96 ms, faster than 45.71% of C# online submissions for Best Time to Buy and Sell Stock with Cooldown.
Memory Usage: 25.3 MB, less than 43.81% of C# online submissions for Best Time to Buy and Sell Stock with Cooldown.
 *********************************************************************************
 Note: 
    DP
    https://en.wikipedia.org/wiki/Finite-state_machine finite-state machine

    two state: hold and unhold
    hold:max-profit if by the end of ith day we hold stock
    unhold:max-profit if by the end of ith day we DON'T hold stock

    transation situation:P

    if hold:
    1. Buy stock today          ----->  unhold[i-2] - prices[i] ----->  even if you sell stock more than i-2, unhold[i-2] will be the same with with unhold[i-n] or unhold[i-1] because unhold it anyway
    2. Didn't buy stock today   ----->  hold[i-1]               ----->

    if unhold:
    1. Sell stock today         ----->  hold[i-1] + prices[i]   ----->
    2. Didn't sell stock today  ----->  unhold[i-1]             ----->
 *********************************************************************************/

public class Solution {
    public int MaxProfit(int[] prices) {              
        if(prices == null || prices.Length <= 1){return 0;}
        int[] hold = new int[prices.Length];
        int[] unhold = new int[prices.Length];

        //initial hold and unhold
        hold[0] = -prices[0];
        hold[1] = Math.Max(-prices[0],-prices[1]);

        unhold[0] = 0;

        for(int i = 1;i < prices.Length;i++)
        {
            if(i > 1)
            {
                hold[i] = Math.Max(unhold[i-2] - prices[i] , hold[i-1]);
            }

            unhold[i] = Math.Max(hold[i-1] + prices[i] , unhold[i-1]);
        }

        return unhold[unhold.Length - 1];
    }
}