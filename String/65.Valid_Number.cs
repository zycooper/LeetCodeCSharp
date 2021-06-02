/*
A valid number can be split up into these components (in order):

A decimal number or an integer.
(Optional) An 'e' or 'E', followed by an integer.
A decimal number can be split up into these components (in order):

(Optional) A sign character (either '+' or '-').
One of the following formats:
At least one digit, followed by a dot '.'.
At least one digit, followed by a dot '.', followed by at least one digit.
A dot '.', followed by at least one digit.
An integer can be split up into these components (in order):

(Optional) A sign character (either '+' or '-').
At least one digit.
For example, all the following are valid numbers: ["2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789"], 
while the following are not valid numbers: ["abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53"].

Given a string s, return true if s is a valid number.

Example 1:
Input: s = "0"
Output: true

Example 2:
Input: s = "e"
Output: false

Example 3:
Input: s = "."
Output: false

Example 4:
Input: s = ".1"
Output: true

Constraints:
1 <= s.length <= 20
s consists of only English letters (both uppercase and lowercase), digits (0-9), plus '+', minus '-', or dot '.'.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-19 10:17
 To: 2021-06-02 15:11
 *********************************************************************************
 Submission Result:
Runtime: 116 ms, faster than 21.51% of C# online submissions for Valid Number.
Memory Usage: 26 MB, less than 94.19% of C# online submissions for Valid Number.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public bool IsNumber(string s) {
        bool seenDigit = false; //IsDigit
        bool seenE = false;
        bool seenDot = false;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                //digit
                seenDigit = true;
            }
            else if(s[i] == '+' || s[i] == '-')
            {
                // + -
                //i !=0 && !seenE  used to be wrong for "459277e38+"
                if(i>0 && s[i - 1] != 'E' && s[i - 1] != 'e' )
                {
                    //not in first char or the first one after E
                    return false;
                }
            }
            else if(s[i] == 'E' || s[i] =='e')
            {
                //E
                if(!seenDigit || seenE)
                {
                    return false;
                }
                //used to forgot to reset these
                //and it's wrong for "0e"
                seenDigit = false;
                seenE = true;
            }
            else if(s[i] == '.')
            {
                //Dot
                if(seenE || seenDot)
                {
                    return false;
                }
                
                //used to forgot to rest seenDot
                //and it's wrong for "..2"
                seenDot = true;
            }
            else
            {
                //other char
                return false;
            }

        }
        
        return seenDigit;
    }
}