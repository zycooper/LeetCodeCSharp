/*
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

Example 1:
Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:
Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

Example 3:
Input: nums1 = [0,0], nums2 = [0,0]
Output: 0.00000

Example 4:
Input: nums1 = [], nums2 = [1]
Output: 1.00000

Example 5:
Input: nums1 = [2], nums2 = []
Output: 2.00000

Constraints:
nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-21 14:15
 To: 2021-04-21 16:35
 *********************************************************************************
 Submission Result:
    Runtime: 144 ms, faster than 12.19% of C# online submissions for Median of Two Sorted Arrays.
    Memory Usage: 28.4 MB, less than 82.07% of C# online submissions for Median of Two Sorted Arrays.
 *********************************************************************************
 Note: 
    Binary Search
    Merge Sort

    use double
    when use binary, place left < right in the while and assign left or right beside index or index-- or index++
    https://leetcode.com/problems/median-of-two-sorted-arrays/discuss/2471/very-concise-ologminmn-iterative-solution-with-detailed-explanation
    youtube ---> shanjingchengyijie
 *********************************************************************************/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
         if(nums1 == null || nums2 == null){return -1;}
        
        //assume nums1 is shorter
        if(nums1.Length > nums2.Length){ return FindMedianSortedArrays(nums2,nums1);}

        //if nums1 has 0 elemnt, return median of nums2
        if(nums1.Length == 0)
        { 
            return ((double)nums2[(Len2-1)/2] + (double)nums2[Len2/2])/2;
            // if(nums2.Length%2 == 0)
            // {
            //     return (nums2[nums2.Length/2] + nums2[nums2.Length/2+1])/2;
            // }
            // else
            // {
            //     return nums2[nums2.Length/2 + 1];
            // }
        }

        int Len1 = nums1.Length;
        int Len2 = nums2.Length;

        int left_1 = 0;
        int right_1 = Len1;//since the cut_pos_1 will be divide into 2 base on the left and right sum, length or length - 1 doesn't really matter
        
         //cut_pos_1;// = (left_1 + right_1)/2;
         //cut_pos_2; //no initial value, will be calculated base on cut_pos_2

        while(left_1 <= right_1)
        {
            int cut_pos_1 = (left_1 + right_1)/2;
            int cut_pos_2 = (Len1 + Len2 + 1)/2 - cut_pos_1;
            //int l1,r1,l2,r2;

            double l1 = (cut_pos_1 == 0) ? int.MinValue : nums1[cut_pos_1 - 1];
            double r1 = (cut_pos_1 == Len1) ? int.MaxValue : nums1[cut_pos_1];

            double l2 = (cut_pos_2 == 0) ? int.MinValue: nums2[cut_pos_2 - 1];
            double r2 = (cut_pos_2 == Len2) ? int.MaxValue: nums2[cut_pos_2];

            if(l1 > r2)
            {
                //move index to the left
                right_1 = cut_pos_1 - 1;
            }
            else if(l2 > r1)
            {
                //move index to the right
                left_1 = cut_pos_1 + 1;
            }
            else
            {
                //boundry found!
                if((Len1 + Len2)%2 == 0)
                {
                    //even
                    return (Math.Min(r1,r2) + Math.Max(l1,l2))/2;
                }
                else
                {
                    //odd
                    return Math.Max(l1,l2);
                }
            }              
        }

        return -1;
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //below doesn't work and it was not binary search since it starts from the middle then add or minus 1 on the index
        if(nums1 == null || nums2 == null){return -1;}
        
        //assume nums1 is shorter
        if(nums1.Length > nums2.Length){ return FindMedianSortedArrays(nums2,nums1);}

        //if nums1 has 0 elemnt, return median of nums2
        if(nums1.Length == 0)
        { 
            if(nums2.Length%2 == 0)
            {
                return (nums2[nums2.Length/2] + nums2[nums2.Length/2+1])/2;
            }
            else
            {
                return nums2[nums2.Length/2 + 1];
            }
        }

        int Len1 = nums1.Length;
        int Len2 = nums2.Length;

        int cut_pos_1 = Len1/2;

        while(cut_pos_1 <= Len1 && cut_pos_1 >= 0)
        {
            int l1,r1,l2,r2;

            l1 = (cut_pos_1 == 0) ? int.MinValue : nums1[cut_pos_1 - 1];
            r1 = (cut_pos_1 == Len1) ? int.MaxValue : nums1[cut_pos_1];

            l2 = ((Len1+Len2+1)/2 - cut_pos_1 == 0)? int.MinValue: nums2[(Len1+Len2+1)/2 - cut_pos_1 - 1];
            r2 = ((Len1+Len2+1)/2 - cut_pos_1 == Len2)?int.MaxValue: nums2[(Len1+Len2+1)/2 - cut_pos_1];

            if(l1 <= r2 && l2 <= r1)
            {
                //final result
                if((Len1 + Len2)%2 == 0)
                {
                    //even
                    return (Math.Min(r1,r2) + Math.Max(l1,l2))/2;
                }
                else
                {
                    //odd
                    return Math.Max(r1,r2);
                }
            }
            else if(l1 > r2)
            {
                //cut_pos_1 more to prevous --
                cut_pos_1--;
            }
            else if(l2 > r1)
            {
                //cut_pos_2 move to next ++
                cut_pos_1++;
            }
            // else
            // {

            // }
        }

        return -1;
    }
}