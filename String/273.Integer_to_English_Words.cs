/*
Convert a non-negative integer num to its English words representation.

Example 1:
Input: num = 123
Output: "One Hundred Twenty Three"

Example 2:
Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"

Example 3:
Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"

Example 4:
Input: num = 1234567891
Output: "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"

Constraints:
0 <= num <= 2`31 - 1
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-27 09:34
 To: 2021-06-02 10:28
 *********************************************************************************
 Submission Result:
Runtime: 120 ms, faster than 8.66% of C# online submissions for Integer to English Words.
Memory Usage: 24 MB, less than 95.05% of C# online submissions for Integer to English Words.
 *********************************************************************************
 Note: 
this question is not hard, it's just annoying
 *********************************************************************************/
  public class Solution
    {
      //working version, but slow
        public string NumberToWords(int num)
        {
            if(num == 0) { return "Zero"; }
            int billion = num / 1000000000;
            int million = (num - billion * 1000000000) / 1000000;
            int thousand = (num - billion * 1000000000 - million * 1000000) / 1000;
            int res = num - billion * 1000000000 - million * 1000000 - thousand * 1000;

            string res_str = "";

            if (billion != 0)
            {
                res_str += ThreeDigit(billion) + " Billion";
            }

            if (million != 0)
            {
                res_str += (string.IsNullOrEmpty(res_str) ? "" : " ") + ThreeDigit(million) + " Million";
            }

            if (thousand != 0)
            {
                res_str += (string.IsNullOrEmpty(res_str) ? "" : " ") + ThreeDigit(thousand) + " Thousand";
            }

            if (res != 0)
            {
                res_str += (string.IsNullOrEmpty(res_str) ? "" : " ") + ThreeDigit(res);
            }

            return res_str;
        }

        private string OneDigit(int num)
        {
            switch (num)
            {
                case 1: return "One"; break;
                case 2: return "Two"; break;
                case 3: return "Three"; break;
                case 4: return "Four"; break;
                case 5: return "Five"; break;
                case 6: return "Six"; break;
                case 7: return "Seven"; break;
                case 8: return "Eight"; break;
                case 9: return "Nine"; break;
                default: return "";
            }
        }
        private string TwoDigit(int num)
        {
            if (num < 10)
            {
                return OneDigit(num);
            }
            else if (num < 20)
            {
                switch (num)
                {
                    case 10: return "Ten"; break;
                    case 11: return "Eleven"; break;
                    case 12: return "Twelve"; break;
                    case 13: return "Thirteen"; break;
                    case 14: return "Fourteen"; break;
                    case 15: return "Fifteen"; break;
                    case 16: return "Sixteen"; break;
                    case 17: return "Seventeen"; break;
                    case 18: return "Eighteen"; break;
                    case 19: return "Nineteen"; break;
                    default: return "";
                }
            }
            else
            {
                return TwoDigitAbovetweteen(num);
            }
        }
        private string TwoDigitAbovetweteen(int num)
        {
            int ten = num / 10;
            int one = num - ten * 10;

            string res_ten = "";

            switch (ten)
            {
                case 2: res_ten = "Twenty"; break;
                case 3: res_ten = "Thirty"; break;
                case 4: res_ten = "Forty"; break;
                case 5: res_ten = "Fifty"; break;
                case 6: res_ten = "Sixty"; break;
                case 7: res_ten = "Seventy"; break;
                case 8: res_ten = "Eighty"; break;
                case 9: res_ten = "Ninety"; break;
            }

            return (one == 0) ? res_ten : res_ten + " " + OneDigit(one);
        }
        private string ThreeDigit(int num)
        {
            int hundred = num / 100;
            int ten = num - hundred * 100;

            //100
            if (hundred != 0 && ten == 0) 
            {
                return OneDigit(hundred) + " Hundred";
            }
            //10
            else if (hundred == 0 && ten != 0) 
            {
                return TwoDigit(ten);
            }
            //123
            else 
            {
                return OneDigit(hundred) + " Hundred " + TwoDigit(ten);
            }            
        }
    }
public class Solution {
    public string NumberToWords(int num) {
        
    }

    private string ThreeDigit(int str_threedigit)
    {
        //str has a max length of 3

    }
    private string TwoDigit(int str_twodigit)
    {
        //str has a fix length of 2
        //if(str_twodigit[0]){}
    }
    private string OneDigit(int c)
    {
        switch(c)
        {
            case 1:
                return "";
                break;
            case 2:
                return "";
                break;
            case 3:
                return "";
                break;
            case 4:
                return "";
                break;
            case 5:
                return "";
                break;
            case 6:
                return "";
                break;
        }
    }
}

class Solution {
  public String one(int num) {
    switch(num) {
      case 1: return "One";
      case 2: return "Two";
      case 3: return "Three";
      case 4: return "Four";
      case 5: return "Five";
      case 6: return "Six";
      case 7: return "Seven";
      case 8: return "Eight";
      case 9: return "Nine";
    }
    return "";
  }

  public String twoLessThan20(int num) {
    switch(num) {
      case 10: return "Ten";
      case 11: return "Eleven";
      case 12: return "Twelve";
      case 13: return "Thirteen";
      case 14: return "Fourteen";
      case 15: return "Fifteen";
      case 16: return "Sixteen";
      case 17: return "Seventeen";
      case 18: return "Eighteen";
      case 19: return "Nineteen";
    }
    return "";
  }

  public String ten(int num) {
    switch(num) {
      case 2: return "Twenty";
      case 3: return "Thirty";
      case 4: return "Forty";
      case 5: return "Fifty";
      case 6: return "Sixty";
      case 7: return "Seventy";
      case 8: return "Eighty";
      case 9: return "Ninety";
    }
    return "";
  }

  public String two(int num) {
    if (num == 0)
      return "";
    else if (num < 10)
      return one(num);
    else if (num < 20)
      return twoLessThan20(num);
    else {
      int tenner = num / 10;
      int rest = num - tenner * 10;
      if (rest != 0)
        return ten(tenner) + " " + one(rest);
      else
        return ten(tenner);
    }
  }

  public String three(int num) {
    int hundred = num / 100;
    int rest = num - hundred * 100;
    String res = "";
    if (hundred*rest != 0)
      res = one(hundred) + " Hundred " + two(rest);
    else if ((hundred == 0) && (rest != 0))
      res = two(rest);
    else if ((hundred != 0) && (rest == 0))
      res = one(hundred) + " Hundred";
    return res;
  }

  public String numberToWords(int num) {
    if (num == 0)
      return "Zero";

    int billion = num / 1000000000;
    int million = (num - billion * 1000000000) / 1000000;
    int thousand = (num - billion * 1000000000 - million * 1000000) / 1000;
    int rest = num - billion * 1000000000 - million * 1000000 - thousand * 1000;

    String result = "";
    if (billion != 0)
      result = three(billion) + " Billion";
    if (million != 0) {
      if (! result.isEmpty())
        result += " ";
      result += three(million) + " Million";
    }
    if (thousand != 0) {
      if (! result.isEmpty())
        result += " ";
      result += three(thousand) + " Thousand";
    }
    if (rest != 0) {
      if (! result.isEmpty())
        result += " ";
      result += three(rest);
    }
    return result;
  }
}