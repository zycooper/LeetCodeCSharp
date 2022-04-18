/*
Design an algorithm to encode a list of strings to a string. 
The encoded string is then sent over the network and is decoded back to the original list of strings.
Machine 1 (sender) has the function:
string encode(vector<string> strs) {
  // ... your code
  return encoded_string;
}
Machine 2 (receiver) has the function:
vector<string> decode(string s) {
  //... your code
  return strs;
}
So Machine 1 does:
string encoded_string = encode(strs);
and Machine 2 does:
vector<string> strs2 = decode(encoded_string);
strs2 in Machine 2 should be the same as strs in Machine 1.
Implement the encode and decode methods.
You are not allowed to solve the problem using any serialize methods (such as eval).

Example 1:
Input: dummy_input = ["Hello","World"]
Output: ["Hello","World"]
Explanation:
Machine 1:
Codec encoder = new Codec();
String msg = encoder.encode(strs);
Machine 1 ---msg---> Machine 2
Machine 2:
Codec decoder = new Codec();
String[] strs = decoder.decode(msg);

Example 2:
Input: dummy_input = [""]
Output: [""]

Constraints:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] contains any possible characters out of 256 valid ASCII characters.
*/

 /********************************************************************************
 Solution Category: 
 Non-ASCII Delimiter
 *********************************************************************************
 Time Range:
 From: 2021-05-14 14:23
 To: 2021-05-14 15:07
 *********************************************************************************
 Submission Result:
Runtime: 268 ms, faster than 69.84% of C# online submissions for Encode and Decode Strings.
Memory Usage: 41 MB, less than 31.75% of C# online submissions for Encode and Decode Strings.
 *********************************************************************************
 Note: 
https://leetcode.com/problems/encode-and-decode-strings/discuss/476762/Easy-C-Solution

string.Join(",",sizeArr)

list has .Count()
array has .Length
 *********************************************************************************/
public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {

        int[] sizeArr = new int[strs.Count()];
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < strs.Count(); i++)
        {
            sizeArr[i] = strs[i].Length; 
            sb.Append(strs[i]);
        }

        return string.Join(",",sizeArr) + "|" + sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {

        //locate the delimiter
        int delimiterLoc = 0;
        while(s[delimiterLoc] != '|')
        {
            delimiterLoc++;
        }

        string[] sizeArr = s.Substring(0,delimiterLoc).Split(new char[]{','});
        List<string> strs = new List<string>();

        int nextDelimiterLoc = delimiterLoc + 1;
        for(int i = 0; i < sizeArr.Length; i++)
        {
            int size =int.Parse(sizeArr[i]);
            strs.Add(s.Substring(nextDelimiterLoc,size));
            nextDelimiterLoc += size;
        }

        return strs;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));