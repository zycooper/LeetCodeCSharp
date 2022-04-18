/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
typically using all the original letters exactly once.

Example 1:
Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Example 2:
Input: strs = [""]
Output: [[""]]

Example 3:
Input: strs = ["a"]
Output: [["a"]]

Constraints:
1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lower-case English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-28 11:08
 To: 2021-04-29 09:31
 *********************************************************************************
 Submission Result:
Runtime: 304 ms, faster than 32.45% of C# online submissions for Group Anagrams.
Memory Usage: 39.4 MB, less than 54.67% of C# online submissions for Group Anagrams.
 *********************************************************************************
 Note: 
I thought this is tricky one, but turns out it's straight as f
just solve it with loop through..
 *********************************************************************************/
 
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {       
        Dictionary<string,List<string>> ans= new Dictionary<string,List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            char[] temp_arr = strs[i].ToCharArray();
            Array.Sort(temp_arr);

            string new_str = new string(temp_arr);
            if(ans.ContainsKey(new_str))
            {
                ans[new_str].Add(strs[i]);
            }
            else
            {
                ans.Add(new_str,new List<string>(){strs[i]});
            }
        }

        return ans.Values.ToArray();
    }
}