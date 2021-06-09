/*
Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]
 

Constraints:

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100
*/

 /********************************************************************************
 Solution Category: 
 Stack
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-09
 *********************************************************************************
 Submission Result:
   Runtime: 676 ms, faster than 19.32% of C# online submissions for Daily Temperatures.
Memory Usage: 48.7 MB, less than 12.77% of C# online submissions for Daily Temperatures.
 *********************************************************************************

 *********************************************************************************/
 public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //stack stores the index of temperatures
        Stack<int> stack = new Stack<int>();
        int[] res = new int[temperatures.Length];
        
        for(int i = temperatures.Length - 1; i >= 0 ; i--)
        {
            while(stack.Count != 0 && temperatures[i] >= temperatures[stack.Peek()])
            {
                stack.Pop();
            }
            
            if(stack.Count == 0)
            {
                res[i] = 0;
            }
            else
            {
                res[i] = stack.Peek() - i;
            }
            
            stack.Push(i);
        }
        
        return res;
    }
}