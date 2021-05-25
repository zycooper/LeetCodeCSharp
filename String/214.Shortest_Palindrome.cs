/*
You are given a string s. You can convert s to a palindrome by adding characters in front of it.
Return the shortest palindrome you can find by performing this transformation.
Example 1:
Input: s = "aacecaaa"
Output: "aaacecaaa"
Example 2:
Input: s = "abcd"
Output: "dcbabcd"
Constraints:
0 <= s.length <= 5 * 104
s consists of lowercase English letters only.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution
{
    //time out
    public string ShortestPalindrome(string s)
    {
        //check if first char is the left boundry of one p str
        int right = 0;
        for (int i = 1; i < s.Length + 1; i++)
        {           
            if ( isPStr(s.Substring(0, i)))
            {
                right = Math.Max(i - 1, right);
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i > right; i--)
        {
            sb.Append(s[i]);
        }

        sb.Append(s);

        return sb.ToString();
    }
    private bool isPStr(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left <= right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return true;
    }
}