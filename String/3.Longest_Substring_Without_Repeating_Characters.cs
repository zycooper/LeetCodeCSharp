/*
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

/********************************************************************************
Solution Category: 
Sliding Window
*********************************************************************************
Time Range:
From: 2021-05-19 10:28
To: 2021-05-19 13:45
*********************************************************************************
Submission Result:
Runtime: 80 ms, faster than 87.82% of C# online submissions for Longest Substring Without Repeating Characters.
Memory Usage: 26.4 MB, less than 58.72% of C# online submissions for Longest Substring Without Repeating Characters.
*********************************************************************************
Note: 
I submit for four times today and the success one is from the official solution, will need to get more familier with the sliding window al, especially how to update left and right cursor.
*********************************************************************************/

public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        //Sliding Window
        if(string.IsNullOrEmpty(s)){ return 0;}
        if(s.Length == 1){ return 1;}
       
        int res = 0;
        int left = 0;
        Dictionary<char,int> dict = new Dictionary<char,int>();

       for (int right = 0; right < s.Length; right++)
            {
                if (dict.Keys.Contains(s[right]))
                {
                    //left = dict[s[right]] + 1;
                    left = Math.Max(dict[s[right]], left);
                }

                dict[s[right]] = right + 1;
                res = Math.Max(res, right - left + 1);
            }

        return res;
    }
    public int LengthOfLongestSubstring(string s)
    {
        //this one below has issue, not work on "dvdf"
        if(string.IsNullOrEmpty(s)){ return 0;}
        if(s.Length == 1){ return 1;}
       
        int res = 0;
            int temp_count = 0;
            List<char> temp_list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (temp_list.Contains(s[i]))
                {
                    //start over
                    temp_list.Clear();                   
                    temp_count = 1;
                }
                else
                {
                    temp_count++;
                }
                res = Math.Max(temp_count, res);
                temp_list.Add(s[i]);
            }

        return res;
    }
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
