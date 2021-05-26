/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters 
without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

Example 1:
Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:
Input: s = "axc", t = "ahbgdc"
Output: false

Constraints:
0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-26 16:26
 To: 2021-05-16:23
 *********************************************************************************
 Submission Result:
Runtime: 76 ms, faster than 39.80% of C# online submissions for Is Subsequence.
Memory Usage: 22.3 MB, less than 87.41% of C# online submissions for Is Subsequence.
 *********************************************************************************
 Note: 
bruh..
 *********************************************************************************/
public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(t.Length < s.Length){ return false;}
        if(s == t){ return true; }
        if(s.Length ==0){ return true;}
        //j is cursor for s
        int j = 0;
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] == s[j])
            {
                j++;                
            }
            
            if(j == s.Length){ return true;}
        }
        
        return false;
    }
}