/*
Write a function that reverses a string. The input string is given as an array of characters s.

Example 1:
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

Constraints:
1 <= s.length <= 105
s[i] is a printable ascii character.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 12:50
 To: 2021-04-27 12:53 --- I know
 *********************************************************************************
 Submission Result:
by self
Runtime: 344 ms, faster than 84.31% of C# online submissions for Reverse String.
Memory Usage: 35.7 MB, less than 20.28% of C# online submissions for Reverse String.
 *********************************************************************************
 Note: 
just enjoy it :)
 *********************************************************************************/
public class Solution {
    public void ReverseString(char[] s) {

        int left = 0; 
        int right = s.Length -1;
        while(left <= right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
}