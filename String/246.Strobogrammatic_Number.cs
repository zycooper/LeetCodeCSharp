/*
Given a string num which represents an integer, return true if num is a strobogrammatic number.
A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).

Example 1:
Input: num = "69"
Output: true

Example 2:
Input: num = "88"
Output: true

Example 3:
Input: num = "962"
Output: false

Example 4:
Input: num = "1"
Output: true

Constraints:

1 <= num.length <= 50
num consists of only digits.
num does not contain any leading zeros except for zero itself.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-17 10:07
 To: 2021-05-17 10:47
 *********************************************************************************
 Submission Result:
Runtime: 68 ms, faster than 90.64% of C# online submissions for Strobogrammatic Number.
Memory Usage: 22.1 MB, less than 95.91% of C# online submissions for Strobogrammatic Number.
 *********************************************************************************
 Note: 
sometime if you list all the possibilities, it will run faster...
 *********************************************************************************/
public class Solution {
    public bool IsStrobogrammatic_second(string num) {

        if(string.IsNullOrEmpty(num)){ return false;}

        Dictionary<char,char> dict = new Dictionary<char, char>()
        {
            ['0'] = '0',
            ['1'] = '1',
            ['8'] = '8',
            ['6'] = '9',
            ['9'] = '6'
        };

        int left = 0;
        int right = num.Length - 1;

        while(left <= right)
        {
            if(dict.ContainsKey(num[left]) && dict[num[left]] != num[right])
            {
                return false;
            }
            else if(dict.ContainsKey(num[right]) && dict[num[right]] != num[left])
            {
                return false;
            }
            else if(!dict.ContainsKey(num[right]) || !dict.ContainsKey(num[left]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;   
    }
    public bool IsStrobogrammatic_second(string num) {
        //too many edge case
        List<char> self = new List<char>(){'0','1','8'};
        
        KeyValuePair<char,char> pair = new KeyValuePair<char,char>(key:'6',value:'9');
        List<char> pair_list = new List<char>(){'6','9'};

        int left = 0; 
        int right = num.Length - 1;
        while(left <= right)
        {
            if(num[left] == pair.Key && num[right] != pair.Value)
            {
                return false;
            }
            else if(num[left] != pair.Key && num[right] == pair.Value)
            {
                return false;
            }
            else if(num[left] != num[right] || !self.Contains(num[left]) && !pair_list.Contains(num[left]) && !pair_list.Contains(num[right]))
            {
                return false;
            }
             

            left++;
            right--;
        }

        return true;
    }
    public bool IsStrobogrammatic(string num) {
        //below is wrong,because it rotates 180, not mirror upside down
        //self 0 1 3 8
        //pair 6-9
        if(string.IsNullOrEmpty(num)){ return false;}

        List<char> self = new List<char>(){'0','1','8'};
        List<char> pair_list = new List<char>(){'6','9'};
        KeyValuePair<char,char> pair = new KeyValuePair<char,char>(key:'6',value:'9');

        int left = 0;
        int right = num.Length - 1;

        while(left <= right)
        {
            if(num[left] == pair.Key && num[right] != pair.Value)
            {
                return false;
            }
            else if(num[left] != pair.Key && num[right] == pair.Value)
            {
                return false;
            }
            else if((!self.Contains(num[left]) || !self.Contains(num[right])) && !pair_list.Contains(num[left]) && !pair_list.Contains(num[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    
}