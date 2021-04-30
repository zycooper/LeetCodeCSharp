/*
Given two strings s and t, return true if they are both one edit distance apart, otherwise return false.
A string s is said to be one distance apart from a string t if you can:
Insert exactly one character into s to get t.
Delete exactly one character from s to get t.
Replace exactly one character of s with a different character to get t.

Example 1:
Input: s = "ab", t = "acb"
Output: true
Explanation: We can insert 'c' into s to get t.

Example 2:
Input: s = "", t = ""
Output: false
Explanation: We cannot get t from s by only one step.

Example 3:
Input: s = "a", t = ""
Output: true

Example 4:
Input: s = "", t = "A"
Output: true

Constraints:

0 <= s.length <= 104
0 <= t.length <= 104
s and t consist of lower-case letters, upper-case letters and/or digits.
*/

 /********************************************************************************
 Solution Category: 
 | Recursion |
 *********************************************************************************
 Time Range:
 From: 2021-04-30 14:52
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        if(s == t || (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) || Math.Abs(s.Length - t.Length) > 1 ){ return false;}

        var long_arr;
        var short_arr;
        if(s.Length >= t.Length)
        {
            long_arr = s.ToCharArray();
            short_arr = t.ToCharArray();
        }
        else
        {
            short_arr = s.ToCharArray();
            long_arr = t.ToCharArray();
        }
        bool differentCharExist = false;
        for(int i = 0; i < long_arr.Length; i++)
        {
            //i will never go out of board
            if(short_arr[i] != long_arr[i])
            {
                i++;
            }
        }
    }
}