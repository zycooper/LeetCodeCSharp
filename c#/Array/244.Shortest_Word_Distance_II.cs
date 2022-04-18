/*
Design a data structure that will be initialized with a string array, and then it should answer queries of the shortest distance between two different strings from the array.

Implement the WordDistance class:

WordDistance(String[] wordsDict) initializes the object with the strings array wordsDict.
int shortest(String word1, String word2) returns the shortest distance between word1 and word2 in the array wordsDict.
 
Example 1:

Input
["WordDistance", "shortest", "shortest"]
[[["practice", "makes", "perfect", "coding", "makes"]], ["coding", "practice"], ["makes", "coding"]]
Output
[null, 3, 1]

Explanation
WordDistance wordDistance = new WordDistance(["practice", "makes", "perfect", "coding", "makes"]);
wordDistance.shortest("coding", "practice"); // return 3
wordDistance.shortest("makes", "coding");    // return 1
 

Constraints:

1 <= wordsDict.length <= 3 * 104
1 <= wordsDict[i].length <= 10
wordsDict[i] consists of lowercase English letters.
word1 and word2 are in wordsDict.
word1 != word2
At most 5000 calls will be made to shortest.
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
public class WordDistance_0 {
    //Time Limit Exceeded
    private List<string> WordsDict = new List<string>();
    public WordDistance(string[] wordsDict) {
        WordsDict = wordsDict.ToList();
    }
    
    public int Shortest(string word1, string word2) {
        int[] list = WordsDict.ToArray();
        int index_1 = -1;
        int index_2 = -1;
        int result = list.Length;
        //loop through

        for(int i =0; i < list.Length;i++)
        {
            if(list[i] == word1)
            {
                index_1 = i ;
            }
            else if(list[i] == word2)
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

public class WordDistance_1{
    //very simple one and 1st submit
     private Dictionary<string, List<int>> _dict;
        public WordDistance(string[] words)
        {
            _dict = new Dictionary<string, List<int>>();

            for (var i = 0; i < words.Length; i++)
            {
                if (!_dict.ContainsKey(words[i]))
                    _dict[words[i]] = new List<int> { i };
                else
                    _dict[words[i]].Add(i);
            }
        }

        public int Shortest(string word1, string word2)
        {         
            int result = _dict[word1].Min(w1 =>_dict[word2].Min(w2 =>Math.Abs(w1 - w2)));

            return result;
        }
}

public class WordDistance_1{
    Dictionary<string,List<int>> _dict = new Dictionary<string, List<int>>();
    public WordDistance(string[] words)
    {
        for(int i=0; i < words.Length;i++)
        {
            if(_dict.ContainsKey(words[i]))
            {
                _dict[words[i]].Add(i);
            }else
            {
                _dict[words[i]] = new List<int>(){i};
            }
        }
    }
    public int Shortest(string word1, string word2)
    {
        List<int> list_1 = _dict[word1];
        List<int> list_2 = _dict[word2];

        int index_1 = 0;
        int index_2 = 0;

        int result = int.MaxValue;

        while(index_1 < list_1.Count() && index_2 < list_2.Count())
        {
            int temp_result = Math.Abs(list_1[index_1] - list_2[index_2]);

            result = Math.Min(temp_result,result);
            
            if(result ==1){
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

        return result;
    }
}
/**
 * Your WordDistance object will be instantiated and called as such:
 * WordDistance obj = new WordDistance(wordsDict);
 * int param_1 = obj.Shortest(word1,word2);
 */