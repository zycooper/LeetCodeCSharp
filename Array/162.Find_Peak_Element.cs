/*
A peak element is an element that is strictly greater than its neighbors.
Given an integer array nums, find a peak element, and return its index. 
If the array contains multiple peaks, return the index to any of the peaks.
You may imagine that nums[-1] = nums[n] = -∞.

Example 1:
Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and your function should return the index number 2.

Example 2:
Input: nums = [1,2,1,3,5,6,4]
Output: 5
Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.

Constraints:
1 <= nums.length <= 1000
-231 <= nums[i] <= 231 - 1
nums[i] != nums[i + 1] for all valid i
*/

 /********************************************************************************
 Attampt Times: 3
 *********************************************************************************
 Time Range:
 From: 2021-04-15 08:42
 To: 2021-04-15 08:51
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 66.78% of C# online submissions for Find Peak Element.
Memory Usage: 25.5 MB, less than 11.83% of C# online submissions for Find Peak Element.
 *********************************************************************************
 Note: 
    nums[i] doesn't need to be greater than previous element, if it is greater than next one it is peak since the previous one will be peak if previous one is greater than current one

    if nothing match, returns nums.Length - 1
 *********************************************************************************/
public class Solution {
    public int FindPeakElement(int[] nums) {  
        //binary search  
        /*
        Runtime: 84 ms, faster than 96.35% of C# online submissions for Find Peak Element.
        Memory Usage: 25.2 MB, less than 63.65% of C# online submissions for Find Peak Element.
        */
        int left = 0;
        int right = nums.Length -1;

        //use left < right, so last one break this rule will be left >= right, will return left at last
        while(left < right)
        {
            int mid = (right + left)/2;
            if(nums[mid] > nums[mid + 1])
            {
                right = mid;               
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
    public int FindPeakElement(int[] nums) {  
        //will find the very peaky peak
        //Runtime: 88 ms, faster than 87.83% of C# online submissions for Find Peak Element.
        //Memory Usage: 25.1 MB, less than 82.61% of C# online submissions for Find Peak Element.
        int left = 0;
        int right = nums.Length -1;

        //use left < right, so last one break this rule will be left >= right, will return left at last
        while(left < right)
        {
            if(nums[left] < nums[right])
            {
                left++;                
            }
            else
            {
                right--;
            }
        }
        return left;
    }
     public int FindPeakElement(int[] nums) {  
         //nums[i] doesn't need to be greater than previous element, if it is greater than next one it is peak since the previous one will be peak if previous one is greater than current one
        for(int i = 0; i < nums.Length-1;i++)
        {
            if(nums[i] > nums[i + 1])
            {
                return i;
            }
        }

        return nums.Length-1;
    }
    public int FindPeakElement(int[] nums) {
        //too many corner cases
        if(nums.Length == 1){ return 0; }

        if(nums.Length == 2){ return nums[0] < nums[1];}

        for(int i = 1; i < nums.Length-1;i++)
        {
            if(nums[i] > nums[i + 1] && nums[i] > nums[i - 1])
            {
                return i;
            }
        }

        return 0;
    }
}