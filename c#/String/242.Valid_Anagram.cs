/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false
 
Constraints:
1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-28 11:00
 To: 2021-04-28 11:06
 *********************************************************************************
 Submission Result:
Runtime: 88 ms, faster than 56.38% of C# online submissions for Valid Anagram.
Memory Usage: 24.4 MB, less than 73.90% of C# online submissions for Valid Anagram.
 *********************************************************************************
 Note: 
    for specific char with index of string: string[index]

    need to get more familir with dictionary function and property
    ElementAt
    
 *********************************************************************************/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != 0 && t.Length !=0 && s.Length != t.Length ){ return false;}

        var dict_s = dictionary_generator(s);
        var dict_t = dictionary_generator(t);

        if(dict_s.Count() != dict_t.Count()){return false;}

        for(int i =0; i < dict_s.Count();i ++)
        {
            if (!dict_t.ContainsKey(dict_s.ElementAt(i).Key) || dict_t[dict_s.ElementAt(i).Key] != dict_s.ElementAt(i).Value)
            {
                return false;
            }
        }

        return true;
    }

    private Dictionary<char,int> dictionary_generator(string str)
    {
        Dictionary<char,int> result = new Dictionary<char, int>();

        for(int i =0; i < str.Length; i++)
        {
            if(result.ContainsKey(str[i]))
            {
                result[str[i]] += 1;
            }
            else
            {
                result.Add(str[i],1);
            }
        }

        return result;
    }
}