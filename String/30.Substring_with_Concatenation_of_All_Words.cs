/*
You are given a string s and an array of strings words of the same length. 
Return all starting indices of substring(s) in s that is a concatenation of each word in words exactly once, in any order, 
and without any intervening characters.
You can return the answer in any order.

Example 1:
Input: s = "barfoothefoobarman", words = ["foo","bar"]
Output: [0,9]
Explanation: Substrings starting at index 0 and 9 are "barfoo" and "foobar" respectively.
The output order does not matter, returning [9,0] is fine too.

Example 2:
Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
Output: []

Example 3:
Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]
Output: [6,9,12]

Constraints:
1 <= s.length <= 104
s consists of lower-case English letters.
1 <= words.length <= 5000
1 <= words[i].length <= 30
words[i] consists of lower-case English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-03 16:00
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        //All cases passed, but took too long
        //TLE

        List<int> res = new List<int>();

        Dictionary<string,int> dict = new Dictionary<string,int>();
        int totalLen = 0;
        for(int i = 0; i < words.Length; i++)
        {
            totalLen += words[i].Length;

            if(dict.Keys.Contains(words[i]))
            {
                dict[words[i]]++;
            }
            else
            {
                dict.Add(words[i],1);
            }
        }

        for(int i = 0; i < s.Length - totalLen + 1; i++)
        {
            if(isSub(s.Substring(i,totalLen),dict,words[0].Length))
            {
                res.Add(i);
            }
        }

        return res;
    }

    private bool isSub(string sub_str, Dictionary<string,int> dict_source,int len)
    {
        Dictionary<string,int> dict = new Dictionary<string, int>();

        for(int i = 0 ; i < sub_str.Length; i=i+len)
        {
            string cur_str =sub_str.Substring(i,len);
            if(dict.Keys.Contains(cur_str))
            {
                dict[cur_str]++;
            }
            else
            {
                dict.Add(cur_str,1);
            }
        }

        for(int i = 0; i <dict_source.Count();i++)
        {
            if(!dict.Keys.Contains(dict_source.Keys.ElementAt(i)) || dict[dict_source.Keys.ElementAt(i)] != dict_source[dict_source.Keys.ElementAt(i)])
            {
                return false;
            }
        }

        return true;
    }
}