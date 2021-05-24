/*
Given a string s, return the length of the longest substring that contains at most two distinct characters.

 

Example 1:

Input: s = "eceba"
Output: 3
Explanation: The substring is "ece" which its length is 3.
Example 2:

Input: s = "ccaabbb"
Output: 5
Explanation: The substring is "aabbb" which its length is 5.
 

Constraints:

1 <= s.length <= 104
s consists of English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-24 13:48
 To: 2021-05-24 14:20
 *********************************************************************************
 Submission Result:
Runtime: 84 ms, faster than 47.95% of C# online submissions for Longest Substring with At Most Two Distinct Characters.
Memory Usage: 23.1 MB, less than 40.41% of C# online submissions for Longest Substring with At Most Two Distinct Characters.
 *********************************************************************************
 Note: 
modified from Q340 LengthOfLongestSubstringKDistinct
 *********************************************************************************/
public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        //pre-condition
        if(s.Length < 2){ return s.Length;}
        if(string.IsNullOrEmpty(s)){ return 0;}
        
        //normal condition
        //each one record the last index
        Dictionary<char,int> dict = new Dictionary<char,int>();
        
        //result
        int res = 0;
        
        //left is the left boundry of current sub string
        int left = 0;
        //loop through the string s
        //i is the right boundry
        for(int right = 0; right < s.Length; right++)
        {
            if(dict.Count() == 2 && !dict.Keys.Contains(s[right]))
            {
                //count is more than 2 and the current one already exist, need to push current one in the dict
                for(int j = left; j < right; j++)
                {
                    //find the first char which ends first
                    if(dict[s[j]] == j)
                    {
                        //set the left to the right side of current j
                        left = j + 1;
                        //reset the char at j
                        dict.Remove(s[j]);
                        //
                        dict[s[right]] = right;
                        
                        break;
                    }
                }
            }
            else
            {
                dict[s[right]] = right;
            }
            
            res = Math.Max(res,right - left + 1);
        }
        
        return res;
    }
}