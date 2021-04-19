/*
Given an integer array nums, return the length of the longest strictly increasing subsequence.
A subsequence is a sequence that can be derived from an array by deleting some or no elements without changing the order of the remaining elements. 
For example, [3,6,2,7] is a subsequence of the array [0,3,1,6,2,2,7].

Example 1:
Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.

Example 2:
Input: nums = [0,1,0,3,2,3]
Output: 4

Example 3:
Input: nums = [7,7,7,7,7,7,7]
Output: 1

Constraints:
1 <= nums.length <= 2500
-104 <= nums[i] <= 104

Follow up:

Could you come up with the O(n2) solution?
Could you improve it to O(n log(n)) time complexity?
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-16 16:27
 To: 2021-04-19 13:55
 *********************************************************************************
 Submission Result:
    Runtime: 172 ms, faster than 65.04% of C# online submissions for Longest Increasing Subsequence.
    Memory Usage: 25.9 MB, less than 93.22% of C# online submissions for Longest Increasing Subsequence.
 *********************************************************************************
 Note: 
    before writing code: this question is a typical Dynamic Programming - DP question
    youtube: huahua
    DP: create a int[] to store the lonest length till current i, then create another loop through j which j < i, then find the biggest j, dp[i] = thisvalue +1
    final result is the max of this dp int[]
 *********************************************************************************/
public class Solution {
    public int LengthOfLIS(int[] nums) {
        if(nums.Length == 0 ){ return 0;}

        int[] dp = new int[nums.Length];
        dp[0] = 1;

        int maxResult = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            int max_dp_value_before_i = 0;

            for(int j = 0; j < i; j++)
            {
                //loop through all items before i and find the biggest value where nums[i] > nums[j]
                if(nums[i] > nums[j])
                {
                    //since j < i, so dp[j] is always valid
                    max_dp_value_before_i = Math.Max(max_dp_value_before_i, dp[j]);
                }
            }

            dp[i] = max_dp_value_before_i + 1;
            maxResult = Math.Max(dp[i],maxResult);            
        }
        return maxResult;
    }
}