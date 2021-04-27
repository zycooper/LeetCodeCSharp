/*
Given a string s consists of some words separated by spaces, 
return the length of the last word in the string. If the last word does not exist, return 0.
A word is a maximal substring consisting of non-space characters only.

Example 1:
Input: s = "Hello World"
Output: 5
Example 2:
Input: s = " "
Output: 0
 
Constraints:
1 <= s.length <= 104
s consists of only English letters and spaces ' '.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27
 To: 2021-04-27
 *********************************************************************************
 Submission Result:
Runtime: 76 ms, faster than 57.81% of C# online submissions for Length of Last Word.
Memory Usage: 22.9 MB, less than 49.11% of C# online submissions for Length of Last Word.
 *********************************************************************************
 Note: 
    ---> Split
    consider all the corner cases, need to trim and check lengh
 *********************************************************************************/
public class Solution {
    public int LengthOfLastWord(string s) {
        s= s.Trim();
        string[] s_arr = s.Split(' ');

        return (s_arr.Length ==0)?0: s_arr[s_arr.Length - 1].Length;
    }
}