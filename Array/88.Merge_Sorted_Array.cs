/*
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
The number of elements initialized in nums1 and nums2 are m and n respectively. 
You may assume that nums1 has a size equal to m + n such that it has enough space to hold additional elements from nums2.

Example 1:
Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]

Example 2:
Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
 
Constraints:
nums1.length == m + n
nums2.length == n
0 <= m, n <= 200
1 <= m + n <= 200
-109 <= nums1[i], nums2[i] <= 109
*/

 /********************************************************************************
 Attampt Times: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-13 14:15
 To: 2021-04-13 15:00
 *********************************************************************************
 Submission Result:
Runtime: 232 ms, faster than 84.85% of C# online submissions for Merge Sorted Array.
Memory Usage: 31.2 MB, less than 18.72% of C# online submissions for Merge Sorted Array.
 *********************************************************************************
 Note: 
  //because nums1 is the array which will be merged into, so check nums1_index along with nums1[i] with nums2[i]
  //if last number is in nums2, so nums1_index will be negative since the last one in nums_index has already been placed in the right place
  //then the last number in nums2 automatically goes to the first place
 *********************************************************************************/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0)
        {
            return;
        }

        if(m == 0)
        {
            for(int i =0; i< n;i++)
            {
                nums1[i] = nums2[i];
            }

            return;
        }

        int nums1_index = m - 1;
        int nums2_index = n - 1;
        int k = m + n - 1;

        while(k >=0)
        {
            //because nums1 is the array which will be merged into, so check nums1_index along with nums1[i] with nums2[i]
            //if last number is in nums2, so nums1_index will be negative since the last one in nums_index has already been placed in the right place
            //then the last number in nums2 automatically goes to the first place
            if(nums2_index < 0){ break;}

            if(nums1_index >= 0 && nums1[nums1_index] > nums2[nums2_index])
            {
                nums1[k] = nums1[nums1_index--];
            }
            else
            {
                nums1[k] = nums2[nums2_index--];
            }
            k--;
        }
    }
}