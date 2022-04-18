/*
Given an array of words and a width maxWidth, 
format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.
You should pack your words in a greedy approach; that is, pack as many words as you can in each line. 
Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.
Extra spaces between words should be distributed as evenly as possible. 
If the number of spaces on a line do not divide evenly between words, 
the empty slots on the left will be assigned more spaces than the slots on the right.
For the last line of text, it should be left justified and no extra space is inserted between words.

Note:
A word is defined as a character sequence consisting of non-space characters only.
Each word's length is guaranteed to be greater than 0 and not exceed maxWidth.
The input array words contains at least one word.

Example 1:
Input: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
Output:
[
   "This    is    an",
   "example  of text",
   "justification.  "
]

Example 2:
Input: words = ["What","must","be","acknowledgment","shall","be"], maxWidth = 16
Output:
[
  "What   must   be",
  "acknowledgment  ",
  "shall be        "
]
Explanation: Note that the last line is "shall be    " instead of "shall     be", because the last line must be left-justified instead of fully-justified.
Note that the second line is also left-justified becase it contains only one word.

Example 3:
Input: words = ["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], maxWidth = 20
Output:
[
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "
]

Constraints:
1 <= words.length <= 300
1 <= words[i].length <= 20
words[i] consists of only English letters and symbols.
1 <= maxWidth <= 100
words[i].length <= maxWidth
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-18 14:15
 To: 2021-05-18 16:48
 *********************************************************************************
 Submission Result:
Runtime: 252 ms, faster than 14.83% of C# online submissions for Text Justification.
Memory Usage: 31.6 MB, less than 11.86% of C# online submissions for Text Justification.
 *********************************************************************************
 Note: 
I used brutal force to solve this, well, it takes me 2 and half hours...and it's slow
learned: for and while loop combined
 *********************************************************************************/
public class Solution
    {
        //solve all by myself
        public IList<string> FullJustify(string[] words, int maxWidth)
        {

            List<string> res = new List<string>();

            for (int i = 0; i < words.Length;)
            {
                int currentLen = 0;
                List<string> temp_list = new List<string>();

                int a = (currentLen + (words[i].Length + ((currentLen == 0) ? 0 : 1)));
                while (i < words.Length && (currentLen + (words[i].Length + ((currentLen == 0) ? 0 : 1))) <= maxWidth)
                {
                    int b = (currentLen + (words[i].Length + ((currentLen == 0) ? 0 : 1)));

                    temp_list.Add(words[i]);
                    currentLen += words[i].Length + ((currentLen == 0) ? 0 : 1);
                    i++;
                }
               // i--;

                res.Add(segmentStr(temp_list, maxWidth, currentLen, i == words.Length));
            }

            return res;
        }
        private string segmentStr(List<string> words, int maxWidth, int len, bool lastline = false)
        {
            //len include space for each word after the first one
            StringBuilder sb = new StringBuilder();

            if (words.Count() == 1)
            {
                //last line
                sb.Append(words[0] + space(maxWidth - words[0].Length));
            } 
            else if (lastline) 
            {               
                for(int i = 0; i < words.Count(); i++) 
                {
                    sb.Append(space((i == 0)?0:1) + words[i]);
                }

                sb.Append(space(maxWidth - len));
            }
            else
            {
                //normal line
                int left = (maxWidth - len) % (words.Count() - 1);
                int ttl = (maxWidth - len + (words.Count() - 1)) / (words.Count() - 1);

                for (int i = 0; i < words.Count(); i++)
                {
                    int spacecount = (i == 0) ? 0 : ttl + ((i <= left) ? 1 : 0);
                    sb.Append(space(spacecount) + words[i]);
                }
            }

            return sb.ToString();
        }
        private string space(int Count)
        {
            string res = "";

            for (int i = 0; i < Count; i++)
            {
                res += ' ';
            }

            return res;
        }
    }