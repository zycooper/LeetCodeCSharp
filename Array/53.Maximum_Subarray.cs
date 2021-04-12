/*
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.

Example 2:
Input: nums = [1]
Output: 1

Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23
 
Constraints:

1 <= nums.length <= 3 * 104
-105 <= nums[i] <= 105
*/
public class Solution {
    /*
    Attampt Index: 0
    *********************************************************************************
    Time Range:
    From: 2021-04-21 10:50:00
    To: 2021-04-21 11:11:00
    *********************************************************************************
    Submission Result:
    Runtime: 100 ms, faster than 40.81% of C# online submissions for Maximum Subarray.
    Memory Usage: 26.2 MB, less than 24.42% of C# online submissions for Maximum Subarray.
    *********************************************************************************
    Note:
    Kadane's algorithm
    **********************************************************************************/
    public int MaxSubArray(int[] nums) {
       int Max_SubArray = nums[0];
       int Current_SubArray = nums[0];

       for(int i = 1; i < nums.Length; i++)
       {
           int CurrentNum = nums[i];

           Current_SubArray = Math.Max(nums[i], nums[i] + Current_SubArray);
           Max_SubArray = Math.Max(Max_SubArray, Current_SubArray);
       }

       return Max_SubArray;
    }
}