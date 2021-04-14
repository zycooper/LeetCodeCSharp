/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.

Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:
Input: nums = [0]
Output: [0]
 
Constraints:
1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-9:32
 To: 2021-04-9:45
 *********************************************************************************
 Submission Result:
    Runtime: 228 ms, faster than 97.52% of C# online submissions for Move Zeroes.
    Memory Usage: 32.5 MB, less than 46.06% of C# online submissions for Move Zeroes.
 *********************************************************************************
 Note: 
 switch the i and left non zero position
 *********************************************************************************/

public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1){return;}

        int left_zero_index = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                int temp = nums[i];
                nums[i]  = nums[left_zero_index];
                nums[left_zero_index++] = temp;
            }
        }
    }
}