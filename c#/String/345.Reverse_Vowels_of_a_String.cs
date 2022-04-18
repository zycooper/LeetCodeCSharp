/*
Given a string s, reverse only all the vowels in the string and return it.
The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.

Example 1:
Input: s = "hello"
Output: "holle"

Example 2:
Input: s = "leetcode"
Output: "leotcede"

Constraints:
1 <= s.length <= 3 * 105
s consist of printable ASCII characters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 14:20
 To: 2021-04-27 14:44
 *********************************************************************************
 Submission Result:
Runtime: 112 ms, faster than 20.00% of C# online submissions for Reverse Vowels of a String.
Memory Usage: 28.8 MB, less than 19.23% of C# online submissions for Reverse Vowels of a String.
 *********************************************************************************
 Note: 
be carefull about the two pointers switch, assign temp, then swith, at last assign temp back to another
 *********************************************************************************/
public class Solution {
    public string ReverseVowels(string s) {        
        if(s.Length <= 0){ return s;}
        
        int left = 0;
        int right = s.Length - 1;
        List<string> vowel = new List<string>(){"A","E","I","O","U"};

        StringBuilder sb = new StringBuilder(s);

        while(left <= right)
        {
            string left_char = sb[left].ToString().ToUpper();
            string right_char = sb[right].ToString().ToUpper();

            if(vowel.Contains(left_char) && vowel.Contains(right_char))
            {
                char temp = sb[left];                
                sb[left++] = sb[right];
                sb[right--] = temp;
            }            
            else if(vowel.Contains(left_char))
            {
                right--;
            }
            else if(vowel.Contains(right_char))
            {
                left++;
            }
            else
            {
                left++;
                right--;
            }
        }

        return sb.ToString();
    }
}