/*
You are given a sorted unique integer array nums.
Return the smallest sorted list of ranges that cover all the numbers in the array exactly. 
That is, each element of nums is covered by exactly one of the ranges, 
and there is no integer x such that x is in one of the ranges but not in nums.
Each range [a,b] in the list should be output as:
"a->b" if a != b
"a" if a == b
 
Example 1:
Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"

Example 2:
Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"

Example 3:
Input: nums = []
Output: []

Example 4:
Input: nums = [-1]
Output: ["-1"]

Example 5:
Input: nums = [0]
Output: ["0"]


Constraints:
0 <= nums.length <= 20
-231 <= nums[i] <= 231 - 1
All the values of nums are unique.
nums is sorted in ascending order.
*/

 /********************************************************************************
 Attampt Times: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-13 10:45
 To: 2021-04-13 11:20
 *********************************************************************************
 Submission Result:
    Runtime: 232 ms, faster than 98.69% of C# online submissions for Summary Ranges.
    Memory Usage: 31 MB, less than 16.34% of C# online submissions for Summary Ranges.
 *********************************************************************************
 Note: 
    nothing special,created by myself,may not be pretty but works.
    Don't forget to add the last node check which is after the loop
 *********************************************************************************/
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> Result = new List<string>();

        if(nums.Length ==0){ return Result;}

        int start = 0;       
        int end=1;
        for(; end < nums.Length; end++)
        {
           if(nums[end] != nums[end-1] + 1)
           {
               //not continue
               if(nums[end - 1] == nums[start])
               {
                   Result.Add(nums[start].ToString());
               }            
               else
               {
                   Result.Add(nums[start].ToString() + "->" + nums[end - 1].ToString());
               }

               start = end;
           }
        }

               if(nums[end - 1] == nums[start])
               {
                   Result.Add(nums[start].ToString());
               }
               else
               {
                   Result.Add(nums[start].ToString() + "->" + nums[end - 1].ToString());
               }
        return Result;
    }
}