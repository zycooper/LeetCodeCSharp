/*
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

Example 1:
Input: nums = [1,2,3,1], k = 3
Output: true

Example 2:
Input: nums = [1,0,1,1], k = 1
Output: true

Example 3:
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 
Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
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
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        //112ms, faster than 48.51%

        Dictionary<int,List<int>> _dict = new Dictionary<int,List<int>>();

        for(int i =0; i < nums.Length; i++)
        {
            if(_dict.ContainsKey(nums[i]))
            {
                if(Math.Abs(_dict[nums[i]][_dict[nums[i]].Count()-1] - i) <= k)
                {
                    return true;
                }
                else
                {
                    _dict[nums[i]].Add(i);
                }
            }
            else
            {
                _dict[nums[i]] = new List<int>(){i};
            }
        }

        return false;
    }
}

//other Binary Search Tree ?????