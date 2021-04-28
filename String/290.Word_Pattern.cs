/*
Given a pattern and a string s, find if s follows the same pattern.
Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

Example 1:
Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:
Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:
Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
Example 4:
Input: pattern = "abba", s = "dog dog dog dog"
Output: false
 

Constraints:
1 <= pattern.length <= 300
pattern contains only lower-case English letters.
1 <= s.length <= 3000
s contains only lower-case English letters and spaces ' '.
s does not contain any leading or trailing spaces.
All the words in s are separated by a single space.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-28 10:32
 To: 2021-04-28 10:44
 *********************************************************************************
 Submission Result:
    Runtime: 84 ms, faster than 22.73% of C# online submissions for Word Pattern.
    Memory Usage: 22.7 MB, less than 51.70% of C# online submissions for Word Pattern.
 *********************************************************************************
 Note: 
same with Q205

 dict_pattern.ContainsKey(arr_pattern[i]) != dict_s.ContainsKey(arr_s[i]) ----> stored pattern not match
 (dict_pattern.ContainsKey(arr_pattern[i]) && dict_s.ContainsKey(arr_s[i]) && dict_pattern[arr_pattern[i]] != dict_s[arr_s[i]]) -----> both element stored but map to different element
 *********************************************************************************/
public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,int> dict_pattern = new Dictionary<char, int>();
        Dictionary<string,int> dict_s = new Dictionary<string, int>();

        char[] arr_pattern = pattern.ToCharArray();
        string[] arr_s = s.Split(' ');

        if(arr_pattern.Length == 0 && arr_s.Length ==0){return true;}
        if(arr_pattern.Length != arr_s.Length){ return false;}

        for(int i = 0; i < arr_pattern.Length; i++)
        {
            //not match
            //
            if(
                dict_pattern.ContainsKey(arr_pattern[i]) != dict_s.ContainsKey(arr_s[i])
            || (dict_pattern.ContainsKey(arr_pattern[i]) && dict_s.ContainsKey(arr_s[i]) && dict_pattern[arr_pattern[i]] != dict_s[arr_s[i]])
            )
            {
                return false;
            }
            //add to dict
            if(!dict_pattern.ContainsKey(arr_pattern[i]))
            {
                dict_pattern.Add(arr_pattern[i],i);
                dict_s.Add(arr_s[i],i);
            }
        }

        return true;
    }
}