/*
Given an integer n, return all the strobogrammatic numbers that are of length n. You may return the answer in any order.
A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).

Example 1:
Input: n = 2
Output: ["11","69","88","96"]

Example 2:
Input: n = 1
Output: ["0","1","8"]

Constraints:
1 <= n <= 14
*/

 /********************************************************************************
 Solution Category: 
 Backtracking | Recursion
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-05-17 14:14
 *********************************************************************************
 Submission Result:
Runtime: 372 ms, faster than 32.35% of C# online submissions for Strobogrammatic Number II.
Memory Usage: 50.5 MB, less than 29.41% of C# online submissions for Strobogrammatic Number II.
 *********************************************************************************
 Note: 
recursion !!!
 *********************************************************************************/
public class Solution {
    public IList<string> FindStrobogrammatic(int n) {
        Dictionary<char,char> map = new Dictionary<char,char>()
        {
            ['0'] = '0',
            ['1'] = '1',
            ['8'] = '8',
            ['6'] = '9',
            ['9'] = '6'
        };

        List<string> res = new List<string>();

        if(n%2 == 0)
        {
            //even
            helper(ref res,"",map,n);
        }
        else
        {
            //odd
            helper(ref res,"0",map,n-1);
            helper(ref res,"1",map,n-1);
            helper(ref res,"8",map,n-1);
        }

        return res;
    }

    private void helper(ref List<string> res,string cur, Dictionary<char,char> map,int remain)
    {
        if(remain == 0){ res.Add(cur); return;}

        for(int i = 0; i < map.Keys.Count(); i++)
        {
            if(remain == 2 && map.Keys.ElementAt(i) == '0'){continue;}

            helper(ref res,map.Keys.ElementAt(i) + cur + map.Values.ElementAt(i), map, remain-2);
        }
    }
}