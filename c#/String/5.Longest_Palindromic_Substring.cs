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
 Solution Category: 
 Two Pointers && 
 *********************************************************************************
 Time Range:
 From: 2021-05-24 16:02
 To: 2021-05-24 23:55
 *********************************************************************************
 Submission Result:
Runtime: 88 ms, faster than 95.40% of C# online submissions for Longest Palindromic Substring.
Memory Usage: 24.7 MB, less than 68.34% of C# online submissions for Longest Palindromic Substring.
 *********************************************************************************
 Note: 

 *********************************************************************************/

public class Solution {
 //accordint to huahua on ytb
    public string LongestPalindrome(string s) {
        //final result's start index and length
        int start = 0;
        int len = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            int cur_len = Math.Max(SubStr(s,i,i),SubStr(s,i,i+1));
            
            if(cur_len > len)
            {
                //update len and start
                len = cur_len;
                start = i - (len-1)/2;
            }
        }
        
        return s.Substring(start,len);
    }
    
    private int SubStr(string s, int left,int right)
    {
        while(left >=0 && right <= s.Length-1 && s[left] == s[right])
        {
            left--;
            right++;
        }
        
        //because right and left are acutally out of boundry since when they jump out of the while, they have been -- and ++ already
        return right - left - 1;
    }
}

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
