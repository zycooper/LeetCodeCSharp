/*
Given an input string s, reverse the order of the words.
A word is defined as a sequence of non-space characters. 
The words in s will be separated by at least one space.
Return a string of the words in reverse order concatenated by a single space.
Note that s may contain leading or trailing spaces or multiple spaces between two words. 
The returned string should only have a single space separating the words. 
Do not include any extra spaces.

Example 1:
Input: s = "the sky is blue"
Output: "blue is sky the"

Example 2:
Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.

Example 3:
Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

Example 4:
Input: s = "  Bob    Loves  Alice   "
Output: "Alice Loves Bob"

Example 5:
Input: s = "Alice does not even like bob"
Output: "bob like even not does Alice"
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 13:18
 To: 2021-04-27 13:26
 *********************************************************************************
 Submission Result:
Runtime: 88 ms, faster than 70.84% of C# online submissions for Reverse Words in a String.
Memory Usage: 25.5 MB, less than 57.02% of C# online submissions for Reverse Words in a String.
 *********************************************************************************
 Note: 
cool solution, use lambda and single line
 *********************************************************************************/
public class Solution {
    public string ReverseWords(string s) {
       return string.Join(" ",s.Split(' ').Where(x => x != "").Reverse());
    }
}