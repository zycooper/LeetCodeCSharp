/*
Implement strStr().
Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
Clarification:
What should we return when needle is an empty string? This is a great question to ask during an interview.
For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().

Example 1:
Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1

Example 3:
Input: haystack = "", needle = ""
Output: 0

Constraints:
0 <= haystack.length, needle.length <= 5 * 104
haystack and needle consist of only lower-case English characters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 09:00
 To: 2021-04-27 09:11
 *********************************************************************************
 Submission Result:
Runtime: 76 ms, faster than 66.17% of C# online submissions for Implement strStr().
Memory Usage: 23.4 MB, less than 33.08% of C# online submissions for Implement strStr().
 *********************************************************************************
 Note: 
 need to memorize: IsNullOrEmpty Substring

 in c#, Substring has two param: start index and length which is different from java which is start index and end index
 *********************************************************************************/
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        if(haystack.Length >= needle.Length)
        {
            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if(haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }
        }
        
        return -1;
    }
}