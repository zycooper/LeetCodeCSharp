/*
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:
n == nums.length
1 <= n <= 5 * 104
-231 <= nums[i] <= 231 - 1
*/

//Dictionary -> Add() not add()
//Dictionary -> Keys not keys
//Length -> not Lenght
//always check length of array first
public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int,int> Frequency = new Dictionary<int,int>();
        
        int result = 0;
        if(nums.Length == 1)
        {
            return nums[0];
        }
        for(int i =0; i < nums.Length;i++)
        {
            if(Frequency.Keys.Contains(nums[i]))
            {
                Frequency[nums[i]] += 1;

                if(Frequency[nums[i]] > nums.Length/2 )
                {
                    result = nums[i];
                    break;
                }
            }
            else
            {
                Frequency.Add(nums[i],1);
            }
        }
    }

    public int MajorityElementSort(int[] nums) 
    {
        //damn, that's fxxx awsome
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}