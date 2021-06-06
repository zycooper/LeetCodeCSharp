/*

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
