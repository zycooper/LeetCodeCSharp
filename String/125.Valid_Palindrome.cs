/*
Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
*/

 /********************************************************************************
 Solution Category: 
 Two Pointers
 *********************************************************************************
 Time Range:
 From: 2021-05-24 15:27
 To: 2021-05-24 15:38
 *********************************************************************************
 Submission Result:
Runtime: 76 ms, faster than 84.42% of C# online submissions for Valid Palindrome.
Memory Usage: 24.6 MB, less than 89.13% of C# online submissions for Valid Palindrome.
 *********************************************************************************
 Note: 
use IsLetterOrDigit instead of IsLetter!!!!!
Char.IsLetterOrDigit('')
Char.IsLetter('')
Char.ToLower(s[left])
 *********************************************************************************/
public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s)){ return false;}
        
        if(s.Length == 1){ return true;}
        
        int left = 0;
        int right = s.Length -1;
        
        while(left <= right)
        {
            if(!Char.IsLetterOrDigit (s[left]))
            {
                left++;
            }
            else if(!Char.IsLetterOrDigit (s[right]))
            {
                right--;
            }
            else
            {
                //both left and right position char is letter
                if(Char.ToLower(s[left]) != Char.ToLower(s[right]) )
                {
                    return false;
                }
                
                left++;
                right--;
            }
        }
        
        return true;
    }
}