/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, 
with the colors in the order red, white, and blue.
We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

Example 1:
Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Example 2:
Input: nums = [2,0,1]
Output: [0,1,2]

Example 3:
Input: nums = [0]
Output: [0]

Example 4:
Input: nums = [1]
Output: [1]

Constraints:
n == nums.length
1 <= n <= 300
nums[i] is 0, 1, or 2.
*/

 /********************************************************************************
 Attampt Times: 2
 *********************************************************************************
 Time Range:
 From: 2021-04-14 08:51
 To: 2021-04-14 08:52

 From: 2021-04-14 09:20
 To: 2021-04-14 09:30
 *********************************************************************************
 Submission Result:
    Runtime: 264 ms, faster than 10.11% of C# online submissions for Sort Colors.
    Memory Usage: 30.9 MB, less than 16.36% of C# online submissions for Sort Colors.

    Runtime: 220 ms, faster than 99.47% of C# online submissions for Sort Colors.
    Memory Usage: 30.5 MB, less than 74.73% of C# online submissions for Sort Colors.
 *********************************************************************************
 Note: 
 One Pass
 *********************************************************************************/
public class Solution {
    public void SortColors(int[] nums) {
        if(nums.Length == 0){return;}

        //indicate the left boundry of last 0 or least number
        int left_index = 0;

        //indicate the right boundry of first 2 or max number
        //it maynot has the corret number, that's the reason why I use curr_index <= right_index in while
        int right_index = nums.Length - 1;

        //the i
        int curr_index = 0;
        int temp_value;
        while(curr_index <= right_index)
        {
            if(nums[curr_index] == 0)
            {
                //swithc current one with the 0 boundry left_index
                temp_value = nums[left_index];
                nums[left_index++] = nums[curr_index];
                nums[curr_index++] = temp_value;
            }
            else if(nums[curr_index] ==2)
            {
                //swithc current one with the 2 boundry right_index
                //no need to move curr_index since current 2 goes to right boundry, the current value changed, need to check again
                temp_value = nums[right_index];
                nums[right_index--] = nums[curr_index];
                nums[curr_index] = temp_value;
            }
            else
            {
                //nums[curr_index] == 1, do nothing but upgrade curr_index
                curr_index++;
            }
        }
    }
    public void SortColors_sort(int[] nums) {
        //it fucking works and accept...
        Array.Sort(nums);
    }
}