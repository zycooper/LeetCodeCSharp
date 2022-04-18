/*
Given an array of strings wordsDict and two strings that already exist in the array word1 and word2, return the shortest distance between these two words in the list.

Note that word1 and word2 may be the same. It is guaranteed that they represent two individual words in the list.

Example 1:
Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"], word1 = "makes", word2 = "coding"
Output: 1

Example 2:
Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"], word1 = "makes", word2 = "makes"
Output: 3

Constraints:

1 <= wordsDict.length <= 3 * 104
1 <= wordsDict[i].length <= 10
wordsDict[i] consists of lowercase English letters.
word1 and word2 are in wordsDict.
*/
/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 
*********************************************************************************
Submission Result:

*********************************************************************************
Note: 

*********************************************************************************/
public class Solution {
    public int ShortestWordDistance(string[] wordsDict, string word1, string word2) {
        Dictionary<string, List<int>> _dict = new Dictionary<string, List<int>>();

        //fill up dic
        for(int i =0; i < wordsDict.Length; i++)
        {
            if(_dict.ContainsKey(wordsDict[i]))
            {
                _dict[wordsDict[i]].Add(i);
            }
            else
            {
                _dict[wordsDict[i]]= new List<int>(){i};
            }
        }

        int result = int.MaxValue;
        int index_1 = 0;
        int index_2 = 0;

        List<int> list_1 = _dict[word1];
        List<int> list_2 = _dict[word2];

        if(word1 == word2)
        {
            for(int i = 0; i < list_1.Count()-1;i++)
            {
                int temp_result = Math.Abs(list_1[i] - list_1[i+1]);

                result = Math.Min(temp_result,result);
            }
        }
        else
        {
            while(index_1 < list_1.Count() && index_2 < list_2.Count())
            {
                int temp_result = Math.Abs(list_1[index_1]-list_2[index_2]);

                result = Math.Min(temp_result,result);

                if(result ==1)
                {
                    break;
                }

                if(list_1[index_1] < list_2[index_2])
                {
                    index_1++;
                }
                else
                {
                    index_2++;
                }
            }
        }
    
        return result;
    }
}