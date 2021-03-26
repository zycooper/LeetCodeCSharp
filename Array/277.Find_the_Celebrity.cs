/*
Suppose you are at a party with n people (labeled from 0 to n - 1), and among them, there may exist one celebrity. The definition of a celebrity is that all the other n - 1 people know him/her, but he/she does not know any of them.

Now you want to find out who the celebrity is or verify that there is not one. The only thing you are allowed to do is to ask questions like: "Hi, A. Do you know B?" to get information about whether A knows B. You need to find out the celebrity (or verify there is not one) by asking as few questions as possible (in the asymptotic sense).

You are given a helper function bool knows(a, b) which tells you whether A knows B. Implement a function int findCelebrity(n). There will be exactly one celebrity if he/she is in the party. Return the celebrity's label if there is a celebrity in the party. If there is no celebrity, return -1.

Example 1:

Input: graph = [[1,1,0],[0,1,0],[1,1,1]]
Output: 1
Explanation: There are three persons labeled with 0, 1 and 2. graph[i][j] = 1 means person i knows person j, otherwise graph[i][j] = 0 means person i does not know person j. The celebrity is the person labeled as 1 because both 0 and 2 know him but 1 does not know anybody.

Example 2:
Input: graph = [[1,0,1],[1,1,0],[0,1,1]]
Output: -1
Explanation: There is no celebrity.
 

Constraints:

n == graph.length
n == graph[i].length
2 <= n <= 100
graph[i][j] is 0 or 1.
graph[i][i] == 1
*/
/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

/*
two pass:

first pass: use API knows to loop through the array, every time we can make sure one param is not a celebrity candidate:
Knows(i,j) == true => i know j so i can't be celebrity
Knows(i,j) == false => k doesn't know j, so j cannot be celebrity
since the celebrity doesn't know anybody and everybody else know him/her, so after the first pass, there will only be one candidate

second pass: since we loop through once, but everytime we only ask one way: if the candidate knows i or if the i knows candidate, so we have to loop through the array again to make sure the final result.

*/
public class Solution : Relation {
    public int FindCelebrity(int n) {
        /*
        Runtime: 200 ms, faster than 64.86% of C# online submissions for Find the Celebrity.
        Memory Usage: 29.6 MB, less than 34.29% of C# online submissions for Find the Celebrity.
        */
        //two pass

        int candidate_idx = 0;
        //first pass
        for(int i = 1; i < n; i++)
        {
            if(Knows(candidate_idx,i))
            {
                candidate_idx = i;
            }
        }

        //second pass
        for(int i = 0; i < n; i++)
        {
            if(i != candidate_idx)
            {
                if(!Knows(i,candidate_idx) || Knows(candidate_idx,i))
                {
                    return -1;
                }
            }
        }

        return candidate_idx;
    }
}