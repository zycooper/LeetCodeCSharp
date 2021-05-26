/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([)]"
Output: false

Example 5:
Input: s = "{[]}"
Output: true

Constraints:
1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/

 /********************************************************************************
 Solution Category: 
 Stack
 *********************************************************************************
 Time Range:
 From: 2021-05-26 16:10
 To: 2021-05-26 16:23
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 
Stack
need to know:
prop: Count
func: Pop() Push() Peak()
 *********************************************************************************/
public class Solution {
    public bool IsValid(string s) {
         Stack<char> sign = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                sign.Push(')');
            }
            else if(s[i] == '[')
            {
                sign.Push(']');
            }
            else if(s[i] == '{')
            {
                sign.Push('}');
            }
            else if(sign.Count == 0 || sign.Pop() != s[i])
            {
                return false;
            }
        }

        //cannot return true directly, for "["
        return sign.Count == 0;
    }
}