/*
A wiggle sequence is a sequence where the differences between successive numbers strictly alternate between positive and negative. 
The first difference (if one exists) may be either positive or negative. 
A sequence with two or fewer elements is trivially a wiggle sequence.
For example, [1, 7, 4, 9, 2, 5] is a wiggle sequence because the differences (6, -3, 5, -7, 3) alternate between positive and negative.
In contrast, [1, 4, 7, 2, 5] and [1, 7, 4, 5, 5] are not wiggle sequences. 
The first is not because its first two differences are positive, and the second is not because its last difference is zero.
A subsequence is obtained by deleting some elements (possibly zero) from the original sequence, leaving the remaining elements in their original order.
Given an integer array nums, return the length of the longest wiggle subsequence of nums.

Example 1:
Input: nums = [1,7,4,9,2,5]
Output: 6
Explanation: The entire sequence is a wiggle sequence with differences (6, -3, 5, -7, 3).

Example 2:
Input: nums = [1,17,5,10,13,15,10,5,16,8]
Output: 7
Explanation: There are several subsequences that achieve this length.
One is [1, 17, 10, 13, 10, 16, 8] with differences (16, -7, 3, -3, 6, -8).

Example 3:
Input: nums = [1,2,3,4,5,6,7,8,9]
Output: 2

Constraints:
1 <= nums.length <= 1000
0 <= nums[i] <= 1000
*/

 /********************************************************************************
 Attampt Times: 2
 *********************************************************************************
 Time Range:
 From: 2021-04-14 09:49
 To: 2021-04-14 10:49
 *********************************************************************************
 Submission Result:
    Runtime: 92 ms, faster than 41.10% of C# online submissions for Wiggle Subsequence.
    Memory Usage: 24.9 MB, less than 7.02% of C# online submissions for Wiggle Subsequence.

    DP:
    Runtime: 80 ms, faster than 98.00% of C# online submissions for Wiggle Subsequence.
    Memory Usage: 24.6 MB, less than 29.82% of C# online submissions for Wiggle Subsequence.
 *********************************************************************************
 Note: 
1st try use greedy, need to use int diff instead of positive or negative
in the if, > and <= or < and <= will count something like 1,0,0,1 as one not two.
since i starts from 2, and cur_wiggle_len initial as 1, so at last the cur_wiggle_len should count as +1
 *********************************************************************************/
public class Solution {         
    //typical dp, up and down was two array to store up and down, but actually each one stores a convert point
    public int WiggleMaxLength_dp(int[] nums) {
       if(nums.Length < 2){return nums.Length;;}

       int up = 1;
       int down = 1;

       for(int i = 1; i < nums.Length; i++)
       {
           if(nums[i] > nums[i - 1])
           {
               up = down + 1;
           }
           else if(nums[i] < nums[i - 1])
           {
               down = up + 1;
           }
       }

       return Math.Max(down, up);
    }
    public int WiggleMaxLength(int[] nums) {
        if(nums.Length <= 1){return nums.Length;}
        
        //bool prev_check = (nums[1] - nums[0] > 0 );
        int prevdiff = nums[1] - nums[0];

        int cur_wiggle_len = (prevdiff !=0)? 1:0;

        for(int i = 2; i < nums.Length; i++)
        {
            int cur_diff= nums[i] - nums[i-1];
            if( (cur_diff> 0 && prevdiff <= 0) || (cur_diff < 0 && prevdiff >= 0)) 
            {
                //is wiggle
                cur_wiggle_len++;
                prevdiff = cur_diff;
            }
        }

        return cur_wiggle_len + 1;
    }
    public int WiggleMaxLength(int[] nums) {
//this is originally created by me, greedy, but not work
        if(nums.Length <= 1){return nums.Length;}
        
        bool prev_check = (nums[1] - nums[0] > 0 );
        int cur_wiggle_len = 1;

        for(int i = 2; i < nums.Length; i++)
        {
            if((nums[i] - nums[i-1] > 0 ) != prev_check &&(nums[i] - nums[i-1] !=0))
            {
                //is wiggle
                cur_wiggle_len++;
                prev_check = !prev_check;
            }
        }

        return cur_wiggle_len + 1;
    }
}