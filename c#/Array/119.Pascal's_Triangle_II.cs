/*
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:
Input: rowIndex = 3
Output: [1,3,3,1]

Example 2:
Input: rowIndex = 0
Output: [1]

Example 3:
Input: rowIndex = 1
Output: [1,1]
 

Constraints:

0 <= rowIndex <= 33
*/

/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 
*********************************************************************************
Submission Result:

*********************************************************************************
Note: 

*********************************************************************************/
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        //modified on Q118, and beat 60.89% and consumes 204ms
        int numRows= rowIndex+1;
        int[] pre = new int[] { 1 };
        int[][] list = new int[numRows][];
        list[0] = pre;            

            if (numRows > 1)
            {
                for (int i = 1; i < numRows; i++)
                {                  
                    int[] temp_arr = new int[i + 1];

                    //first and last item
                    temp_arr[0] = 1;
                    temp_arr[temp_arr.Length-1] = 1;
                    
                    if (i>1)
                    {
                        for (int j = 1; j < temp_arr.Length - 1; j++)
                        {
                            temp_arr[j] = pre[j - 1] + pre[j];
                        }
                       
                    }
                    pre = temp_arr;
                    list[i] = temp_arr;
                }
            }
        return list[rowIndex];
    }
}