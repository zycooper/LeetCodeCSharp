/*

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-05-19 14:40 
 To: 2021-05-21 15:11
 *********************************************************************************
 Submission Result:
Runtime: 68 ms, faster than 98.85% of C# online submissions for Longest Substring with At Most K Distinct Characters.
Memory Usage: 23.6 MB, less than 54.02% of C# online submissions for Longest Substring with At Most K Distinct Characters.
 *********************************************************************************
 Note: 
well, this is wrote all by myself without any help
but submit several times to include all the edge case tho
 *********************************************************************************/
public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        if(string.IsNullOrEmpty(s)){ return 0;}
        if(k == 0){ return 0;}

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
                        //this line below cause issue, at first there is no this line, so every time my dict actually missing the current(right) char
                        dict[s[right]] = right;

                        break;
                    }
                }
            }           
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