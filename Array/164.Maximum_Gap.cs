/*
Given an integer array nums, return the maximum difference between two successive elements in its sorted form. 
If the array contains less than two elements, return 0.

Example 1:
Input: nums = [3,6,9,1]
Output: 3
Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.

Example 2:
Input: nums = [10]
Output: 0
Explanation: The array contains less than 2 elements, therefore return 0.

Constraints:
1 <= nums.length <= 104
0 <= nums[i] <= 109
*/

 /********************************************************************************
 Attampt Times: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-21 11:00
 To: 2021-04-21 11:02
 *********************************************************************************
 Submission Result:
    Runtime: 80 ms, faster than 100.00% of C# online submissions for Maximum Gap.
    Memory Usage: 25.1 MB, less than 84.91% of C# online submissions for Maximum Gap.
 *********************************************************************************
 Note: 
    ????? hard question?
    https://leetcode.wang/leetcode-164-Maximum-Gap.html

    Solution Category: Sort | Sorting | Bucket
 *********************************************************************************/
public class Solution {
    public int MaximumGap(int[] nums) {
        if(nums == null || nums.Length ==0){return 0;}
        Array.Sort(nums);

        int max_diff = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            max_diff= Math.Max(max_diff,nums[i]-nums[i-1]);
        }

        return max_diff;
    }
}