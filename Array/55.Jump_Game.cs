/*
Given an array of non-negative integers nums, you are initially positioned at the first index of the array.
Each element in the array represents your maximum jump length at that position.
Determine if you are able to reach the last index.

Example 1:
Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

Example 2:
Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.

Constraints:
1 <= nums.length <= 3 * 104
0 <= nums[i] <= 105
*/

public class Solution {
    public bool CanJump(int[] nums) {
        //greedy below
        //maintain a max which return the max position from current positon
        //and compare this with next i, if i > max , it means this i will never be reached
        //and if there is no i > max, at last compare the last i(Lenght -1) and max to see if max is euqal or more then i 
        int max =0;

        for(int i = 0; i < nums.Length; i++)
        {
            //i always compare with the previous max
            if(i > max) return false;

            max = Math.Max(max, i + nums[i]);
        }

        return max >= nums.Length -1;
        //return JumpRecur(0,nums);
    }

    private bool JumpRecur(int pos, int[] nums)
    {
        //Time Limit Exceeded
        //break point or the target point
        if (pos == nums.Length-1)
        {
            return true;
        }

        int FarestPoint = Math.Min(nums.Length -1, pos + nums[pos]);

        //enter recur
        for(int i = pos +1; i <= FarestPoint; i++)
        {
            if(JumpRecur(i,nums))
            {
                return true;
            }
        }
        //optimize - still Time Limit Exceeded
         for(int i = FarestPoint; i > FarestPoint; i--)
        {
            if(JumpRecur(i,nums))
            {
                return true;
            }
        }

        return false;
    }
}