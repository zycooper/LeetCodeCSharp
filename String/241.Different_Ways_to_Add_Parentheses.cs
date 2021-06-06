/*

*/

 /********************************************************************************
 Solution Category: 
 Recursion
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-06 15:45
 *********************************************************************************
 Submission Result:
Runtime: 268 ms, faster than 8.64% of C# online submissions for Different Ways to Add Parentheses.
Memory Usage: 31.8 MB, less than 72.84% of C# online submissions for Different Ways to Add Parentheses.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        List<int> res = new List<int>();
        
        for(int i = 0; i < expression.Length; i++)
        {
            if(expression[i] == '+' || expression[i] == '-' || expression[i] == '*')
            {
                var left = DiffWaysToCompute(expression.Substring(0,i));
                var right = DiffWaysToCompute(expression.Substring(i+1));
                
                for(int j = 0 ; j < left.Count; j++)
                {
                    for(int k =0; k < right.Count; k++)
                    {
                        int temp_value = 0;
                        
                        switch(expression[i])
                        {
                            case '+':
                                temp_value = left[j] + right[k];
                                break;
                            case '-':
                                temp_value = left[j] - right[k];                                
                                break; 
                            case '*':
                                temp_value = left[j] * right[k];                                
                                break;
                            default:
                                break;
                        }

                        res.Add(temp_value);            
                    }
                }
            }
        }
        
        if(res.Count == 0){ res.Add(int.Parse(expression));}
        return res;
    }
}
