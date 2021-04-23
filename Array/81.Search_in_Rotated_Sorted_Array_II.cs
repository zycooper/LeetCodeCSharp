/*
There is an integer array nums sorted in non-decreasing order (not necessarily with distinct values).
Before being passed to your function, nums is rotated at an unknown pivot index k (0 <= k < nums.length) 
such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). 
For example, [0,1,2,4,4,4,5,6,6,7] might be rotated at pivot index 5 and become [4,5,6,6,7,0,1,2,4,4].
Given the array nums after the rotation and an integer target, return true if target is in nums, or false if it is not in nums.

Example 1:
Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true
Example 2:
Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false

Constraints:
1 <= nums.length <= 5000
-104 <= nums[i] <= 104
nums is guaranteed to be rotated at some pivot.
-104 <= target <= 104
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-14 16:41
 To:  2021-04-14 16:41
 *********************************************************************************
 Submission Result:
Runtime: 96 ms, faster than 59.12% of C# online submissions for Search in Rotated Sorted Array II.
Memory Usage: 25.8 MB, less than 78.62% of C# online submissions for Search in Rotated Sorted Array II.
 *********************************************************************************
 Note: 
only different is the right--, when nums[mid] == nums[right], move right index to left, and keep going, until there is equal one
 *********************************************************************************/
public class Solution {
    public bool Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int mid = left + (right - left)/2;
            if(nums[mid] == target){ return true;}

            if(nums[mid] < nums[right])
            {
                //right part is sorted
                if(nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            else if(nums[mid] > nums[right])
            {
                //left part is sorted
                if(nums[mid] > target && nums[left] <= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                right--;
            }
        }

        return false;
    }
}