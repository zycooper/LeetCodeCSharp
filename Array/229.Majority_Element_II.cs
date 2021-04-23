/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

Follow-up: Could you solve the problem in linear time and in O(1) space?

Example 1:
Input: nums = [3,2,3]
Output: [3]

Example 2:
Input: nums = [1]
Output: [1]

Example 3:
Input: nums = [1,2]
Output: [1,2]
 
Constraints:
1 <= nums.length <= 5 * 104
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
    public IList<int> MajorityElement(int[] nums) {
        //very slow and straight forward
            Dictionary<int, int> Frequency = new Dictionary<int, int>();

            List<int> result = new List<int>();
            if (nums.Length <= 3)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!result.Contains(nums[i]))
                    {
                        result.Add(nums[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (Frequency.Keys.Contains(nums[i]))
                    {
                        Frequency[nums[i]] += 1;

                        if (Frequency[nums[i]] > nums.Length / 3 && !result.Contains(nums[i]))
                        {
                            result.Add(nums[i]);
                        }
                    }
                    else
                    {
                        Frequency.Add(nums[i], 1);
                    }
                }
            }

            return result.ToArray();
    }

    public IList<int> MajorityElement_2(int[] nums)
    {
           //Boyer-Moore voting
        int? el1=null;
        int? el2=null;
        int counter1 = 0;
        int counter2 = 0;

        for(int i =0; i < nums.Length;i++)
        {
            if(el1 != null && el1 == nums[i])
            {
                counter1++;
            }
            else if(el2 != null && el2 == nums[i])
            {
                counter2++;
            }
            else if(counter1 == 0)
            {
                el1 = nums[i];
                counter1++;
            }
            else if(counter2 == 0)
            {
                el2 = nums[i];
                counter2++;
            }
            else
            {
                counter1--;
                counter2--;
            }
        }

        counter1 = 0;
        counter2 = 0;

        for(int i =0; i < nums.Length; i++)
        {
            if(el1 == nums[i])
            {
                counter1++;
            }

            if(el2 == nums[i])
            {
                counter2++;    
            }
        }
        
      


       List<int> result = new List<int>() { };
           
       if (el1 != null && counter1 > nums.Length / 3) { result.Add((int)el1); }
       if (el2 != null && counter2 > nums.Length / 3) { result.Add((int)el2); }

       return result;
    }
}