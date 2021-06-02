/*
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.
A substring is a contiguous sequence of characters within the string.

Example 1:
Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.

Example 2:
Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.

Example 3:
Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.

Constraints:
m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-02 15:15
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution
    {
        //not work on "ab" "b", returns "ab" instead of "b"
        public string MinWindow(string s, string t)
        {
            //pre condition
            if (string.IsNullOrEmpty(s) || s.Length < t.Length) { return ""; }
            //normal condition        
            int left = 0, right = 0;            
            string res = "";

            char target_char = '\0';
            bool UsedtoValid = false;
            bool currentValid = false;
            while (right < s.Length && left < s.Length)
            {
                if (left == 0 && !UsedtoValid)
                {
                    //only for first valid substring
                    if (s_Contain_t(s.Substring(left, right - left + 1),t))
                    {
                        //start point
                        //res_left = left;                      
                        res = s.Substring(left, right - left + 1);
                        UsedtoValid = true;
                        currentValid = true;
                    }
                    else
                    {
                        right++;
                    }
                }
                else
                {
                    //already has one res
                    if (currentValid)
                    {
                        if (t.Contains(s[left]))
                        {
                            target_char = s[left];
                            left++;

                            currentValid = s_Contain_t(s.Substring(left, right - left + 1), t);                           
                        }
                        else 
                        {
                            left++;
                        }
                    }
                    else
                    {
                        if (s[right] == target_char)
                        {
                            if (!t.Contains(s[left]))
                            {
                                left++;
                            }
                            else 
                            {
                                //match
                                if (res.Length > s.Substring(left, right - left + 1).Length)
                                {
                                    res = s.Substring(left, right - left + 1);
                                }

                                currentValid = true;
                            }
                          
                        }
                        else 
                        {
                            right++;
                        }
                    }
                }
            }

            return res;
        }

        private bool s_Contain_t(string s, string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (!s.Contains(t[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }