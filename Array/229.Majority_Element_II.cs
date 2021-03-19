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
}