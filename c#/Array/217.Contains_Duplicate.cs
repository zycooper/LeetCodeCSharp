/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
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
    public bool ContainsDuplicate_0(int[] nums) {
        //Contains!!!!! not Contain
        //And run too long
        List<int> temp_list = new List<int>();

        bool result = false;

        for(int i =0; i < nums.Length;i++)
        {
            if(temp_list.Contains(nums[i]))
            {
                result = true;
                break;
            }
            else
            {
                temp_list.Add(nums[i]);
            }
        }

        return result;
    }

        public bool ContainsDuplicate_01(int[] nums) {
        //Contains!!!!! not Contain
        //And run too long
        /* below time out, but dic works
        List<int> temp_list = new List<int>();       

        for(int i =0; i < nums.Length;i++)
        {
            if(temp_list.Contains(nums[i]))
            {
               return true;
            }
            else
            {
                temp_list.Add(nums[i]);
            }
        }

        return false;
        */

        Dictionary<int,int> _dict = new Dictionary<int,int>();
        
        for(int i =0; i < nums.Length;i++)
        {
            if(_dict.ContainsKey(nums[i]))
            {
               return true;
            }
            else
            {
                _dict[nums[i]] = 1;
            }
        }

        return false;
    }

    public bool ContainsDuplicate_1(int[] nums) {        
        //116 ms,faster than 55%
        Array.Sort(nums);

        for(int i =0;i< nums.Length-1;i++)
        {
            if(nums[i] == nums[i+1])
            {
                return true;
            }
        }

        return false;
    }
}