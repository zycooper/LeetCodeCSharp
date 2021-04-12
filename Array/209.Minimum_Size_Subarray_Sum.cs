/*
Given an array of positive integers nums and a positive integer target, 
return the minimal length of a contiguous subarray [numsl, numsl+1, ..., numsr-1, numsr] of which the sum is greater than or equal to target. 
If there is no such subarray, return 0 instead.

Example 1:
Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.

Example 2:
Input: target = 4, nums = [1,4,4]
Output: 1

Example 3:
Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-12 14:04
 To: 2021-04-12 14:25
 *********************************************************************************
 Submission Result:
    Runtime: 100 ms, faster than 44.12% of C# online submissions for Minimum Size Subarray Sum.
    Memory Usage: 26.2 MB, less than 43.46% of C# online submissions for Minimum Size Subarray Sum.
 *********************************************************************************
 Note: 
 two pointer
 basically it is a two pointer or sliding whindow, left is the slower one and the right is the faster one,
 when the sum to current right is equal or greater then target, 
 assign the result to the current length(right- left +1) 
 then start to minus nums[left] and repeat the step above, if the sum below target, keep moving the right(faster) one to the limit of the original array Length
 "MaxValue"
 *********************************************************************************/
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int left = 0;
        int sum = 0;
        int result = int.MaxValue;

        for(int right =0; right < nums.Length; right++)
        {
            sum += nums[right];

            while(sum >= target)
            {
                result = Math.Min(result, right - left + 1);
                sum -= nums[left];
                left++;
                
                /*
                or
                result = Math.Min(result, right - left + 1);
                sum -= nums[left++];                
                */
            }
        }

        return result == int.MaxValue? 0: result;
    }
}