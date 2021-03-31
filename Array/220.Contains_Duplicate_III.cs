/*
Given an integer array nums and two integers k and t, return true if there are two distinct indices i and j in the array such that 
abs(nums[i] - nums[j]) <= t && abs(i - j) <= k.

Example 1:
Input: nums = [1,2,3,1], k = 3, t = 0
Output: true

Example 2:
Input: nums = [1,0,1,1], k = 1, t = 2
Output: true

Example 3:
Input: nums = [1,5,9,1,5,9], k = 2, t = 3
Output: false
 
Constraints:

0 <= nums.length <= 2 * 104
-231 <= nums[i] <= 231 - 1
0 <= k <= 104
0 <= t <= 231 - 1
*/

//sliding window
//Binary Search Tree
//bucket
public class Solution {
    //t is abs different
    //k is distance
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        //binary search tree
        if (t < 0) return false;
        var n = nums.Length;
        var sortedSet = new SortedSet<long>();
        for (int i = 0; i < n; i++) 
        {
            if (sortedSet.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0)
            {
                return true;
            }
            else
            {
                sortedSet.Add(nums[i]);
                if (i >= k)
                {                    
                    sortedSet.Remove(nums[i - k]);
                }
            } 
        }
        return false;
    }
}