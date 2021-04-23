/*
Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
It is guaranteed that the answer will fit in a 32-bit integer.
A subarray is a contiguous subsequence of the array.

Example 1:
Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.

Example 2:
Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.

Constraints:
1 <= nums.length <= 2 * 104
-10 <= nums[i] <= 10
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
*/

 /********************************************************************************
 Solution Category: 2
 *********************************************************************************
 Time Range:
 From: 2021-04-12 15:56
 To: 2021-04-12 22:43
 *********************************************************************************
 Submission Result:
    Runtime: 100 ms, faster than 14.32% of C# online submissions for Maximum Product Subarray.
    Memory Usage: 25.7 MB, less than 8.22% of C# online submissions for Maximum Product Subarray.
 *********************************************************************************
 Note: 
    every time, choose the max between current element * previous max element, current element * previous min element and current element since negative value could twist the result.
 *********************************************************************************/
 public class Solution {
     public int MaxProduct(int[] nums) {

       //need to add one more param min_curr since the negative could be maximum if product by another negative
        int[] max_cur = new int[nums.Length];
        int[] min_cur = new int[nums.Length];

        max_cur[0] = nums[0];
        min_cur[0] = nums[0];

        for(int i = 1; i < nums.Length;i++)
        {
            // max_cur[i] = Math.Max(Math.Max(nums[i] * max_cur[i-1], max_cur[i-1]),nums[i]);
            // min_cur[i] = Math.Min(Math.Min(nums[i] * min_cur[i-1], min_cur[i-1]),nums[i]);

            max_cur[i] = Math.Max(Math.Max(nums[i] * max_cur[i-1], nums[i] * min_cur[i-1]),nums[i]);
            min_cur[i] = Math.Min(Math.Min(nums[i] * min_cur[i-1], nums[i] * max_cur[i-1]),nums[i]);
        }

        return max_cur.Max();
    }

     //doesn't work because the first element could be negative
    public int MaxProduct_old(int[] nums) {
        int max_subArray = 1;
        int cur_subArray = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            cur_subArray *= nums[i];

            max_subArray = Math.Max(max_subArray,cur_subArray);
        }

        return max_subArray;
    }
}