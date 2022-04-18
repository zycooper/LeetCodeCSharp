/*
Given a string s, remove duplicate letters so that every letter appears once and only once. 
You must make sure your result is the smallest in lexicographical order among all possible results.
Note: This question is the same as 1081: https://leetcode.com/problems/smallest-subsequence-of-distinct-characters/

Example 1:
Input: s = "bcabc"
Output: "abc"

Example 2:
Input: s = "cbacdcbc"
Output: "acdb"

Constraints:
1 <= s.length <= 104
s consists of lowercase English letters.
*/
 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-12 15:34
 To: 2021-05-13 23:34
 *********************************************************************************
 Submission Result:
Runtime: 84 ms, faster than 79.17% of C# online submissions for Remove Duplicate Letters.
Memory Usage: 24.6 MB, less than 63.54% of C# online submissions for Remove Duplicate Letters.

 *********************************************************************************
 Note: 
https://www.youtube.com/watch?v=YbY1abVflOY&t=634s
 *********************************************************************************/
public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int n = s.Length;
        
        if(n == 1){ return s;}
        
        int[] lastOccur = new int[26];
        bool[] used = new bool[26];
        StringBuilder sb = new StringBuilder();
        //fill lastOccur
        for(int i = 0; i< n; i++)
        {
            lastOccur[s[i] - 'a'] = i;
        }
        
        //start to build
        for(int i = 0; i < n; i++)
        {
            char cur = s[i];
            
            //missing this step causes 1st submit failed
            if(used[cur - 'a']) continue;
            
            while(
                //current result has char
                sb.Length > 0
                //current char is greater than last char of sb
                 && sb[sb.Length - 1] > cur 
                //there is no such char of last char of sb later than cur
                && lastOccur[sb[sb.Length - 1] - 'a'] > i
                 )
            {
                used[sb[sb.Length - 1] - 'a'] = false;
                sb.Remove(sb.Length - 1,1);
            }
            
            sb.Append(cur);
            used[cur - 'a'] = true;
        }
        
        return sb.ToString();
    }
}
