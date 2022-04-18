/*
Given a character array s, reverse the order of the words.
A word is defined as a sequence of non-space characters. 
The words in s will be separated by a single space.

Example 1:
Input: s = ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
Output: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]

Example 2:
Input: s = ["a"]
Output: ["a"]

Constraints:
1 <= s.length <= 105
s[i] is an English letter (uppercase or lowercase), digit, or space ' '.
There is at least one word in s.
s does not contain leading or trailing spaces.
All the words in s are guaranteed to be separated by a single space.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 14:00
 To: 2021-04-27 14:14
 *********************************************************************************
 Submission Result:
Runtime: 360 ms, faster than 58.26% of C# online submissions for Reverse Words in a String II.
Memory Usage: 36.8 MB, less than 75.65% of C# online submissions for Reverse Words in a String II.
 *********************************************************************************
 Note: 
double reverse
 *********************************************************************************/
public class Solution {
    public void ReverseWords(char[] s) {
        //reverse all
        ReverseStr(ref s,0,s.Length-1);

        //reverse words
        int left = 0;
        int right = int.MaxValue;
        for(int i = 1; i <= s.Length; i++)
        {
            if(i == s.Length || s[i] == ' ' )
            {
                right = i - 1;
                ReverseStr(ref s,left,right);

                left = i + 1;
            }
        }
    }
    private void ReverseStr(ref char[] s, int left, int right)
    {
        while(left <= right)
        {
            char temp = s[left];
            s[left++] = s[right];
            s[right--] = temp;
        }
    }
}