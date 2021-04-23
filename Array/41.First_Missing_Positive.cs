/*
Given an unsorted integer array nums, find the smallest missing positive integer.

Example 1:

Input: nums = [1,2,0]
Output: 3
Example 2:

Input: nums = [3,4,-1,1]
Output: 2
Example 3:

Input: nums = [7,8,9,11,12]
Output: 1
 

Constraints:

0 <= nums.length <= 300
-231 <= nums[i] <= 231 - 1
 
*/
/*
this problem use a for and while, loop through all the items in the array, and throw the current value to the correct postion and take the correct position value at current postion,then keep this process in while, run until the end
then loop through the sorted array again, if current item doesn't equal to the correct value ([1,2,3,4,5,...]),return i + 1

basically: loop through the original array make sure all the values which have correct positon to the correct position(eg, 6,7,-1,1 -> only 1 has correct position and the position is 0, otherwise it doesn't matter since 2 is not the array value)
*/

/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 
*********************************************************************************
Submission Result:

*********************************************************************************
Note: 

*********************************************************************************/
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        /*
        Runtime: 84 ms, faster than 95.12% of C# online submissions for First Missing Positive.
        Memory Usage: 25 MB, less than 74.76% of C# online submissions for First Missing Positive.
        */
         if(nums.Length == 0 )
        {
            return 1;
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            //current pos -> i
            //correct pos -> nums[i] - 1

            //different between nums[nums[i] - 1] != nums[i] and nums[i] - 1 != i, for [1,1],nums[i] - 1 != i will run forever
            while(nums[i] - 1 >= 0 && nums[i] - 1 < nums.Length && nums[nums[i] - 1] != nums[i])
            {
                //swap
                int temp = nums[i];
                nums[i] = nums[nums[i] -1];
                nums[temp - 1] = temp;
            }
        }
        
        for(int i =0; i < nums.Length; i++)
        {
            if(i != nums[i] - 1)
            {
                return i + 1;
            }
        }
        
        return nums.Length + 1;
    }    
}