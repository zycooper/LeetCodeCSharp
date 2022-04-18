/*
Given an integer array nums, reorder it such that nums[0] < nums[1] > nums[2] < nums[3]....
You may assume the input array always has a valid answer.

Example 1:
Input: nums = [1,5,1,1,6,4]
Output: [1,6,1,5,1,4]
Explanation: [1,4,1,5,1,6] is also accepted.

Example 2:
Input: nums = [1,3,2,2,3,1]
Output: [2,3,1,3,1,2]

Constraints:
1 <= nums.length <= 5 * 104
0 <= nums[i] <= 5000
It is guaranteed that there will be an answer for the given input nums.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-14 14:31
 To: 2021-04-14 14:31
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public void WiggleSort(int[] nums) {
        if(nums.Length <= 1){return;}

        Array.Sort(nums);       
        
        int k = (int)Math.Ceiling((double)nums.Length/(double)2);
        int[] small = nums.Take(k).ToArray();
        int[] large = nums.Skip(k).ToArray();

        for(int i = 1; i < nums.Length; i++)
        {
            if(i%2 ==0)
            {
                //even
                nums[i] = small[i/2];
            }
            else
            {
                //odd
                nums[i] = large[(i-1)/2];
            }
        }
    }
}