/*
There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.
You are giving candies to these children subjected to the following requirements:
Each child must have at least one candy.
Children with a higher rating get more candies than their neighbors.
Return the minimum number of candies you need to have to distribute the candies to the children.

Example 1:
Input: ratings = [1,0,2]
Output: 5
Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.

Example 2:
Input: ratings = [1,2,2]
Output: 4
Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
The third child gets 1 candy because it satisfies the above two conditions.
 
Constraints:
n == ratings.length
1 <= n <= 2 * 104
0 <= ratings[i] <= 2 * 104
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-21 11:10
 To: 2021-04-21 11:50
 *********************************************************************************
 Submission Result:
  Runtime: 112 ms, faster than 57.14% of C# online submissions for Candy.
Memory Usage: 31 MB, less than 15.31% of C# online submissions for Candy.
 *********************************************************************************
 Note: 
   two array, left records the result compare to left, right records the result compare to right,
   then loop through ratings, for each element, get the max between left and right, at last sum up
 *********************************************************************************/
 public class Solution {
    public int Candy(int[] ratings) {
        int result = 0;

        if(ratings == null || ratings.Length == 0){return result;}

        int[] left = new int[ratings.Length];
        int[] right = new int[ratings.Length];
        left[0] = 1;
        right[ratings.Length - 1] = 1;

        for(int i = 1; i < ratings.Length; i++)
        {
            if(ratings[i] > ratings[i - 1])
            {
                left[i] = left[i-1] + 1;
            }
            else
            {
                left[i] = 1;
            }
        }

        for(int j = ratings.Length - 2; j >= 0;j--)
        {
            if(ratings[j] > ratings[j + 1])
            {
                right[j] = right[j+1] +1;
            }
            else
            {
                right[j] = 1;
            }
        }

        for(int k = 0; k < ratings.Length;k++)
        {
            result += Math.Max(left[k],right[k]);
        }

        return result;
    }
}