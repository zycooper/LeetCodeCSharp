/*
Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.

Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.length.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
Example 2:

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Example 3:

Input: numbers = [-1,0], target = -1
Output: [1,2]
 

Constraints:

2 <= numbers.length <= 3 * 104
-1000 <= numbers[i] <= 1000
numbers is sorted in non-decreasing order.
-1000 <= target <= 1000
The tests are generated such that there is exactly one solution.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-08-20 16:41
 To: 2021-08-20 16:50
 *********************************************************************************
 Submission Result:
Runtime: 240 ms, faster than 70.66% of C# online submissions for Two Sum II - Input array is sorted.
Memory Usage: 31.9 MB, less than 33.76% of C# online submissions for Two Sum II - Input array is sorted.
 *********************************************************************************
 Note: 
idea by myself, code according to desc section
 *********************************************************************************/
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
    
       //two pointers
    //pre condition
    if(numbers.Length < 2 || numbers == null)
    {
        return new int[2];
    }

    //normal condition
    int left = 0;
    int right = numbers.Length - 1;

    while(left < right)
    {
        int temp_sum = numbers[left] + numbers[right];

        if(temp_sum == target)
        {
            return new int[2]{left+1, right+1};
        }
        else if(temp_sum < target)
        {
            left++;
        }
        else if(temp_sum > target)
        {
            right--;
        }
    }

    return new int[2];
    }
}