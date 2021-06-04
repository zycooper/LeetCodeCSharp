/*

*/

 /********************************************************************************
 Solution Category: 
 Backtracking || Recursion
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-04 12:15
 *********************************************************************************
 Submission Result:
Runtime: 480 ms, faster than 5.21% of C# online submissions for Generate Parentheses.
Memory Usage: 33.5 MB, less than 75.20% of C# online submissions for Generate Parentheses.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public IList<string> GenerateParenthesis(int n) 
    {
        if(n <= 0){ return new string[0];}
        
        List<string> res = new List<string>();

        AddParenthesis(n,n,res,"");
            
        return res.ToArray();
    }
    
    private void AddParenthesis(int leftSide_left, int rightSide_left,List<string> res,string cur_str)
    {
        if(rightSide_left < leftSide_left)
        {
            return;
        }
        
        if(rightSide_left == 0 && leftSide_left == 0)
        {
            res.Add(cur_str);
        }
        
        if(leftSide_left > 0 )
        {
            AddParenthesis(leftSide_left-1,rightSide_left,res,cur_str + "(");
        }
        
        if(rightSide_left > 0 )
        {
            AddParenthesis(leftSide_left,rightSide_left-1,res,cur_str + ")");
        }
    }
}