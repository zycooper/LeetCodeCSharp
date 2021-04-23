/*
Given an array, rotate the array to the right by k steps, where k is non-negative.

Follow up:

Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
Could you do it in-place with O(1) extra space?
 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
 

Constraints:

1 <= nums.length <= 2 * 104
-231 <= nums[i] <= 231 - 1
0 <= k <= 105
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
    public void Rotate(int[] nums, int k) 
    {
        //1. Brute Force
        int temp, last;
        for(int i = 0; i <k;i++)
        {
            //set the last one to previous
            last = nums[nums.Length-1];
            for(int j = 0;j<nums.Length;j++)
            {
                temp = nums[j];
                nums[j] = last;
                last = temp;
            }
        }

        //2. Using Cyclic Replacements
        //define another array
        int[] ArrayWithWriteOrder = new int[nums.Length];

        //assign values to the new array with right order
        for(int i =0; i < nums.Length; i++)
        {
            ArrayWithWriteOrder[(i + k) % nums.Length] = nums[i];
        }
        for(int i =0; i < nums.Length; i++)
        {
            nums[i] = ArrayWithWriteOrder[i];
        }

        //3. Using Cyclic Replacements
        //4. Using Reverse
    }
}