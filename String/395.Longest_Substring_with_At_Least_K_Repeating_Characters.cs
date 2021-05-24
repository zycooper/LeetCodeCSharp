/*
Given a string s and an integer k, return the length of the longest substring of s such that the frequency of each character in this substring is greater than or equal to k.

 

Example 1:

Input: s = "aaabb", k = 3
Output: 3
Explanation: The longest substring is "aaa", as 'a' is repeated 3 times.
Example 2:

Input: s = "ababbc", k = 2
Output: 5
Explanation: The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.
 

Constraints:

1 <= s.length <= 104
s consists of only lowercase English letters.
1 <= k <= 105
*/

 /********************************************************************************
 Solution Category: 
 Divide And Conquer | Recursion
 *********************************************************************************
 Time Range:
 From: 
 To: 
 *********************************************************************************
 Submission Result:
Runtime: 68 ms, faster than 100.00% of C# online submissions for Longest Substring with At Least K Repeating Characters.
Memory Usage: 22.6 MB, less than 56.82% of C# online submissions for Longest Substring with At Least K Repeating Characters.
 *********************************************************************************
 Note: 

 *********************************************************************************/
 //working one below
 public class Solution {
     //basically the same solution from previous,split the string into smaller and smaller piece and check each one's length, get the longest one
    public int LongestSubstring(string s, int k) {
      
        int[] dict = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
        }
        
        bool allmatch = true;
        for(int d = 0; d < dict.Length; d++)
        {
            if(dict[d] < k && dict[d] > 0)
            {
                allmatch = false;
            }
        }
        
        if(allmatch)
        {
            return s.Length;
        }
        
        int res = 0;

        for(int j = 0; j < s.Length; j++)
        {
            if(dict[s[j] - 'a'] < k)
            {
                //delimiter
                continue;
            }
            else
            {
                int right = j;
                while(right < s.Length && dict[s[right] - 'a'] >= k)
                {
                    right++;
                }
                
                res =  Math.Max(res, LongestSubstring(s.Substring(j,right - j), k));
                j = right;
            }
        }
        
        return res;
    }
       
}
public class Solution {
 //first try, doesn't work on "bbaaacb" - 3
    public int LongestSubstring(string s, int k) {
        //5/23/2021 first try:
        /*
         1. create a map store each char and it's occrurent time
         2. chekc all the substring delimit by the char which has the un-qulified ocurrent time
         3. return the longest length among these substrings
        */
        
        /*
        After check the Divide and Conquer
        */
        //pre-condition
        if(s.Length < k){ return 0;}
        if(s.Length < 2){ return s.Length;}
        
        //dict could be replaced by a int[] because each char has it's own index
        //Dictionary<char,int> dict = new Dictionary<char,int>();
        int[] dict = new int[26];
        int res = 0;
        
        
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
        }
        
        int left = 0;
        int right = 0;
        
        for(int j = 0; j < s.Length; j++)
        {
            if(dict[s[j] - 'a'] >= k)
            {
                //not delimiter
                right = j;
            }
            else if(j != s.Length - 1)
            {
                //reset left and right
                left = j + 1;
                right = j + 1;
            }
            
            res = Math.Max(res,lengthCheck(s.Substring(left, right - left +1),k));
        }
        
        return res;
    }
    
    private int lengthCheck(string s, int k)
    {
        int[] dict= new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
        }
        
        for(int j = 0; j < dict.Length; j++)
        {
            if(dict[j] != 0 && dict[j] < k)
            {
                return 0;
            }
        }
        
        return s.Length;
    }
}

/*
abbbb && 4 -> bbbb
aaaab && 4 -> aaaa
*/
