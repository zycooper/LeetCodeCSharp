/*
Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-08-19 14:49
 To: 2021-08-19 15:01
 *********************************************************************************
 Submission Result:
Runtime: 240 ms, faster than 40.92% of C# online submissions for Plus One.
Memory Usage: 30.8 MB, less than 47.31% of C# online submissions for Plus One.
 *********************************************************************************
 Note: 
All by my self, O(n)
initialize a new int[], if not set the value, all element will be 0.
 *********************************************************************************/
public class Solution {
    public int[] PlusOne(int[] digits) {
        
        //find the last digit which is not 9, then plus one and set the rest of it 0;        
        for(int i = digits.Length - 1; i >=0 ; i--)
        {
            if(digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }

        int[] result = new int[digits.Length + 1];

        result[0] = 1;
        return result;        
    }
}