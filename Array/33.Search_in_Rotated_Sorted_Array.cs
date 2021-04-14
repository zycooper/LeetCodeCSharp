/*
There is an integer array nums sorted in ascending order (with distinct values).
Prior to being passed to your function, 
nums is rotated at an unknown pivot index k (0 <= k < nums.length) 
such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). 
For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
Given the array nums after the rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

Example 1:
Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4

Example 2:
Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1

Example 3:
Input: nums = [1], target = 0
Output: -1

Constraints:
1 <= nums.length <= 5000
-104 <= nums[i] <= 104
All values of nums are unique.
nums is guaranteed to be rotated at some pivot.
-104 <= target <= 104
*/

 /********************************************************************************
 Attampt Times: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-14 16:16
 To: 2021-04-14 16:40
 *********************************************************************************
 Submission Result:
    Runtime: 84 ms, faster than 97.44% of C# online submissions for Search in Rotated Sorted Array.
    Memory Usage: 25.4 MB, less than 32.58% of C# online submissions for Search in Rotated Sorted Array.
 *********************************************************************************
 Note: 
https://www.cnblogs.com/grandyang/p/4325648.html
 *********************************************************************************/
public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int mid = left + (right - left)/2;
            if(nums[mid] == target){ return mid;}

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
            else
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
        }

        return -1;
    }
}