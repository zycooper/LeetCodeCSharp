/*
Given an integer n, return true if it is a power of two. Otherwise, return false.

An integer n is a power of two, if there exists an integer x such that n == 2x.

 

Example 1:

Input: n = 1
Output: true
Explanation: 20 = 1
Example 2:

Input: n = 16
Output: true
Explanation: 24 = 16
Example 3:

Input: n = 3
Output: false
Example 4:

Input: n = 4
Output: true
Example 5:

Input: n = 5
Output: false
 

Constraints:

-231 <= n <= 231 - 1
*/

 /********************************************************************************
 Solution Category: Bit Operation
 *********************************************************************************
 Time Range:
 From: 2021-08-20 21:20
 To: 2021-0827 16:40
 *********************************************************************************
 Submission Result:
Runtime: 52 ms, faster than 13.35% of C# online submissions for Power of Two.
Memory Usage: 15.2 MB, less than 66.49% of C# online submissions for Power of Two.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public bool IsPowerOfTwo(int n) 
    {
        
        if(n < 1){ return false;}

        int count = 0;
        while(n > 0)
        {
            count += (n & 1);
            n>>=1;
        }

        return count == 1;
        
    }
    //time out!!
    public bool IsPowerOfTwo_old(int n) {
        return IsPowerOf(n,2);
    }
    private bool IsPowerOf(int n, int powerSeed)
    {
        
        if(n == 1)
        {
            return true;
        }

        int power = 1;
        while(power < n)
        {
            power *= powerSeed;

            if(power == n)
            {
                return true;
            }
        }

        return false;
        
    }
}