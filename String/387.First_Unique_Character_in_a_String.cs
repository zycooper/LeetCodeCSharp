/*
Given a string s, return the first non-repeating character in it and return its index. If it does not exist, return -1.

Example 1:
Input: s = "leetcode"
Output: 0

Example 2:
Input: s = "loveleetcode"
Output: 2

Example 3:
Input: s = "aabb"
Output: -1

Constraints:
1 <= s.length <= 105
s consists of only lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 11:28
 To: 2021-04-27 11:44
 *********************************************************************************
 Submission Result: 
 by self
Runtime: 124 ms, faster than 50.80% of C# online submissions for First Unique Character in a String.
Memory Usage: 34.4 MB, less than 14.66% of C# online submissions for First Unique Character in a String.
 *********************************************************************************
 Note: 
get more familir with diconary and array
.ContainsKey
.Values.ElementAt(j)
.Keys.ElementAt(j)
Array.IndexOf(arr,target)
 *********************************************************************************/
public class Solution {
    public int FirstUniqChar(string s) {
        char[] s_arr = s.ToCharArray();

        Dictionary<char,int> dict = new Dictionary<char,int>();

        for(int i = 0; i < s_arr.Length;i++)
        {
            if(dict.ContainsKey(s_arr[i]))
            {
                dict[s_arr[i]] += 1;
            }
            else
            {
                dict.Add(s_arr[i],1);
            }
        }

        for(int j = 0; j < dict.Count();j++)
        {
            if(dict.Values.ElementAt(j) == 1)
            {
                return Array.IndexOf(s_arr,dict.Keys.ElementAt(j));
            }
        }

        return -1;
    }
}