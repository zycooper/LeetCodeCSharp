/*
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.

Constraints:
1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000

Follow up:
What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
*/

 /********************************************************************************
 Solution Category: 1
 *********************************************************************************
 Time Range:
 From: 2021-04-15 10:40
 To: 2021-04-15 11:07
 *********************************************************************************
 Submission Result:
Runtime: 236 ms, faster than 83.99% of C# online submissions for Intersection of Two Arrays II.
Memory Usage: 31.5 MB, less than 87.93% of C# online submissions for Intersection of Two Arrays II.
 *********************************************************************************
 Note: 
 no need to add dict for all, just add one for nums1, and then loop through nums2, every time we encounter the same, add it in list and reduce the count in dict for num1, if the count of this element in dict for num1 is below 1, it will jump out of the if clasue
 *********************************************************************************/
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> dict_1 = InitialDict(nums1);
        
        List<int> Result = new List<int>();

        for(int i =0; i < nums2.Length; i++)
        {
            if(dict_1.ContainsKey(nums2[i]) && dict_1[nums2[i]] >= 1)
            {
                Result.Add(nums2[i]);

                dict_1[nums2[i]]--;
            }
        }
        return Result.ToArray();
    }
    private Dictionary<int,int> InitialDict(int[] nums)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i],1);
            }
        }

        return dict;
    }
}