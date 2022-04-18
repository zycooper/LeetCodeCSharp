/*
Given an integer array nums and an integer k, return the maximum length of a subarray that sums to k. If there isn't one, return 0 instead.

Example 1:
Input: nums = [1,-1,5,-2,3], k = 3
Output: 4
Explanation: The subarray [1, -1, 5, -2] sums to 3 and is the longest.

Example 2:
Input: nums = [-2,-1,2,1], k = 1
Output: 2
Explanation: The subarray [-1, 2] sums to 1 and is the longest.
 
Constraints:
1 <= nums.length <= 104
-104 <= nums[i] <= 104
-105 <= k <= 105
*/
    /********************************************************************************
    Solution Category: 1
    *********************************************************************************
    Time Range:
    From: 2021-04-12 13:05
    To: 2021-04-12 13:56
    *********************************************************************************
    Submission Result:
    Runtime: 112 ms, faster than 54.55% of C# online submissions for Maximum Size Subarray Sum Equals k.
    Memory Usage: 31.3 MB, less than 85.86% of C# online submissions for Maximum Size Subarray Sum Equals k.
    *********************************************************************************
    Note:
    https://www.cnblogs.com/Dylan-Java-NYC/p/5238223.html
    Ori [1,-1,5,-2,3] k =3
    Sum [1,0,5,3,6]

    if sum match k,then result found.

    if not found, check if the sum -k exist in the dict, if so, the distence between i and dict[sum - k] is the subarray which sum match k

    why add (0,-1) at the very first position in dict?
    if the valid sub array starts from index 0, this key-value pair will locate it.
    image {3,1,2} and k =3
    *********************************************************************************/
public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        //key is the sum to current index
        //value is index
        Dictionary<int,int> Dict = new Dictionary<int, int>();
        int sum = 0;
        int max = 0;

        Dict.Add(0, -1);

        for(int i =0; i < nums.Length; i++)
        {
            sum += nums[i];

            if(Dict.ContainsKey(sum-k))
            {
                max = Math.Max(max, i - Dict[sum-k]);
            }

            if(!Dict.ContainsKey(sum))
            {
                Dict.Add(sum,i);
            }
        }

        return max;
    }
}