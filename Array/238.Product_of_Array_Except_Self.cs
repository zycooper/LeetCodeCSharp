/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

Example 1:
Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:
Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 
Constraints:
2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

Follow up:
Could you solve it in O(n) time complexity and without using division?
Could you solve it with O(1) constant space complexity? (The output array does not count as extra space for space complexity analysis.)
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-12 15:09
 To: 2021-04-12 15:19
 *********************************************************************************
 Submission Result:
 Runtime: 276 ms, faster than 64.29% of C# online submissions for Product of Array Except Self.
 Memory Usage: 39.5 MB, less than 64.54% of C# online submissions for Product of Array Except Self.
 *********************************************************************************
 Note: 
 draw two arrarys
 Ori:   [1,2,3,4]
 left:  [1,1,2,6]
 right: [24,12,4,1]
 result:[24,12,8,6] 
 *********************************************************************************/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        int temp =1;
        //left side
        for(int i = 0; i < nums.Length;i++)
        {
            result[i] = temp;
            temp *= nums[i];
        }
        //right side
        temp = 1;
        for(int i = nums.Length -1; i >=0 ;i--)
        {
            result[i] *= temp;
            temp *= nums[i];
        }

        return result;
    }
}