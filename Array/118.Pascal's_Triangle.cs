/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]

Constraints:
1 <= numRows <= 30
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        //first array
        //this one all by my self, only beat 63.64% and consumes 208 ms
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
        return list;
    }
}