/*
We can shift a string by shifting each of its letters to its successive letter.
For example, "abc" can be shifted to be "bcd".
We can keep shifting the string to form a sequence.
For example, we can keep shifting "abc" to form the sequence: "abc" -> "bcd" -> ... -> "xyz".
Given an array of strings [strings], group all strings[i] that belong to the same shifting sequence. 
You may return the answer in any order.

Example 1:
Input: strings = ["abc","bcd","acef","xyz","az","ba","a","z"]
Output: [["acef"],["a","z"],["abc","bcd","xyz"],["az","ba"]]
Example 2:
Input: strings = ["a"]
Output: [["a"]]

Constraints:
1 <= strings.length <= 200
1 <= strings[i].length <= 50
strings[i] consists of lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 
 | Dictionary |
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-04-29 10:17
 *********************************************************************************
 Submission Result:
Runtime: 240 ms, faster than 96.50% of C# online submissions for Group Shifted Strings.
Memory Usage: 34.2 MB, less than 8.39% of C# online submissions for Group Shifted Strings.
 *********************************************************************************
 Note: 
need to add another function to return to the very first alpha word
 *********************************************************************************/
public class Solution {
    public IList<IList<string>> GroupStrings(string[] strings) {
        Dictionary<string,List<string>> ans = new Dictionary<string,List<string>>();

        for(int i = 0; i < strings.Length; i++)
        {
            string alpha = alpha_str(strings[i]);

            if(ans.ContainsKey(alpha))
            {
                ans[alpha].Add(strings[i]);
            }
            else
            {
                ans.Add(alpha,new List<string>(){strings[i]});
            }
        }

        return ans.Values.ToArray();
    }
    private string alpha_str(string str)
    {
        if(str.Length == 1){ return "a";}

        //set res to a or null all works
        //since the res will start with the next character
        string res ="a";
        
        for(int i = 1; i < str.Length; i++)
        {
            int diff = str[i] - str[i - 1];
            res += 'a' + (diff + 26)%26;
        }

        return res;
    }
}