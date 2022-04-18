/*
Given an array of strings wordsDict and two different strings that already exist in the array word1 and word2, return the shortest distance between these two words in the list.

Example 1:
Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"], word1 = "coding", word2 = "practice"
Output: 3

Example 2:
Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"], word1 = "makes", word2 = "coding"
Output: 1
 
Constraints:

1 <= wordsDict.length <= 3 * 104
1 <= wordsDict[i].length <= 10
wordsDict[i] consists of lowercase English letters.
word1 and word2 are in wordsDict.
word1 != word2
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
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        /*
        Note:

        result initial should be wordsDict.Length
        Math.Min and Math Abs
        Abs only take on value which is one index minus another
        */
        //add two index and result
        int index_1 = -1;
        int index_2 = -1;
        int result = wordsDict.Length;
        //loop through

        for(int i =0; i < wordsDict.Length;i++)
        {
            if(wordsDict[i] == word1)
            {
                index_1 = i ;
            }
            else if(wordsDict[i] == word2)
            {
                index_2 = i;
            }

            if(index_1 != -1 && index_2 != -1)
            {
                result = Math.Min(result,Math.Abs(index_1-index_2));
            }
        }

        return result;
    }
}