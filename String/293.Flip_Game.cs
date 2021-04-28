/*
You are playing a Flip Game with your friend.
You are given a string currentState that contains only '+' and '-'. 
You and your friend take turns to flip two consecutive "++" into "--". 
The game ends when a person can no longer make a move, and therefore the other person will be the winner.
Return all possible states of the string currentState after one valid move. 
You may return the answer in any order. If there is no valid move, return an empty list [].

Example 1:
Input: currentState = "++++"
Output: ["--++","+--+","++--"]

Example 2:
Input: currentState = "+"
Output: []

Constraints:
1 <= currentState.length <= 500
currentState[i] is either '+' or '-'.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-28 09:20
 To: 2021-04-28 09:23
 *********************************************************************************
 Submission Result:
    Runtime: 236 ms, faster than 50.00% of C# online submissions for Flip Game.
    Memory Usage: 32.6 MB, less than 50.00% of C# online submissions for Flip Game.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public IList<string> GeneratePossibleNextMoves(string currentState) {
        List<string> result = new List<string>();

        if(currentState.Length < 2){ return new List<string>();}
        
        for(int i = 1; i < currentState.Length;i++)
        {
            if(currentState.Substring(i,1) == "+" && currentState.Substring(i-1,1) == "+")
            {
                StringBuilder sb = new StringBuilder(currentState);

                sb[i] = '-';
                sb[i - 1] = '-';

                result.Add(sb.ToString());
            }
        }

        return result;
    }
}