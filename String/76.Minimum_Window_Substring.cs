/*
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.
A substring is a contiguous sequence of characters within the string.

Example 1:
Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.

Example 2:
Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.

Example 3:
Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.

Constraints:
m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-02 15:15
 To: 2021-06-03 15:55
 *********************************************************************************
 Submission Result:
Runtime: 96 ms, faster than 84.46% of C# online submissions for Minimum Window Substring.
Memory Usage: 41.3 MB, less than 17.85% of C# online submissions for Minimum Window Substring.
 *********************************************************************************
 Note: 
 1. when you move left cursor, left and right cursor could be the same, so it is <=
 2. use could use int[58] to store all character include lower and upper case, remember to minus 65 to make them start from 0
 3. int[26] could only keep lower or upper case char
 *********************************************************************************/
 public class Solution
	{
        //working version
		public string MinWindow(string s, string t)
		{
			string res = "";

			int[] str_arr = new int[58];
			int[] temp_arr = new int[58];

			//if both left_index and right_index equals 0, then not set yet
			int left_index = 0;
			int right_index = 0;

			//required is the count of individual char in string t
			int required = 0;
			int temp_qulified = 0;

			for (int i = 0; i < t.Length; i++)
			{
				str_arr[t[i] - 65]++;

				if (str_arr[t[i] - 65] == 1)
				{
					required++;
				}
			}

			while (right_index < s.Length)
			{
				char temp_char = s[right_index];
				temp_arr[s[right_index] - 65]++;

				if (str_arr[s[right_index] - 65] > 0 && temp_arr[s[right_index] - 65] == str_arr[s[right_index] - 65])
				{
					temp_qulified++;
				}

				//try to move left index
				while (left_index <= right_index && temp_qulified == required)
				{
					if ( /*not set the cursor yet*/string.IsNullOrEmpty(res)
					 /*current lenght is smaller than the one we have*/ || right_index - left_index + 1 < res.Length)
					{
						res = s.Substring(left_index, right_index - left_index + 1);
					}

					temp_arr[s[left_index] - 65]--;

					if (str_arr[s[left_index] - 65] > 0 && temp_arr[s[left_index] - 65] < str_arr[s[left_index] - 65])
					{
						temp_qulified--;
					}

					left_index++;
				}

				right_index++;
			}

			return res;
		}
	}
 public class Solution
{
	public string MinWindow(string s, string t)
	{
		string res = "";
		
		int[] str_arr = new int[58];
		int[] temp_arr = new int[58];
		
		//if both left_index and right_index equals 0, then not set yet
		int left_index = 0;
		int right_index = 0;
		
		//required is the count of individual char in string t
		int required = 0;
		int temp_qulified = 0;
		
		for(int i = 0; i < t.Length; i++)
		{
			str_arr[t[i] - 65]++;
			
			if(str_arr[t[i] - 65] == 1)
			{
				required++;
			}
		}
		
		while(right_index < s.Length)
		{
			char temp_char = s[right_index];
			temp_arr[s[right_index] - 65]++;
			
			if(str_arr[s[right_index] - 65] > 0 && temp_arr[s[right_index] - 65] == str_arr[s[right_index] - 65])
			{
				temp_qulified++;
			}
			
			//try to move left index
			while(left_index < right_index && temp_qulified == required)
			{
				if( /*not set the cursor yet*/string.IsNullOrEmpty(res)
				 /*current lenght is smaller than the one we have*/ || right_index - left_index + 1 < res.Length)
				{
					res = s.Substring(left_index, right_index-left_index + 1);
				}
				
				temp_arr[s[left_index] - 65]--;
				
				if(str_arr[s[left_index] - 65] > 0 && temp_arr[s[left_index] - 65] < str_arr[s[left_index] - 65])
				{
					temp_qulified--;
				}
				
				left_index++;
			}
			
			right_index++;
		}
		
		return res;
	}
}




public class Solution
{
	public string MinWindow(string s, string t)
	{
		string res = s;
		
		int[] str_arr = new int[26];
		Dictionary<char,int> str_dict = new Dictionary<char,int>();
		int[] temp_arr = new int[26];
		Dictionary<char,int> temp_dict = new Dictionary<char,int>();
		
		
		//if both left_index and right_index equals 0, then not set yet
		int left_index = 0;
		int right_index = 0;
		
		//required is the count of individual char in string t
		int required = 0;
		int temp_qulified = 0;
		
		for(int i = 0; i < t.Length; i++)
		{
			if(str_dict.Keys.Contains(t[i]))
			{
				str_dict[t[i]]++;
			}
			else
			{
				str_dict.Add(t[i],1);
			}
			
			//str_arr[t[i] - 'a']++;
			
			if(str_dict[t[i]] == 1)//str_arr[t[i] - 'a'] == 1
			{
				required++;
			}
		}
		
		while(right_index < s.Length)
		{
			//char temp_char = ;
			//temp_arr[s[right_index] - 'a']++;
			
			if(temp_dict.Keys.Contains(s[right_index]))
			{
				temp_dict[s[right_index]]++;
			}
			else
			{
				temp_dict.Add(s[right_index],1);
			}
			
			
			if(str_dict.Keys.Contains(s[right_index]) && temp_dict[s[right_index]] == str_dict[s[right_index]])
			{
				temp_qulified++;
			}
			
			//try to move left index
			while(left_index < right_index && temp_qulified == required)
			{
				if( /*not set the cursor yet*/(left_index == 0 && right_index == 0) 
				|| /*current lenght is smaller than the one we have*/ right_index - left_index + 1 < res.Length)
				{
					res = s.Substring(left_index, right_index-left_index + 1);
				}
				
				temp_arr[s[left_index] - 'a']--;
				
				if(temp_arr[s[left_index] - 'a'] < str_arr[s[left_index] - 'a'])
				{
					temp_qulified--;
				}
				
				left_index++;
			}
			
			right_index++;
		}
		
		return (left_index == 0 && right_index == 0)?"":res;
	}
}
 class Solution {
     //Java solution
  public String minWindow(String s, String t) {

      if (s.length() == 0 || t.length() == 0) {
          return "";
      }

      // Dictionary which keeps a count of all the unique characters in t.
      Map<Character, Integer> dictT = new HashMap<Character, Integer>();
      for (int i = 0; i < t.length(); i++) 
      {
          int count = dictT.getOrDefault(t.charAt(i), 0);
          dictT.put(t.charAt(i), count + 1);
      }

      // Number of unique characters in t, which need to be present in the desired window.
      int required = dictT.size();

      // Left and Right pointer
      int l = 0, r = 0;

      // formed is used to keep track of how many unique characters in t
      // are present in the current window in its desired frequency.
      // e.g. if t is "AABC" then the window must have two A's, one B and one C.
      // Thus formed would be = 3 when all these conditions are met.
      int formed = 0;

      // Dictionary which keeps a count of all the unique characters in the current window.
      Map<Character, Integer> windowCounts = new HashMap<Character, Integer>();

      // ans list of the form (window length, left, right)
      int[] ans = {-1, 0, 0};

      while (r < s.length()) {
          // Add one character from the right to the window
          char c = s.charAt(r);
          int count = windowCounts.getOrDefault(c, 0);
          windowCounts.put(c, count + 1);

          // If the frequency of the current character added equals to the
          // desired count in t then increment the formed count by 1.
          if (dictT.containsKey(c) && windowCounts.get(c).intValue() == dictT.get(c).intValue()) {
              formed++;
          }

          // Try and contract the window till the point where it ceases to be 'desirable'.
          while (l <= r && formed == required) {
              c = s.charAt(l);
              // Save the smallest window until now.
              if (ans[0] == -1 || r - l + 1 < ans[0]) {
                  ans[0] = r - l + 1;
                  ans[1] = l;
                  ans[2] = r;
              }

              // The character at the position pointed by the
              // `Left` pointer is no longer a part of the window.
              windowCounts.put(c, windowCounts.get(c) - 1);
              if (dictT.containsKey(c) && windowCounts.get(c).intValue() < dictT.get(c).intValue()) {
                  formed--;
              }

              // Move the left pointer ahead, this would help to look for a new window.
              l++;
          }

          // Keep expanding the window once we are done contracting.
          r++;   
      }

      return ans[0] == -1 ? "" : s.substring(ans[1], ans[2] + 1);
  }
}

public class Solution
    {
        //not work on "ab" "b", returns "ab" instead of "b"
        public string MinWindow(string s, string t)
        {
            //pre condition
            if (string.IsNullOrEmpty(s) || s.Length < t.Length) { return ""; }
            //normal condition        
            int left = 0, right = 0;            
            string res = "";

            char target_char = '\0';
            bool UsedtoValid = false;
            bool currentValid = false;
            while (right < s.Length && left < s.Length)
            {
                if (left == 0 && !UsedtoValid)
                {
                    //only for first valid substring
                    if (s_Contain_t(s.Substring(left, right - left + 1),t))
                    {
                        //start point
                        //res_left = left;                      
                        res = s.Substring(left, right - left + 1);
                        UsedtoValid = true;
                        currentValid = true;
                    }
                    else
                    {
                        right++;
                    }
                }
                else
                {
                    //already has one res
                    if (currentValid)
                    {
                        if (t.Contains(s[left]))
                        {
                            target_char = s[left];
                            left++;

                            currentValid = s_Contain_t(s.Substring(left, right - left + 1), t);                           
                        }
                        else 
                        {
                            left++;
                        }
                    }
                    else
                    {
                        if (s[right] == target_char)
                        {
                            if (!t.Contains(s[left]))
                            {
                                left++;
                            }
                            else 
                            {
                                //match
                                if (res.Length > s.Substring(left, right - left + 1).Length)
                                {
                                    res = s.Substring(left, right - left + 1);
                                }

                                currentValid = true;
                            }
                          
                        }
                        else 
                        {
                            right++;
                        }
                    }
                }
            }

            return res;
        }

        private bool s_Contain_t(string s, string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (!s.Contains(t[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }