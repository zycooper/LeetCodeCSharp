/*
You are given a 2D array of integers envelopes where envelopes[i] = [wi, hi] represents the width and the height of an envelope.
One envelope can fit into another if and only if both the width and height of one envelope are greater than the other envelope's width and height.
Return the maximum number of envelopes you can Russian doll (i.e., put one inside the other).
Note: You cannot rotate an envelope.

Example 1:
Input: envelopes = [[5,4],[6,4],[6,7],[2,3]]
Output: 3
Explanation: The maximum number of envelopes you can Russian doll is 3 ([2,3] => [5,4] => [6,7]).

Example 2:
Input: envelopes = [[1,1],[1,1],[1,1]]
Output: 1

Constraints:
1 <= envelopes.length <= 5000
envelopes[i].length == 2
1 <= wi, hi <= 104
*/

 /********************************************************************************
 Solution Category: 
 | Sort + LIT(Longest Increasing Subsequence) |
 *********************************************************************************
 Time Range:
 From: 2021-04-23 16:00
 To: 2021-04-23 16:20
 *********************************************************************************
 Submission Result:
Runtime: 408 ms, faster than 68.22% of C# online submissions for Russian Doll Envelopes.
Memory Usage: 30.5 MB, less than 53.06% of C# online submissions for Russian Doll Envelopes.
 *********************************************************************************
 Note: 
    Link to Q300 longest increasing subsequence

    two dimension array sort:
    Array.Sort(envelopes, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

    for LIS: dp[0] = 1, int result = 1 since self is count as 1 already
    and always compare dp[index] with current max
 *********************************************************************************/
public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        //sort this 2d array
        Array.Sort(envelopes, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

        //now the array is asc base on width, now find the LIS
        int result = 1;
        int[] dp = new int[envelopes.Length];
        dp[0] = 1;

        for(int i = 1; i < envelopes.Length; i++)
        {
            int max_value_before_i = 0;
            for(int j = 0; j < i; j++)
            {
                if(envelopes[i][1] > envelopes[j][1])
                {
                    max_value_before_i = Math.Max(dp[j],max_value_before_i);
                }
            }

            dp[i] = max_value_before_i + 1;
            result = Math.Max(result, dp[i]);
        }

        return result;
    }
}