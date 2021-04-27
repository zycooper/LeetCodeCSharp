/*
Given two strings s and t, determine if they are isomorphic.
Two strings s and t are isomorphic if the characters in s can be replaced to get t.
All occurrences of a character must be replaced with another character while preserving the order of characters. 
No two characters may map to the same character, but a character may map to itself.

Example 1:
Input: s = "egg", t = "add"
Output: true
Example 2:
Input: s = "foo", t = "bar"
Output: false
Example 3:
Input: s = "paper", t = "title"
Output: true

Constraints:
1 <= s.length <= 5 * 104
t.length == s.length
s and t consist of any valid ascii character.
*/

 /********************************************************************************
 Solution Category: 
 | HashTable | Dictionary |
 *********************************************************************************
 Time Range:
 From: 2021-04-27 14:50
 To: 2021-04-27 16:03
 *********************************************************************************
 Submission Result:
    Runtime: 68 ms, faster than 98.97% of C# online submissions for Isomorphic Strings.
    Memory Usage: 24.4 MB, less than 21.99% of C# online submissions for Isomorphic Strings.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
     public bool IsIsomorphic_2nd(string s, string t) {
        Dictionary<char,int> dict_s = new Dictionary<char,int>();
        Dictionary<char,int> dict_t = new Dictionary<char,int>();

        StringBuilder sb_s = new StringBuilder(s);
        StringBuilder sb_t = new StringBuilder(t);

        for(int i = 0; i < s.Length; i++)
        {
            if(
                dict_s.ContainsKey(sb_s[i]) != dict_t.ContainsKey(sb_t[i])
                || (dict_s.ContainsKey(sb_s[i]) && dict_t.ContainsKey(sb_t[i]) && dict_s[sb_s[i]] != dict_t[sb_t[i]])
            )
            {                
                return false;
            }

            if(!dict_s.ContainsKey(sb_s[i]))
            {
                dict_s.Add(sb_s[i],i);
                dict_t.Add(sb_t[i],i);
            }
        }

        return true;
    }
    public bool IsIsomorphic(string s, string t) {
        //totally wrong
        if(s.Length == 0){ return true;}
        if(s.Length == 1 && s==t){ return true;}

        StringBuilder sb_s = new StringBuilder(s);
        StringBuilder sb_t = new StringBuilder(t);

        for(int i = 1; i < s.Length; i++)
        {            
            bool result_s = sb_s[i] != sb_s[i-1];
            bool result_t = sb_t[i] != sb_t[i-1];

            if(result_s != result_t)
            {
                return false;
            }
        }

        return true;
    }
}