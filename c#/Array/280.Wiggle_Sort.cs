/*
Given an integer array nums, reorder it such that nums[0] <= nums[1] >= nums[2] <= nums[3]....
You may assume the input array always has a valid answer.

Example 1:
Input: nums = [3,5,2,1,6,4]
Output: [3,5,1,6,2,4]
Explanation: [1,6,2,5,3,4] is also accepted.

Example 2:
Input: nums = [6,6,5,6,3,8]
Output: [6,6,5,6,3,8]

Constraints:
1 <= nums.length <= 5 * 104
0 <= nums[i] <= 104
It is guaranteed that there will be an answer for the given input nums.
*/

 /********************************************************************************
 Solution Category: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-14:12
 To: 2021-04-14:24
 *********************************************************************************
 Submission Result:
    Runtime: 252 ms, faster than 54.69% of C# online submissions for Wiggle Sort.
    Memory Usage: 34 MB, less than 71.88% of C# online submissions for Wiggle Sort.
 *********************************************************************************
 Note: 
at first I have absolutely no clue since I just finish Q376, I thought about dp or greedy.
but then turns out it is that simply, just sort it and then flip every two in the middle except first and last one element
 *********************************************************************************/
public class Solution {
    public void WiggleSort(int[] nums) {
        Array.Sort(nums);

        for(int i = 1; i < nums.Length - 1; i += 2)
        {
            swap(ref nums, i,i +1);
        }
    }
    private void swap(ref int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}