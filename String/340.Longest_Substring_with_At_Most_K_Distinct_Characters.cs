/*

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-19 14:40 
 To: 
 *********************************************************************************
 Submission Result:

 *********************************************************************************
 Note: 

 *********************************************************************************/
public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        //aba - a doesn't work
        if(string.IsNullOrEmpty(s)){ return 0;}
        if(k ==0){ return 0;}       

        Dictionary<char,int> dict = new Dictionary<char,int>();
        int left = 0;
        int res = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(dict.Count() == k && !dict.Keys.Contains(s[right]))
            {
                //need to remove some char from dict and move left
                for(int i = left; i < right; i++)
                {
                    if(dict[s[i]] == i)
                    {
                        left = i + 1;
                        dict.Remove(s[i]);
                        break;
                    }
                }
            }
            // else if(dict.Count() < k && !dict.Keys.Contains(s[right]))
            // {
            //     //add key-value
            //     dict[s[right]] = right;
            // }
            else
            {
                //already contains key, just update the position
                dict[s[right]] = right;
            }

            res = Math.Max(res, right - left + 1);
        }

        return res;
    }
}