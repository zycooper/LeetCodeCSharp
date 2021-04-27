/*
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 09:15
 To: 2021-004-27 09:31
 *********************************************************************************
 Submission Result:
 self created
Runtime: 112 ms, faster than 25.61% of C# online submissions for Longest Common Prefix.
Memory Usage: 28.3 MB, less than 8.57% of C# online submissions for Longest Common Prefix.

Runtime: 100 ms, faster than 76.26% of C# online submissions for Longest Common Prefix.
Memory Usage: 26 MB, less than 16.07% of C# online submissions for Longest Common Prefix.
 *********************************************************************************
 Note: 
for 1st submission, be carefull about the second for loop with the temp_result, if there is no temp_result, if there is any match it will return the current result which might be wrong cause the rest may not match
for 2nd BS: use right instead of left at last of while, because the check is left <= right, when it reach the end, either left is greater than right(which left is wrong) or left equals right 
 
 *********************************************************************************/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {

            string prefixStr = "";

            for (int i = 1; i < strs[0].Length + 1; i++)
            {
                bool temp_result = true;
                for (int j = 1; j < strs.Length; j++)
                {                                      
                    if (strs[j].Length < i || !strs[0].Substring(0, i).Equals(strs[j].Substring(0, i)))
                    {
                        temp_result = false;
                    }
                }
                if (temp_result)
                {
                    prefixStr = strs[0].Substring(0, i);
                }
            }

            return prefixStr;
    }
    public string LongestCommonPrefix_BS(string[] strs)
    {
        int left = 0;
        int right = int.MaxValue;

        for(int i = 0; i < strs.Length; i++)
        {
            right = Math.Min(right,strs[i].Length);
        }

        while(left <= right)
        {
            int mid = left + (right - left)/2;

            if(BinarySearchResultEqual(strs,mid))
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        //use right instead of left!!!
        return strs[0].Substring(0,right);
    }
    private bool BinarySearchResultEqual(string[] strs,int index)
    {
                for (int j = 1; j < strs.Length; j++)
                {                                      
                    if (strs[j].Length < index || !strs[0].Substring(0, index).Equals(strs[j].Substring(0, index)))
                    {
                        return false;
                    }
                }                
                return true;;
    }
}