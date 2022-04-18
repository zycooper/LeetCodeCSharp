/*
Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

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
Input: columnNumber = 1
Output: "A"

Example 2:
Input: columnNumber = 28
Output: "AB"

Example 3:
Input: columnNumber = 701
Output: "ZY"

Example 4:
Input: columnNumber = 2147483647
Output: "FXSHRXW"

Constraints:
1 <= columnNumber <= 231 - 1
*/

 /********************************************************************************
 Solution Category: 0
 Mirror question: 171

 *********************************************************************************
 Time Range:
 From: 2021-05-14 15:23
 To: 2021-05-14 15:38
 *********************************************************************************
 Submission Result:
Runtime: 80 ms, faster than 53.68% of C# online submissions for Excel Sheet Column Title.
Memory Usage: 23 MB, less than 57.14% of C# online submissions for Excel Sheet Column Title.
 *********************************************************************************
 Note: 
inital is 1 instead of 0 in Excel

Jacob in YTB
 *********************************************************************************/
public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();

        while(columnNumber > 0)
        {
            columnNumber--;
            sb.Append((char)('A' + columnNumber%26));
            columnNumber /= 26;
        }
        
        return new string(sb.ToString().Reverse().ToArray());
    }
}