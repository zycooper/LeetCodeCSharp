/*

*/

 /********************************************************************************
 Solution Category: 
 Dynamic Programming || DP || Stack
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-07 15:11
 *********************************************************************************
 Submission Result:
Runtime: 104 ms, faster than 20.20% of C# online submissions for Longest Valid Parentheses.
Memory Usage: 23.7 MB, less than 56.29% of C# online submissions for Longest Valid Parentheses.
 *********************************************************************************
 Note: 

 *********************************************************************************/
 /*
    Simple code version, but slower
    Runtime: 148 ms, faster than 7.95% of C# online submissions for Longest Valid Parentheses.
    Memory Usage: 23.6 MB, less than 74.83% of C# online submissions for Longest Valid Parentheses.
 */
 public class Solution {    
    public int LongestValidParentheses(string s) 
    {
        int[] dp = new int[s.Length];
        int res = 0; 

        for(int i = 1 ; i < s.Length; i++)
        {
            if(s[i] == ')')
            {                
                if(dp[i - 1] == 0)
                {
                    dp[i] = s[i-1] == ')'? 0 :(i >= 2 ? dp[i-2] + 2: 2);
                }
                else
                {
                    if(i - dp[i-1] - 1 >= 0 && s[i - dp[i-1] - 1] == '(')
                    {
                        dp[i] = dp[i-1] + 2 +((i - dp[i-1] -2 >= 0) ?dp[i - dp[i-1] -2]:0);
                    }                   
                }
                res = Math.Max(res, dp[i]);
            }
        }
        return res;
    }
}

 public class Solution {
     //working version but lots of extra code
    public int LongestValidParentheses(string s) 
    {
        int[] dp = new int[s.Length];
        int res = 0; 

        for(int i = 1 ; i < s.Length; i++)
        {
            if(s[i] == ')')
            {
                //only set res when encounter with ")"
                if(dp[i - 1] == 0)
                {
                    if(s[i-1] == ')')
                    {
                        //before should be ...))
                        dp[i] = 0;
                    }
                    else
                    {
                        //s[i-1] =='('
                        //...()
                        //make sure i is not out of index
                        if(i>=2)
                        {
                            dp[i] = dp[i-2] + 2;
                        }
                        else
                        {
                            dp[i] = 2;
                        }
                    }
                }
                else
                {
                    //dp[i-1] > 0
                    //01234/567/)
                    //--A--/-B-/)
                    //need to check the last dot(4) in A is ( or not
                    //s[i - dp[i-1] - 1] is the last dot(4) in A
                    //B(567) is valid
                    //s[i - 1] must be ')'
                    //still need to make sure i - dp[i-1] - 1 is in index range
                    if(i - dp[i-1] - 1 >= 0 && s[i - dp[i-1] - 1] == '(')
                    {
                        dp[i] = dp[i-1] + 2 +/*check A(01234) remove last dot(4), the rest(0123) is still valid*/((i - dp[i-1] -2 >= 0) ?dp[i - dp[i-1] -2]:0);
                    }
                    else
                    {
                        dp[i] = 0;
                    }
                }
            }

            res = Math.Max(res, dp[i]);
        }

        return res;
    }
}
public class Solution {
    public int LongestValidParentheses(string s) {
     //not work on "()(()"
        int Curr_Longest = 0;   
        // 0 -> (
        // 1 -> )
        // PC -> ParentheseCount
        int[] PC =new int[2];
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ')' && PC[0] == PC[1] + 1)
            {
                //reset- calculate PC
                PC[1]++;
                Curr_Longest = Math.Max(Curr_Longest,Math.Min(PC[0],PC[1])*2);
                
                //PC[0] = 0;
                //PC[1] = 0;
            }
            else if(s[i] == ')' && PC[0] > PC[1])
            {
                PC[1]++;
            }
            else if(s[i] == '(' )
            {
                PC[0]++;
            }
            
            //Console.WriteLine(PC[0]);
            //Console.WriteLine(PC[1]);
            //Console.WriteLine("-----");
            
            
        }
        
        Curr_Longest = Math.Max(Curr_Longest,Math.Min(PC[0],PC[1])*2);
        
        //Console.ReadLine();
        
        return Curr_Longest;
    }
}
