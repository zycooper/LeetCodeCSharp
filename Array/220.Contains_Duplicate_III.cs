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

    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        // k is distance
    // t is abs different
        if(t < 0) return false;
        
        SortedSet<long> sets = new SortedSet<long>();
        //loop through array nums and start place item in sorted set
        for(int i = 0; i < nums.Length; i++)
        {
			//for t constrain
			//GetViewBetween
            //use long instead of int!!!!! because long value has larger maximun than int, if the nums[i] is more than the max int, the (long)nums[i] + t probablly will be negative
            //int max -> 
            //2147483647
            //2147483640
			int matchValueCount = sets.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count;
			if(matchValueCount > 0)
			{
				return true;
			}
			else
			{
				//for k constrain
				//no current value in sort matches the current nums[i], add nums[i] 
				sets.Add(nums[i]);
				
				//remove the value which is more than k far away
				if(i >= k)
				{
					//since remove 1 item everytime with k distance, add first then remove, won't remove item from an empty sets
					//even if there are several same values in the sets, since there is no match value in previous matchValueCount step, so all the values for nums[i-k] won't affect after remove
					sets.Remove(nums[i-k]);
				}
			}
			
        }
        
        return false;
    }
}