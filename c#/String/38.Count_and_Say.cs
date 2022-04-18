/*
The count-and-say sequence is a sequence of digit strings defined by the recursive formula:

countAndSay(1) = "1"
countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1), which is then converted into a different digit string.
To determine how you "say" a digit string, split it into the minimal number of groups so that each group is a contiguous section all of the same character. 
Then for each group, say the number of characters, then say the character. 
To convert the saying into a digit string, replace the counts with a number and concatenate every saying.

Given a positive integer n, return the nth term of the count-and-say sequence.

Example 1:
Input: n = 1
Output: "1"
Explanation: This is the base case.

Example 2:
Input: n = 4
Output: "1211"
Explanation:
countAndSay(1) = "1"
countAndSay(2) = say "1" = one 1 = "11"
countAndSay(3) = say "11" = two 1's = "21"

1:1
2:11
3:21
4:1211
5:111221
6:312211
7:13112221
8:1112213211

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-12 10:10
 To: 2021-05-12 15:17
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 29.52% of C# online submissions for Count and Say.
Memory Usage: 29.2 MB, less than 40.16% of C# online submissions for Count and Say.
 *********************************************************************************
 Note: 
    jezz...need to understand what does it mean. takes me long time to understand what exactly what does it mean
 *********************************************************************************/
public class Solution {
    public string CountAndSay(int n) {
        if(n == 1){ return "1";}

        string cur = "1";

        for(int j = 1; j < n; j++)
        {                        
            int count = 1;
            string temp_result ="";

            for(int i = 1; i < cur.Length; i++)
            {
                if(cur[i] == cur[i-1])
                {
                    count++;
                }
                else
                {
                    temp_result += count.ToString() + cur[i - 1];
                    count = 1;
                }
            }
            //be carefull with the line below, when the loop ends, the count is for the last digit count
            temp_result += count.ToString() + cur[cur.Length - 1];
            cur = temp_result;
        }

        return cur;
    }   
}