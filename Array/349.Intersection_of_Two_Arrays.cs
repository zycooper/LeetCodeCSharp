/*
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must be unique and you may return the result in any order.
Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.

Constraints:
1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000
*/
 /********************************************************************************
 Solution Category: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-15 10:29
 To: 2021-04-15 10:37
 *********************************************************************************
 Submission Result:
    Runtime: 248 ms, faster than 21.71% of C# online submissions for Intersection of Two Arrays.
    Memory Usage: 31.4 MB, less than 92.53% of C# online submissions for Intersection of Two Arrays.
 *********************************************************************************
 Note: 
Array.Exists(array1,element => element = "value")
 *********************************************************************************/
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        //too slow
        List<int> Result = new List<int>();

        for(int i = 0; i < nums2.Length; i++)
        {
            if(Array.Exists(nums1, element => element == nums2[i]))
            {
                if(!Result.Contains(nums2[i]))
                {
                    Result.Add(nums2[i]);
                }
            }            
        }

        return Result.ToArray();
    }
}