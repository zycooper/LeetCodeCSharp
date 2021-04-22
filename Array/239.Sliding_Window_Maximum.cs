/*
You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. 
You can only see the k numbers in the window. Each time the sliding window moves right by one position.
Return the max sliding window.

Example 1:
Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation: 
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7

Example 2:
Input: nums = [1], k = 1
Output: [1]

Example 3:
Input: nums = [1,-1], k = 1
Output: [1,-1]

Example 4:
Input: nums = [9,11], k = 2
Output: [11]

Example 5:
Input: nums = [4,-2], k = 2
Output: [4]

Constraints:
1 <= nums.length <= 105
-104 <= nums[i] <= 104
1 <= k <= nums.length
*/

 /********************************************************************************
 Attampt Times: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-22 16:11
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 
    | Monotonic Queue | Deque | Daynamic Programming | Brute Force |
 *********************************************************************************/
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        //wrong
        if(nums.Length * k == 0){ return new int[0];}
        if(k == 1) {return nums;}
        //brute force
        int[] Result = new int[nums.Length - k + 1];

        int curr_max = int.MinValue;
        for(int i = 0; i < nums.Length - k + 1;i++)
        {           
            for(int j = i; j < i + k; j++)
            {
                curr_max = Math.Max(curr_max, nums[j]);
            }
            Result[i] = curr_max;
        }

        return Result;
    }
}