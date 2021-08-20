/*
Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 

Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.
Example 2:

Input: num = 0
Output: 0
 

Constraints:

0 <= num <= 231 - 1
 
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-08-20 16:22
 To:   2021-08-20 16:27
 *********************************************************************************
 Submission Result:
Runtime: 44 ms, faster than 45.31% of C# online submissions for Add Digits.
Memory Usage: 15.7 MB, less than 5.21% of C# online submissions for Add Digits.
 *********************************************************************************
 Note: 
easy one, all by self
 *********************************************************************************/
public class Solution {
    public int AddDigits(int num) {
        /*
        int len = num.ToString().Length();

        while(len > 1)
        {
            int temp =0;

            for(int i = 0; i < num.ToString().Length(); i++)
            {
                temp += numToString()[i] - '0';
            }

            num = temp;
            len = num.ToString().Length();
        }

        return num;
        */
    }
}