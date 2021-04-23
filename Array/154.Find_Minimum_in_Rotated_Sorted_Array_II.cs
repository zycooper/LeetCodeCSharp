/*
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. 
For example, the array nums = [0,1,4,4,5,6,7] might become:
[4,5,6,7,0,1,4] if it was rotated 4 times.
[0,1,4,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
Given the sorted rotated array nums that may contain duplicates, return the minimum element of this array.

Example 1:
Input: nums = [1,3,5]
Output: 1

Example 2:
Input: nums = [2,2,2,0,1]
Output: 0

Constraints:
n == nums.length
1 <= n <= 5000
-5000 <= nums[i] <= 5000
nums is sorted and rotated between 1 and n times.
*/

 /********************************************************************************
 Solution Category: 
 | Binary Search |
 *********************************************************************************
 Time Range:
 From: 2021-04-23 15:20
 To: 2021-04-23 15:43
 *********************************************************************************
 Submission Result:
    Runtime: 96 ms, faster than 60.20% of C# online submissions for Find Minimum in Rotated Sorted Array II.
    Memory Usage: 25.6 MB, less than 67.35% of C# online submissions for Find Minimum in Rotated Sorted Array II.
 *********************************************************************************
 Note: 
    when move left, keep note you should move the left to the one more right position by mid
    left = mid + 1;
 *********************************************************************************/
public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while(left < right)
        {
            //because there is duplicate, so use < instead of <=
            int mid = left + (right - left)/2;

            if(nums[mid] < nums[right])
            {
                right = mid;
            }
            else if(nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right--;
            }
        }

        return nums[left];
    }
}