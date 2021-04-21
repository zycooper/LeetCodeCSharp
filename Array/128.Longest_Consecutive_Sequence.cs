/*
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

Example 1:
Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

Example 2:
Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
 
Constraints:
0 <= nums.length <= 104
-109 <= nums[i] <= 109
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-21 10:35
 To: 2021-04-21 10:55
 *********************************************************************************
 Submission Result:
    Runtime: 92 ms, faster than 91.19% of C# online submissions for Longest Consecutive Sequence.
    Memory Usage: 26 MB, less than 45.29% of C# online submissions for Longest Consecutive Sequence.
 *********************************************************************************
 Note: 
    it could be duplicate

    be carefull about the nest if

    And Hash | HashTable | Hash Table | Dictionary
 *********************************************************************************/
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0){return 0;}
        
        Array.Sort(nums);

        int longest_count = 1;
        int current_count = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i -1])
            {
                if(nums[i] == nums[i - 1] + 1)
                {
                    current_count++;
                }
                else
                {
                    longest_count = Math.Max(longest_count,current_count);
                    current_count=1;
                }
            }
        }

        return Math.Max(longest_count,current_count);
    }
}