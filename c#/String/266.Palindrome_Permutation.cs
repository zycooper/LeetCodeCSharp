/*
Given a string s, return true if a permutation of the string could form a palindrome.

 

Example 1:

Input: s = "code"
Output: false
Example 2:

Input: s = "aab"
Output: true
Example 3:

Input: s = "carerac"
Output: true
 

Constraints:

1 <= s.length <= 5000
s consists of only lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-24 15:42
 To: 2021-05-24 15:48
 *********************************************************************************
 Submission Result:
Runtime: 76 ms, faster than 46.93% of C# online submissions for Palindrome Permutation.
Memory Usage: 22.2 MB, less than 75.45% of C# online submissions for Palindrome Permutation.
 *********************************************************************************
 Note: 


 *********************************************************************************/
 public class Solution {
     /*
     Runtime: 72 ms, faster than 74.01% of C# online submissions for Palindrome Permutation.
     Memory Usage: 22.6 MB, less than 19.49% of C# online submissions for Palindrome Permutation.    
     */
    public bool CanPermutePalindrome(string s) {
        //pre-condition
        
        //normal condition
        int[] dict = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
        }
        
        //below is optimize one
        int count =0;
        for(int i = 0; i < 26; i++)
        {
            count += dict[i]%2;
        }
        
        return count <=1;
        /*
        //below is the first time submit, 48% speed
        if(s.Length%2 ==0)
        {
            //even
            for(int i = 0; i < 26; i++)
            {
                if(dict[i] > 0 && dict[i]%2 !=0)
                {
                    return false;
                }
            }
        }
        else
        {
            //odd
            bool oddused = false;
            
            for(int i = 0; i < 26; i++)
            {
                if(dict[i] > 0 && dict[i]%2 !=0 && oddused)
                {
                    return false;   
                }
                else if(dict[i] > 0 && dict[i]%2 !=0 && !oddused)
                {
                    oddused = true;
                }
            }
        }
        */
        
        return true;
    }
}
public class Solution {
    public bool CanPermutePalindrome(string s) {
        //pre-condition
        
        //normal condition
        int[] dict = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
        }
        
        if(s.Length%2 ==0)
        {
            //even
            for(int i = 0; i < 26; i++)
            {
                if(dict[i] > 0 && dict[i]%2 !=0)
                {
                    return false;
                }
            }
        }
        else
        {
            //odd
            bool oddused = false;
            
            for(int i = 0; i < 26; i++)
            {
                if(dict[i] > 0 && dict[i]%2 !=0 && oddused)
                {
                    return false;   
                }
                else if(dict[i] > 0 && dict[i]%2 !=0 && !oddused)
                {
                    oddused = true;
                }
            }
        }
        
        return true;
    }
}