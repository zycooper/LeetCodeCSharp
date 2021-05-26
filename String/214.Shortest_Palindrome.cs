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
 Solution Category: 
 KMP
 *********************************************************************************
 Time Range:
 From: 2021-05-25
 To: 2021-05-26 13:37
 *********************************************************************************
 Submission Result:
Runtime: 84 ms, faster than 83.67% of C# online submissions for Shortest Palindrome.
Memory Usage: 25.2 MB, less than 34.69% of C# online submissions for Shortest Palindrome.
 *********************************************************************************
 Note: 
use KMP to solve this, not all the function, just need to calculate the next table
will need to check KMP again later

to reverse a string :  string reverseStr = new string(sampleStr.Reverse().ToArray())
slower than            string reverseStr = new string(sampleStr.ToCharArray().Reverse().ToArray());
 *********************************************************************************/
 public class Solution
{
    
    public string ShortestPalindrome(string s)
    {       
        //KMP
        //pre-condition
        
        //normal-condition
        string reverseStr = new string(s.ToCharArray().Reverse().ToArray());
            //new string(s.Reverse().ToArray());
        string Str = s  + "#" + reverseStr;
        
        int[] kmp_tbl =new int[Str.Length];
        
        for(int i = 1; i < Str.Length; i++)
        {
            //i is suffix index
            //j is prefix index
            int j = kmp_tbl[i-1];
            
            //move j to the last char which doesn't match
            while(j > 0 && Str[j] != Str[i])
            {
                j = kmp_tbl[j-1];
            }
            
            //update kmp table if the current still match
            if(Str[j] == Str[i])
            {
                kmp_tbl[i] = j + 1;
            }
        }
        
        return reverseStr.Substring(0,s.Length-kmp_tbl[Str.Length - 1]) + s;
        
    }
}
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