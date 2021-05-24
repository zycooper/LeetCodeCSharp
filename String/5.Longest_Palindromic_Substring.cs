/*
Given a string s, return the longest palindromic substring in s.

 

Example 1:

Input: s = "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
Example 3:

Input: s = "a"
Output: "a"
Example 4:

Input: s = "ac"
Output: "a"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters (lower-case and/or upper-case),
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-24 16:02
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    //time out
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s)){return "";}
        if(s.Length == 1){return s;}
        
        string res = "";
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = s.Length - 1; j >= i;j--)
            {
                string temp_str = s.Substring(i, j-i+1);
                if(s[i] == s[j] && isPalindromic(temp_str))
                {
                    res = temp_str.Length > res.Length?temp_str:res;
                }
            }
        }
        
        return res;
    }
    private bool isPalindromic(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        
        while(left <= right)
        {
                //both left and right position char is letter
                if(s[left] != s[right])
                {
                    return false;
                }
                
                left++;
                right--;
            
        }
        
        return true;
    }
}