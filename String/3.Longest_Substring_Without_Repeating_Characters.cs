/*
TABBBBBBB
Given a string s, find the length of the longest substring without repeating characters.

Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Example 4:
Input: s = ""
Output: 0

Constraints:
 > 0 <= s.length <= 5 * 104
 > s consists of English letters, digits, symbols and spaces.

*/
/*
Tab
*/

/*-- Test --*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //first try
        //11/16/2020
        //Length: not work

        if(s.Length >0)
        {
            //toCharArray() need to remember
            char[] chars = s.ToCharArray();            
            string longestStr ="";
            string currentSubStr = "";

            for(var i = 0; i < chars.Length;i++)
            {
                if(!currentSubStr.Contains(chars[i]))
                {
                    currentSubStr += chars[i];

                    if(longestStr.Length < currentSubStr.Length)
                    {
                        longestStr = currentSubStr;
                    }
                }
                else
                {
                    if(longestStr.Length < currentSubStr.Length)
                    {
                        longestStr = currentSubStr;
                    }                    
                    currentSubStr = chars[i].ToString();
                }
            }

            return longestStr.Length;
        }
        else
        {
            return 0;
        }
    }

    private int LengthOfLongestSubstring_1(string s)
    {
        //use two for loop to loop all the substrings then return the longest not repeat one
        //add another func to check if this substring is repeat or not
        return -1;
    }
}
