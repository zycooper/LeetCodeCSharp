/*
Given an arbitrary ransom note string and another string containing letters from all the magazines, 
write a function that will return true if the ransom note can be constructed from the magazines; 
otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

Example 1:
Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:
Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:
Input: ransomNote = "aa", magazine = "aab"
Output: true

Constraints:
You may assume that both strings contain only lowercase letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-27 12:33
 To: 2021-04-27 12:44
 *********************************************************************************
 Submission Result:
 by self
Runtime: 104 ms, faster than 36.91% of C# online submissions for Ransom Note.
Memory Usage: 28.9 MB, less than 20.17% of C# online submissions for Ransom Note.
 *********************************************************************************
 Note: 
watch for all the corner cases!!!
ransomeNote check lenght is in front of magazine

when loop through ransomNote, dont forget to minus one for the dict every time found a match
 *********************************************************************************/
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length == 0){ return true;}
        if(magazine.Length == 0 ){ return false ;}
        
        char[] ransomNote_arr = ransomNote.ToCharArray();
        char[] magazine_arr = magazine.ToCharArray();
        Dictionary<char,int> dict = new Dictionary<char,int>();

        for(int i = 0; i < magazine_arr.Length;i++)
        {
            if(dict.ContainsKey(magazine_arr[i]))
            {
                dict[magazine_arr[i]] += 1;
            }
            else
            {
                dict.Add(magazine_arr[i],1);
            }
        }

        for(int j = 0; j < ransomNote_arr.Length; j++)
        {
            if(!dict.ContainsKey(ransomNote_arr[j]) || dict[ransomNote_arr[j]] ==0)
            {
                return false;
            }
            else
            {
                dict[ransomNote_arr[j]] -= 1;
            }
        }

        return true;
    }
}