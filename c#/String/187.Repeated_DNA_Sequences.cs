/*
The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.

For example, "ACGAATTCCG" is a DNA sequence.
When studying DNA, it is useful to identify repeated sequences within the DNA.

Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule. You may return the answer in any order.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-27 09:10
 To: 2021-05-27 09:25
 *********************************************************************************
 Submission Result:
Runtime: 272 ms, faster than 66.32% of C# online submissions for Repeated DNA Sequences.
Memory Usage: 45.1 MB, less than 16.32% of C# online submissions for Repeated DNA Sequences.
 *********************************************************************************
 Note: 
need to memorize AsEnumerable();

for for-loop the restriction condition should be s.Length - 9 instead of s.Length - 10
the first time submission failed because of this
 *********************************************************************************/
public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        //pre condition
        if(s.Length <= 10){return new List<string>();}
        
        //normal condition
        Dictionary<string,int> dict = new Dictionary<string,int>();
        
        for(int i = 0; i < s.Length - 9; i++)
        {
            string current_sub = s.Substring(i,10);
            
            if(dict.Keys.Contains(current_sub))
            {
                dict[current_sub]++;
            }
            else
            {
                dict[current_sub] = 1;
            }
        }
        
        return dict.AsEnumerable().Where(x => x.Value > 1).Select(x => x.Key).ToList();
    }
}