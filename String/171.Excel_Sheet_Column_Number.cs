/*
Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...

Example 1:

Input: columnTitle = "A"
Output: 1
Example 2:

Input: columnTitle = "AB"
Output: 28
Example 3:

Input: columnTitle = "ZY"
Output: 701
Example 4:

Input: columnTitle = "FXSHRXW"
Output: 2147483647
 

Constraints:

1 <= columnTitle.length <= 7
columnTitle consists only of uppercase English letters.
columnTitle is in the range ["A", "FXSHRXW"].
*/

 /********************************************************************************
 Solution Category: 
 Mirror question: 168
 *********************************************************************************
 Time Range:
 From: 2021-04-15 15:40
 To: 2021-05-14 15:47
 *********************************************************************************
 Submission Result:
Runtime: 80 ms, faster than 34.82% of C# online submissions for Excel Sheet Column Number.
Memory Usage: 25.6 MB, less than 33.77% of C# online submissions for Excel Sheet Column Number.
 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res = 0;

        for(int i = 0; i < columnTitle.Length; i++)
        {
            res = res * 26 + columnTitle[i] - 'A' + 1;
        }

        return res;
    }
}