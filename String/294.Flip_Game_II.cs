/*
You are playing a Flip Game with your friend.
You are given a string currentState that contains only '+' and '-'. 
You and your friend take turns to flip two consecutive "++" into "--". 
The game ends when a person can no longer make a move, and therefore the other person will be the winner.
Return true if the starting player can guarantee a win, and false otherwise.

Example 1:
Input: currentState = "++++"
Output: true
Explanation: The starting player can guarantee a win by flipping the middle "++" to become "+--+".

Example 2:
Input: currentState = "+"
Output: false

Constraints:
1 <= currentState.length <= 60
currentState[i] is either '+' or '-'.
*/

 /********************************************************************************
 Solution Category: 
 | BackTracking |
 *********************************************************************************
 Time Range:
 From: 2021-04-28 09:25
 To: 2021-04-28 10:29
 *********************************************************************************
 Submission Result:
Runtime: 884 ms, faster than 20.00% of C# online submissions for Flip Game II.
Memory Usage: 26.6 MB, less than 20.00% of C# online submissions for Flip Game II.
 *********************************************************************************
 Note: 
need to understand what does the recursion does
https://www.cnblogs.com/grandyang/p/5226206.html
 *********************************************************************************/
public class Solution {
    
    public bool CanWin(string currentState) {
        //the target is wrong, player won't take one by one ++ to --
        if(currentState.Length < 2){ return false; }
        
        for(int i = 1; i < currentState.Length; i++)
        {
            if(
                currentState.Substring(i,1) == "+" 
                && currentState.Substring(i-1,1) == "+" 
                && !CanWin(currentState.Substring(0,i-1) + "--" + currentState.Substring(i+1))
                )
            {
               return true;
            }
        }
        
        return false;
    }
}