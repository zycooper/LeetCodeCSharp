/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
(you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:
string convert(string s, int numRows);
 
Example 1:
Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:
Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:
Input: s = "A", numRows = 1
Output: "A"

Constraints:
1 <= s.length <= 1000
s consists of English letters (lower-case and upper-case), ',' and '.'.
1 <= numRows <= 1000
*/
/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 2021-04-30
*********************************************************************************
Submission Result:
Runtime: 100 ms, faster than 60.49% of C# online submissions for ZigZag Conversion.
Memory Usage: 27 MB, less than 68.73% of C# online submissions for ZigZag Conversion.
*********************************************************************************
Note: 

*********************************************************************************/
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;

        StringBuilder sb = new StringBuilder();
        int n = s.Length;
        int cycleLen = 2 * numRows - 2;

        for (int i = 0; i < numRows; i++) {
            for (int j = 0; j + i < n; j += cycleLen) {
                sb.Append(s[j + i]);
                if (i != 0 && i != numRows - 1 && j + cycleLen - i < n)
                    sb.Append(s[j + cycleLen - i]);
            }
        }
        return sb.ToString();
    }
}