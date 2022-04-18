/*
question
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-24 15:50
 To: 2021-05-24 15:55
 *********************************************************************************
 Submission Result:
Runtime: 68 ms, faster than 50.30% of C# online submissions for Palindrome Number.
Memory Usage: 17 MB, less than 50.26% of C# online submissions for Palindrome Number.
 *********************************************************************************
 Note: 
modified from Q125 very easy one
 *********************************************************************************/
public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        if(string.IsNullOrEmpty(s)){ return false;}        
        if(s.Length == 1){ return true;}
        
        int left = 0;
        int right = s.Length - 1;
        
        while(left <= right)
        {
                //both left and right position char is letter
                if(s[left] != s[right])
                {
                    return false;
                }
                
                left++;
                right--;
            
        }
        
        return true;
    }
}