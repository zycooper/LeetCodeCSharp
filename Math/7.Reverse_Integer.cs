/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
Example 4:

Input: x = 0
Output: 0
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-08-18 14:28
 To: 2021-08-18 15:04
 *********************************************************************************
 Submission Result:
Runtime: 40 ms, faster than 83.50% of C# online submissions for Reverse Integer.
Memory Usage: 15.3 MB, less than 63.44% of C# online submissions for Reverse Integer.
 *********************************************************************************
 Note: 
check if overflow in the while not after the while since it may cause exception during the calculation
 *********************************************************************************/
public class Solution {
    public int Reverse(int x) {
        int result = 0;
        
        while(x !=0)
        {
            int pop = x % 10;
            x /= 10;
            //int max and min
            if(result > int.MaxValue/10 || (result == int.MaxValue/10 && pop >7)){ return 0;}
            if(result < int.MinValue/10 || (result == int.MinValue/10 && pop < -8)){ return 0;}
            result = result * 10 + pop;
        }

        return result;
    }
}