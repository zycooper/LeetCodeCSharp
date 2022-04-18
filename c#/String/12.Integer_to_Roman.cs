/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.

 

Example 1:

Input: num = 3
Output: "III"
Example 2:

Input: num = 4
Output: "IV"
Example 3:

Input: num = 9
Output: "IX"
Example 4:

Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Example 5:

Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= num <= 3999
*/

 /********************************************************************************
 Solution Category: 
 Mirror Question : 13
 *********************************************************************************
 Time Range:
 From: 2021-05-16 15:30
 To: 2021-05-16 15:51
 *********************************************************************************
 Submission Result:
Runtime: 116 ms, faster than 5.80% of C# online submissions for Integer to Roman.
Memory Usage: 27 MB, less than 57.71% of C# online submissions for Integer to Roman.
 *********************************************************************************
 Note: 
keep minus the largest number in dict which is less than the target number and append the corresponding string
 *********************************************************************************/
public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int,string> _dict = new Dictionary<int,string>()
        {
          [1000] = "M",
          [900] = "CM",
          [500] = "D",
          [400] = "CD",
          [100] = "C",
          [90] = "XC",
          [50] = "L",
          [40] = "XL",
          [10] = "X",
          [9] = "IX",
          [5] = "V",
          [4] = "IV",
          [1] = "I"
        };
         
        StringBuilder sb = new StringBuilder();
            
         for(int i = 0; i < _dict.Count && num > 0; i++)
         {
             //below is  <= not <, if < will miss the seniro
             while(_dict.Keys.ElementAt(i) <= num)
             {
                 num -= _dict.Keys.ElementAt(i);
                 sb.Append(_dict.Values.ElementAt(i));
             }
         }
        
        return sb.ToString();
    }
}
