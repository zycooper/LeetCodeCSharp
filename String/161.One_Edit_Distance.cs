/*
Given two strings s and t, return true if they are both one edit distance apart, otherwise return false.
A string s is said to be one distance apart from a string t if you can:
Insert exactly one character into s to get t.
Delete exactly one character from s to get t.
Replace exactly one character of s with a different character to get t.

Example 1:
Input: s = "ab", t = "acb"
Output: true
Explanation: We can insert 'c' into s to get t.

Example 2:
Input: s = "", t = ""
Output: false
Explanation: We cannot get t from s by only one step.

Example 3:
Input: s = "a", t = ""
Output: true

Example 4:
Input: s = "", t = "A"
Output: true

Constraints:

0 <= s.length <= 104
0 <= t.length <= 104
s and t consist of lower-case letters, upper-case letters and/or digits.
*/

 /********************************************************************************
 Solution Category: 
 | Recursion |
 *********************************************************************************
 Time Range:
 From: 2021-04-30 14:52
 To: 
 *********************************************************************************
 Submission Result:
Runtime: 64 ms, faster than 98.29% of C# online submissions for One Edit Distance.
Memory Usage: 23.9 MB, less than 18.86% of C# online submissions for One Edit Distance.
 *********************************************************************************
 Note: 
 missing too many corner cases.
 *********************************************************************************/

public class Solution {
 //this one works
    public bool IsOneEditDistance(string s, string t) {
        //check length diff
     
        if(s == t)
        {
            return false;
        }
        else if(Math.Abs(s.Length - t.Length) < 2)
        {
            //loop through the not long one
            string longStr ="";
            string shortStr ="";
            if(s.Length > t.Length)
            {
                longStr = s;
                shortStr =t;
            }
            else
            {
                shortStr =s;
                longStr = t;
            }
          
            if(shortStr.Length == 0 && longStr.Length == 1){ return true;}
            
            for(int i = 0; i < shortStr.Length; i++)
            {
                if(shortStr[i] != longStr[i])
                {    
                    if(s.Length == t.Length)
                    {
                        return shortStr.Substring(i+1) == longStr.Substring(i+1);
                    }
                    else
                    {
                        return shortStr.Substring(i) == longStr.Substring(i+1);
                    }
                }   
            }
         //after loop through and no different character found, the the last one is the one, so return true
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        if(s == t || (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) || Math.Abs(s.Length - t.Length) > 1 ){ return false;}

        var long_arr;
        var short_arr;
        if(s.Length >= t.Length)
        {
            long_arr = s.ToCharArray();
            short_arr = t.ToCharArray();
        }
        else
        {
            short_arr = s.ToCharArray();
            long_arr = t.ToCharArray();
        }
        bool differentCharExist = false;
        for(int i = 0; i < long_arr.Length; i++)
        {
            //i will never go out of board
            if(short_arr[i] != long_arr[i])
            {
                i++;
            }
        }
    }
}
