/*
Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
If target is not found in the array, return [-1, -1].
Follow up: Could you write an algorithm with O(log n) runtime complexity?

Example 1:
Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]

Example 2:
Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]

Example 3:
Input: nums = [], target = 0
Output: [-1,-1]

Constraints:
0 <= nums.length <= 105
-109 <= nums[i] <= 109
nums is a non-decreasing array.
-109 <= target <= 109
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-15 10:09
 To: 2021-04-15 10:23
 *********************************************************************************
 Submission Result:
    Runtime: 240 ms, faster than 84.08% of C# online submissions for Find First and Last Position of Element in Sorted Array.
    Memory Usage: 32.6 MB, less than 76.84% of C# online submissions for Find First and Last Position of Element in Sorted Array.
 *********************************************************************************
 Note: 
nothing special, just find one of the target, then search from this postion toward left and right to the first element that is not target
new function doesn't speed up tho
 *********************************************************************************/
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        bool found = false;

        while(left <= right)
        {
            mid = left + (right- left)/2;

            if(nums[mid] == target)
            {
                found=true;
                break;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;                
            }
            else
            {
                right = mid -1;
            }
        }

        //404
        if(!found){ return new int[2]{-1,-1};}

        //mid is one of the target, start from this position, and search in left and right bound        
        /*below is the old one
         left = mid;
        right = mid;
        //left bound
        while(left >=0)
        {
            if(nums[left] == target)
            {
                //still the same
                left--;
            }
            else
            {
                break;
            }
        }        
        //right bound
        while(right < nums.Length)
        {
            if(nums[right] == target)
            {
                //still the same
                right++;
            }
            else
            {
                break;
            }
        }

        return new int[]{left+1,right-1};
        */
        /*below is new         
        Runtime: 240 ms, faster than 84.08% of C# online submissions for Find First and Last Position of Element in Sorted Array.
        Memory Usage: 32.6 MB, less than 53.08% of C# online submissions for Find First and Last Position of Element in Sorted Array.
        */
        int l = mid;
        int r = mid;
        while(l > left && nums[l-1] ==target){l--;}
        while(r < right && nums[r+1] ==target){r++;}
        return new int []{l,r};
    }
}